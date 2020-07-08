using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using EjemploMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Configuration;

namespace EjemploMVC.Controllers
{
    
    public class Figura : Controller
    {
        public IConfiguration Configuration { get; }

        public Figura(IConfiguration configuration) {
            Configuration = configuration;
        } // constructor

        //[Route("nuevadireccion")]
        public IActionResult Index()
        {

            
            int v = (int)HttpContext.Session.GetInt32("varibleSInt")+1;     
            HttpContext.Session.SetInt32("varibleSInt", v);
            
            String resultado = HttpContext.Session.GetString("variableSession") + " Valor:" + HttpContext.Session.GetInt32("varibleSInt");

            return View("Index", resultado);

        }

        public IActionResult Listar()
        {


            List<CategoriaModel> productos = new List<CategoriaModel>();

            if (ModelState.IsValid) {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectionString)) {
                    string sqlQuery = $"exec sp_listar";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection)) {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
                        while (productoReader.Read())
                        {
                            CategoriaModel productoTemp = new CategoriaModel();
                            productoTemp.Id = productoReader["id"].ToString();

                            productoTemp.Nombre = productoReader["nombre"].ToString();

                            productos.Add(productoTemp);
                        } // while
                        connection.Close();
                    }
                }


            } // ModelState.IsValid

            ViewBag.Productos = productos;

            return View();
        }


        public IActionResult ListarFiguras()
        {


            List<FiguraModel> productos = new List<FiguraModel>();

            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = $"exec sp_listarFiguras";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
                        while (productoReader.Read())
                        {
                            FiguraModel productoTemp = new FiguraModel();
                            productoTemp.id = productoReader["id_figura"].ToString();

                            productoTemp.nombre = productoReader["nombre_figura"].ToString();
                            productoTemp.marca = productoReader["marca_figura"].ToString();

                            productoTemp.imagen = productoReader["imagen"].ToString();

                            productoTemp.precio = int.Parse(productoReader["precio"].ToString());


                            productos.Add(productoTemp);
                        } // while
                        connection.Close();
                    }
                }


            } // ModelState.IsValid

            ViewBag.Figuras = productos;

            return View();
        }






        // sub categorias
        [HttpPost]
        public IActionResult RegistrarSubCategoria(SubCategoriaModel productoModel)
        {


            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            CategoriaModel productoTemp = new CategoriaModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec insertSubCategoria @idCategoria='{productoModel.Id}', @nombre='{productoModel.Nombre}', @id='{productoModel.idSubCategoria}'";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }

            } // ModelState.IsValid


            return View();

        } // Registrar


       
        public IActionResult RegistrarSubCategoria(string id)
        {

            CategoriaModel productoTemp = new CategoriaModel();
            productoTemp.Id = id;

            return View(productoTemp);

        }


        //crud categorias

        public IActionResult RegistrarCategoria()
        {

            return View();
        }
        [HttpPost]
        public IActionResult RegistrarCategoria(CategoriaModel productoModel)
        {

            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec insertCategoria @nombre='{productoModel.Nombre}'";

                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }

            } // ModelState.IsValid


            return View();
        } // Registrar






public IActionResult editarCategoria( string id)
{
            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            CategoriaModel productoTemp = new CategoriaModel();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sqlQuery = $"exec selectCategoria @id='{id}'";
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    SqlDataReader productoReader = command.ExecuteReader();
                    while (productoReader.Read())
                    {
                       
                        productoTemp.Id = productoReader["id"].ToString();

                        productoTemp.Nombre = productoReader["nombre"].ToString();

                       
                    } // while
                    connection.Close();
                }
            }


            return View(productoTemp);
       
}

[HttpPost]
public IActionResult editarCategoria(CategoriaModel productoModel)
{
            try
            {
                if (ModelState.IsValid)
                {
                    string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                    CategoriaModel productoTemp = new CategoriaModel();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sqlQuery = $"exec editCategoria @id='{productoModel.Id}', @nombre='{productoModel.Nombre}'";
                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            command.CommandType = CommandType.Text;
                            connection.Open();
                            command.ExecuteReader();
                            connection.Close();
                        }
                    }

                    return Redirect("~/Figura/");
                }

                return View(productoModel);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        } // Registrar




        [HttpGet]
        public IActionResult eliminarCategoria(string id)
        {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                CategoriaModel productoTemp = new CategoriaModel();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = $"exec eliminarCategoria @id='{id}'";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
           
                        connection.Close();
                    }
                }


            return RedirectToAction("Listar", "Figura");



        }

        public IActionResult RegistrarFigura()
        {

            return View();
           
        }

        public IActionResult addCategoria(string id)
        {


            CategoriaModel productoTemp = new CategoriaModel();
            

            productoTemp.Id =  id;

                  
        
            List<SelectListItem> productos = new List<SelectListItem>();

            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sqlQuery = $"exec sp_listar";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.CommandType = CommandType.Text;
                        connection.Open();
                        SqlDataReader productoReader = command.ExecuteReader();
                        while (productoReader.Read())
                        {

                            productos.Add(new SelectListItem
                            {
                                Text = productoReader["nombre"].ToString(),
                                Value = productoReader["id"].ToString()
                            });


                        } // while
                        connection.Close();
                    }
                }


                ViewBag.Categorias = productos;

            } // ModelState.IsValid

                        return View(productoTemp);

        }

        [HttpPost]
        public IActionResult RegistrarFigura(FiguraModel productoModel)
        {

            if (ModelState.IsValid)
            {
                string connectionString = Configuration["ConnectionStrings:DB_Connection"];
                var connection = new SqlConnection(connectionString);
                string sqlQuery = $"exec insertFigura @nombre='{productoModel.nombre}'," +
                    $"@marca='{productoModel.marca}'," +
                    $"@imagen='{productoModel.imagen}'," +
                    $"@precio='{productoModel.precio}'";

                //@id ,@nombre ,@marca ,@imagen ,@precio
                using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                {
                    command.CommandType = CommandType.Text;
                    connection.Open();
                    command.ExecuteReader();
                    connection.Close();
                }

            } // ModelState.IsValid


            return View();
        } // Registrar

    

    [HttpGet]
    public IActionResult RegistrarFiguraCategoria(string categoria)
    {

        
            string connectionString = Configuration["ConnectionStrings:DB_Connection"];
            var connection = new SqlConnection(connectionString);
            string sqlQuery = $"exec insertCategoriaFigura @id='{categoria}'";

            //@id ,@nombre ,@marca ,@imagen ,@precio
            using (SqlCommand command = new SqlCommand(sqlQuery, connection))
            {
                command.CommandType = CommandType.Text;
                connection.Open();
                command.ExecuteReader();
                connection.Close();
            }

        return View();


    } // Registrar

} // fin clase
}
//figura

