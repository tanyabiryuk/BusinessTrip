#pragma checksum "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a2f9fecdce2f165ed374e1dd322b7c1c1ba3b8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\Home\About.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\Home\About.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a2f9fecdce2f165ed374e1dd322b7c1c1ba3b8b", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1110f9e2465ec0046b8dd691b7e57a37367be7bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\r\n");
#nullable restore
#line 8 "C:\Users\Dell\Desktop\BusinessTrip\BusinessTrip\Views\Home\About.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        if (((ClaimsIdentity)User.Identity).Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value).Where(r => r == "admin").Count() != 0) { Layout = "~/Views/Shared/_AdminLayout.cshtml"; }
        else { Layout = "~/Views/Shared/_Layout.cshtml"; }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Тут інформація про нас</h1>\r\n</section>\r\n\r\n");
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
