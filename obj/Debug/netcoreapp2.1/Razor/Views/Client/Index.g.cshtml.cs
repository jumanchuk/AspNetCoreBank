#pragma checksum "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9c7ff92e56b86643afc9756f05d36773b881507"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Client_Index), @"mvc.1.0.view", @"/Views/Client/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Client/Index.cshtml", typeof(AspNetCore.Views_Client_Index))]
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
#line 1 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\_ViewImports.cshtml"
using AspNetCoreBank;

#line default
#line hidden
#line 2 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\_ViewImports.cshtml"
using AspNetCoreBank.Models;

#line default
#line hidden
#line 2 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9c7ff92e56b86643afc9756f05d36773b881507", @"/Views/Client/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6205f65f47c88e8afbb7b868a7c65649f90b8a4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Client_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ClientViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Operations", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
  
ViewData["Title"] = "Busqueda de Cliente";

#line default
#line hidden
            BeginContext(95, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(175, 17, false);
#line 9 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(192, 293, true);
            WriteLiteral(@"</div>
    <table class=""table table-hover"">
        <thead>
            <tr>
                <td>Ver</td>
                <td>Documento</td>
                <td>Nombre</td>
                <td>Apellido</td>
                <td>Fecha de Alta</td>
            </tr>
        </thead>
");
            EndContext();
#line 20 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
         foreach (var Client in Model.Clients)
        {

#line default
#line hidden
            BeginContext(544, 34, true);
            WriteLiteral("            <tr>\r\n                ");
            EndContext();
            BeginContext(578, 404, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6df129db55554a339659534f40676573", async() => {
                BeginContext(622, 158, true);
                WriteLiteral("\r\n                    <td><button class=\"btn btn-default glyphicon glyphicon-search\" type=\"submit\"></button></td>\r\n                    <td asp-for=\"Document\">");
                EndContext();
                BeginContext(781, 15, false);
#line 25 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
                                      Write(Client.Document);

#line default
#line hidden
                EndContext();
                BeginContext(796, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(828, 11, false);
#line 26 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
                   Write(Client.Name);

#line default
#line hidden
                EndContext();
                BeginContext(839, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(871, 15, false);
#line 27 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
                   Write(Client.Lastname);

#line default
#line hidden
                EndContext();
                BeginContext(886, 31, true);
                WriteLiteral("</td>\r\n                    <td>");
                EndContext();
                BeginContext(918, 34, false);
#line 28 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
                   Write(Client.Date.ToString("dd/mm/yyyy"));

#line default
#line hidden
                EndContext();
                BeginContext(952, 23, true);
                WriteLiteral("</td>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(982, 21, true);
            WriteLiteral("\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1014, 70, true);
            WriteLiteral("    </table>\r\n\r\n    <div class=\"panel-footer add-item-form\">\r\n        ");
            EndContext();
            BeginContext(1085, 63, false);
#line 35 "C:\Users\juryu\Documents\1.Repositorio\AspNetCoreBank\AspNetCoreBank\Views\Client\Index.cshtml"
   Write(await Html.PartialAsync("SearchClientPartial", new ClientRow()));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 26, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ClientViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
