#pragma checksum "C:\Users\Elias\Desktop\ASPNETCoreSignalR\Seção 05\09_Fim\ZapWeb\ZapWebApi\Views\Home\Conversacao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e484a86ba28a7d3e23efe8d52ab946689439c6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Conversacao), @"mvc.1.0.view", @"/Views/Home/Conversacao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Conversacao.cshtml", typeof(AspNetCore.Views_Home_Conversacao))]
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
#line 1 "C:\Users\Elias\Desktop\ASPNETCoreSignalR\Seção 05\09_Fim\ZapWeb\ZapWebApi\Views\_ViewImports.cshtml"
using ZapWebApi;

#line default
#line hidden
#line 2 "C:\Users\Elias\Desktop\ASPNETCoreSignalR\Seção 05\09_Fim\ZapWeb\ZapWebApi\Views\_ViewImports.cshtml"
using ZapWebApi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e484a86ba28a7d3e23efe8d52ab946689439c6d", @"/Views/Home/Conversacao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7d2765d65a58ebf8246897b736bf4456c8a47e9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Conversacao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            DefineSection("style", async() => {
                BeginContext(16, 112, true);
                WriteLiteral("\r\n    <style type=\"text/css\">\r\n        body {\r\n            background-color: #F0F0F0;\r\n        }\r\n    </style>\r\n");
                EndContext();
            }
            );
            BeginContext(131, 1563, true);
            WriteLiteral(@"
<div class=""sidenav"">
    <div class=""container-logo"">
        <img src=""imagem/logo.png"" style=""width: 50%;"" />
    </div>

    <div class=""container-user-item"">
        <img src=""imagem/logo.png"" style=""width: 20%;"" />
        <div>
            <span>Aline</span>
            <span class=""email"">aline123@gmail.com</span>
        </div>
    </div>
    <div class=""container-list"">
        <img src=""imagem/plus.png"" />
        <div class=""container-list-plus"">
            <div>
                <span>Aline - aline123@gmail.com</span>
                <span>Aline - aline123@gmail.com</span>
                <span>Aline - aline123@gmail.com</span>
            </div>
        </div>
    </div>

</div>

<!-- Page content -->
<div class=""main"">
    <div class=""container-messages"">
        <div class=""message message-left"">
            <div class=""message-head"">
                <img src=""imagem/chat.png"" />
                Aline
            </div>
            <div class=""message-message");
            WriteLiteral(@""">
                Olá José! Como vai?
            </div>


        </div>
        <div class=""message message-right"">
            <div class=""message-head"">
                <img src=""imagem/chat.png"" />
                Eu
            </div>
            <div class=""message-message"">
                Olá José! Como vai?
            </div>
        </div>

    </div>

    <div class=""container-button"">
        <input type=""text"" placeholder=""Mensagem"" />
        <button class=""btn-send""></button>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
