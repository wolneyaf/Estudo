#pragma checksum "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25f382b357494bdf4bd694b468d2909742ed9445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cliente_Index), @"mvc.1.0.view", @"/Views/Cliente/Index.cshtml")]
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
#line 1 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\_ViewImports.cshtml"
using WafSistemas.GerenciadorCliente.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\_ViewImports.cshtml"
using WafSistemas.GerenciadorCliente.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25f382b357494bdf4bd694b468d2909742ed9445", @"/Views/Cliente/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76ad045e501b8278897acc799824619e5cd52a75", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cliente_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WafSistemas.GerenciadorCliente.Service.DTO.Cliente>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
  
    ViewData["Title"] = "Cliente";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Cliente</h1>\r\n<hr />\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25f382b357494bdf4bd694b468d2909742ed94453916", async() => {
                WriteLiteral("<span><i class=\"bi bi-plus-square\"></i> Incluir</span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table table-sm table-striped\">\r\n    <thead class=\"thead-dark\">\r\n        <tr>\r\n            <th>\r\n\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DataLiberação));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
         if (Model != null)
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n");
#nullable restore
#line 39 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                   switch (item.Status)
                    {
                        case 0:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-file-x-fill text-danger\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Bloqueado\"></i>\r\n");
#nullable restore
#line 43 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 1:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-check-circle-fill text-success\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Liberado\"></i>\r\n");
#nullable restore
#line 46 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 2:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-exclamation-triangle-fill text-warning\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Pendente\"></i>\r\n");
#nullable restore
#line 49 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 3:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-currency-exchange text-dark\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Inadimplente\"></i>\r\n");
#nullable restore
#line 52 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 4:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-gift-fill text-primary\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Cortesia\"></i>\r\n");
#nullable restore
#line 55 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 5:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-award-fill text-info\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Vip\"></i>\r\n");
#nullable restore
#line 58 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 6:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-incognito text-secondary\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Teste\"></i>\r\n");
#nullable restore
#line 61 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                        case 9:

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <i class=\"bi bi-file-earmark-fill text-primary\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Cadastrado\"></i>\r\n");
#nullable restore
#line 64 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
                            break;
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Login));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td class=\"col-4\">\r\n                ");
#nullable restore
#line 72 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DataLiberação));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.IdCliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a class=\"btn btn-sm btn-info\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Alterar\"");
            BeginWriteAttribute("href", " href=\"", 3283, "\"", 3348, 1);
#nullable restore
#line 81 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3290, Url.Action("Edit", "Cliente",new { id = item.IdCliente }), 3290, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><i class=\'bi bi-pencil-square\'></i></a>\r\n                <a class=\"btn btn-sm btn-primary\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Detalhe\"");
            BeginWriteAttribute("href", " href=\"", 3501, "\"", 3569, 1);
#nullable restore
#line 82 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3508, Url.Action("Details", "Cliente",new { id = item.IdCliente }), 3508, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><i class=\'bi bi-search\'></i></a>\r\n                <a class=\"btn btn-sm btn-danger\" data-toggle=\"tooltip\" data-placement=\"left\" title=\"Apagar\"");
            BeginWriteAttribute("href", " href=\"", 3713, "\"", 3780, 1);
#nullable restore
#line 83 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
WriteAttributeValue("", 3720, Url.Action("Delete", "Cliente",new { id = item.IdCliente }), 3720, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" ><i class=\'bi bi-x-circle\'></i></a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 86 "C:\Projetos\Git\WafSistemas.GerenciadorCliente\WafSistemas.GerenciadorCliente.Web\Views\Cliente\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WafSistemas.GerenciadorCliente.Service.DTO.Cliente>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
