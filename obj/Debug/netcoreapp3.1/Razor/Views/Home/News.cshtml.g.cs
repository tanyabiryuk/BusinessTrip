#pragma checksum "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13dff13fd7e81c72f2aca2b565979c397f8120a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
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
#line 1 "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\Home\News.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\Home\News.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13dff13fd7e81c72f2aca2b565979c397f8120a1", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1110f9e2465ec0046b8dd691b7e57a37367be7bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\Home\News.cshtml"
  
    ViewData["Title"] = "News";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section>\r\n");
#nullable restore
#line 9 "C:\Users\userPC\Desktop\Last\BusinessTrip\Views\Home\News.cshtml"
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
            WriteLiteral("\r\n    <h1>Тут деякі новини</h1>\r\n</section>\r\n\r\n\r\n");
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