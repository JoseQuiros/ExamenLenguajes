using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EjemploMVC.Controllers
{
    public class SessionController : Controller
    {
        public IActionResult Index()
        {

            HttpContext.Session.SetString("variableSession", "valor en session");
            HttpContext.Session.SetInt32("varibleSInt", 0);

            return View();
        }
    }
}
