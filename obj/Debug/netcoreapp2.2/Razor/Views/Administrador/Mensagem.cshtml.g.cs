#pragma checksum "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b37cca395b8df17b643e677348c82112991f057a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administrador_Mensagem), @"mvc.1.0.view", @"/Views/Administrador/Mensagem.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administrador/Mensagem.cshtml", typeof(AspNetCore.Views_Administrador_Mensagem))]
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
#line 1 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\_ViewImports.cshtml"
using RoletopMvc;

#line default
#line hidden
#line 2 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\_ViewImports.cshtml"
using RoletopMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b37cca395b8df17b643e677348c82112991f057a", @"/Views/Administrador/Mensagem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b96063e499db17dee5727bcc8bb384efb8db60e", @"/Views/_ViewImports.cshtml")]
    public class Views_Administrador_Mensagem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoletopMvc.ViewModels.DashboardViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 80, true);
            WriteLiteral("\r\n<main>\r\n            <div class=\"enviar\">\r\n                <h4>Mensagens</h4>\r\n");
            EndContext();
#line 6 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml"
             foreach (var item in @Model.Mensagem)
            {

#line default
#line hidden
            BeginContext(196, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(216, 699, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b37cca395b8df17b643e677348c82112991f057a4084", async() => {
                BeginContext(289, 84, true);
                WriteLiteral("\r\n                            <input type=\"email\" name=\"emaildamensagem\" alt=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 373, "\"", 400, 1);
#line 9 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml"
WriteAttributeValue("", 381, item.cliente.Email, 381, 19, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(401, 70, true);
                WriteLiteral(" disabled>\r\n                            <input type=\"text\" name=\"text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 471, "\"", 493, 1);
#line 10 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml"
WriteAttributeValue("", 479, item.Objetivo, 479, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(494, 72, true);
                WriteLiteral(" disabled>\r\n                            <input type=\"email\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", "  value=\"", 566, "\"", 598, 1);
#line 11 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml"
WriteAttributeValue("", 575, item.MensagemDoCliente, 575, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(599, 309, true);
                WriteLiteral(@" disabled>
                            <input type=""text"" name=""tituloDoTexto"" placeholder=""Titulo Do Email"">
                            <input type=""text"" name=""resposta"" placeholder=""Escrever Resposta"">
                            <input type=""submit"" name=""submit"" value=""Enviar"">
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 8 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml"
AddHtmlAttributeValue("", 244, Url.Action("EnviarEmail", "Administrador"), 244, 43, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(915, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 16 "c:\Users\henri\Desktop\RoleTop-MVC-SENAI\Views\Administrador\Mensagem.cshtml"
            }

#line default
#line hidden
            BeginContext(932, 27, true);
            WriteLiteral("            </div>\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoletopMvc.ViewModels.DashboardViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
