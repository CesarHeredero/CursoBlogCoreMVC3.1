#pragma checksum "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f13044f3553fd270990f20a1976153d1b3c9a742"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Cliente_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Cliente/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\_ViewImports.cshtml"
using BlogCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\_ViewImports.cshtml"
using BlogCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f13044f3553fd270990f20a1976153d1b3c9a742", @"/Areas/Cliente/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"784938c45a729b1006f16b3b5ebaebddb8e24285", @"/Areas/Cliente/Views/_ViewImports.cshtml")]
    public class Areas_Cliente_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogCore.Models.ViewModels.HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<header>\r\n    <div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 10 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
               int cont = 0; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
             foreach (var item in Model.Slider)
            {
                var itemDinamico = cont++ == 0 ? "item active" : "item";

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 425, "\"", 460, 2);
            WriteAttributeValue("", 433, "carousel-item", 433, 13, true);
#nullable restore
#line 14 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 446, itemDinamico, 447, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <img width=\"100%\" height=\"300px\"");
            BeginWriteAttribute("src", " src=\"", 516, "\"", 550, 1);
#nullable restore
#line 15 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
WriteAttributeValue("", 522, Url.Content(item.UrlImagen), 522, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <h1 class=\"text-dark text-center\">");
#nullable restore
#line 16 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
                                                 Write(Html.Raw(@item.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
                <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
                <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>
</header>
<hr />
<div>
    <h1 class=""badge-primary text-center"" style=""height:150px;"">Titulo principal</h1>
</div>
");
#nullable restore
#line 34 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
 if (Model.ListaArticulo.Count() > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr />\r\n    <main>\r\n        <div class=\"card-deck\">\r\n");
#nullable restore
#line 39 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
             foreach (var art in Model.ListaArticulo.OrderBy(o => o.Id))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1610, "\"", 1643, 1);
#nullable restore
#line 42 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
WriteAttributeValue("", 1616, Url.Content(art.UrlImagen), 1616, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 44 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
                                          Write(Html.Raw(art.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 45 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
                                        Write(Html.Raw(art.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 46 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
                                                                  Write(Html.Raw(art.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                        <p class=\"card-text text-white\"><small class=\"badge-info p-2\" style=\"border-radius:20px;\">");
#nullable restore
#line 47 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
                                                                                                             Write(Html.Raw(art.Categoria.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f13044f3553fd270990f20a1976153d1b3c9a74210344", async() => {
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
                                                  WriteLiteral(art.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 51 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </main>\r\n");
#nullable restore
#line 55 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"alert alert-danger\">No existe contenido</p>\r\n");
#nullable restore
#line 59 "C:\Users\Cesar\Documents\GitHub\MasterAspNetCore3.1\CursoBlogCoreMVC3.1\BlogCore\BlogCore\Areas\Cliente\Views\Home\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogCore.Models.ViewModels.HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
