#pragma checksum "C:\Users\rgome\Desktop\Repo GitHub\SOLID\Views\Home\Depositar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12b2a82f81bf770d0c8c1cc247a3b9cd4247ab72"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Depositar), @"mvc.1.0.view", @"/Views/Home/Depositar.cshtml")]
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
#line 1 "C:\Users\rgome\Desktop\Repo GitHub\SOLID\Views\_ViewImports.cshtml"
using SOLID;

#line default
#line hidden
#line 2 "C:\Users\rgome\Desktop\Repo GitHub\SOLID\Views\_ViewImports.cshtml"
using SOLID.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b2a82f81bf770d0c8c1cc247a3b9cd4247ab72", @"/Views/Home/Depositar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19a503b782738fc76d6a90504fc9dab70488e232", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Depositar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SOLID.Models.Conta>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\rgome\Desktop\Repo GitHub\SOLID\Views\Home\Depositar.cshtml"
  
    ViewData["Title"] = "Depositar";

#line default
#line hidden
            WriteLiteral("\r\n<h2>Depositar</h2>\r\n\r\n<div class=\"card\">\r\n  <div class=\"card-header\">\r\n    Resultado\r\n  </div>\r\n  <div class=\"card-body\">\r\n      <h5 class=\"card-title\">Depositado com sucesso!</h5>\r\n      <p class=\"card-text\">\r\n          ");
#line 15 "C:\Users\rgome\Desktop\Repo GitHub\SOLID\Views\Home\Depositar.cshtml"
     Write(Html.Label("Saldo Atual: "));

#line default
#line hidden
            WriteLiteral("\r\n          ");
#line 16 "C:\Users\rgome\Desktop\Repo GitHub\SOLID\Views\Home\Depositar.cshtml"
     Write(Html.DisplayFor(md => Model.Saldo));

#line default
#line hidden
            WriteLiteral("\r\n      </p>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SOLID.Models.Conta> Html { get; private set; }
    }
}
#pragma warning restore 1591