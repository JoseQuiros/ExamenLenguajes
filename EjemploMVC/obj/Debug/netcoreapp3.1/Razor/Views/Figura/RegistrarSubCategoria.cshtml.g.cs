#pragma checksum "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c36fbf0c54ae4378ef90ae9757d929b577dfa2f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Figura_RegistrarSubCategoria), @"mvc.1.0.view", @"/Views/Figura/RegistrarSubCategoria.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\_ViewImports.cshtml"
using EjemploMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\_ViewImports.cshtml"
using EjemploMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c36fbf0c54ae4378ef90ae9757d929b577dfa2f", @"/Views/Figura/RegistrarSubCategoria.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95f43b4bd5f52233104f97e714d3c5fed198f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Figura_RegistrarSubCategoria : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EjemploMVC.Models.CategoriaModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
  
    ViewData["Title"] = "RegistrarSubCategoria";
    Layout = "~/Views/Shared/_Layout - Copy.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RegistrarSubCategoria</h1>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
 using (Html.BeginForm("registrarSubCategoria", "Figura", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            ");
#nullable restore
#line 14 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
       Write(Html.HiddenFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div>\r\n                ");
#nullable restore
#line 17 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
           Write(Html.LabelFor(d => d.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 18 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
           Write(Html.TextBoxFor(d => d.Id, "", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
           Write(Html.ValidationMessageFor(d => d.Id, null, new { @class = "red" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </div>

            <div>

                <label for=""nombre"">Nombre de la subCategoria</label>
                <input class=""form-control"" id=""nombre"" name=""nombre"" type=""text"">
          


            </div>

            <div>
                <label for=""nombre"">id de la subcategoria</label>
                <input class=""form-control"" id=""idSubCategoria"" name=""idSubCategoria"" type=""text"">         
            </div>



                <br />
                <div style=""text-align:right;"">
                    <input value=""Guardar"" class=""btn btn-primary"" type=""submit"" />
                </div>
            </div>

        </div>
");
#nullable restore
#line 45 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\RegistrarSubCategoria.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EjemploMVC.Models.CategoriaModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
