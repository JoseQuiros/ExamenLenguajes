#pragma checksum "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a4fc0f8a43f6ef94681317514b24d9e0ba7f88c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Figura_ListarFiguras), @"mvc.1.0.view", @"/Views/Figura/ListarFiguras.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a4fc0f8a43f6ef94681317514b24d9e0ba7f88c", @"/Views/Figura/ListarFiguras.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a95f43b4bd5f52233104f97e714d3c5fed198f09", @"/Views/_ViewImports.cshtml")]
    public class Views_Figura_ListarFiguras : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FiguraModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
  
    ViewData["Title"] = "ListarFiguras";
    Layout = "~/Views/Shared/_Layout - Copy.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>ListarFiguras</h1>\r\n\r\n\r\n");
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Nombre</th>\r\n        <th>Marca</th>\r\n        <th>Imagen</th>\r\n        <th>Precio</th>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 21 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
     foreach (FiguraModel temp in ViewBag.Figuras)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
   Write(temp.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
   Write(temp.nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
   Write(temp.marca);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 27 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
   Write(temp.imagen);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
   Write(temp.precio);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    <td>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4fc0f8a43f6ef94681317514b24d9e0ba7f88c5538", async() => {
                WriteLiteral("Eliminar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 584, "~/Figura/eliminarCategoria/", 584, 27, true);
#nullable restore
#line 31 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
AddHtmlAttributeValue("", 611, temp.id, 611, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4fc0f8a43f6ef94681317514b24d9e0ba7f88c7173", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 675, "~/Figura/editarCategoria/", 675, 25, true);
#nullable restore
#line 32 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
AddHtmlAttributeValue("", 700, temp.id, 700, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a4fc0f8a43f6ef94681317514b24d9e0ba7f88c8804", async() => {
                WriteLiteral("Add Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 762, "~/Figura/AddCategoria/", 762, 22, true);
#nullable restore
#line 33 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
AddHtmlAttributeValue("", 784, temp.id, 784, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </td>\r\n</tr>\r\n");
#nullable restore
#line 36 "C:\Users\jqm25\Downloads\ExamenLengjuaes\EjemploMVC\Views\Figura\ListarFiguras.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FiguraModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
