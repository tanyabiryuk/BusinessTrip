#pragma checksum "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18387ee0e5ff8e828b29d41258a57a9cca5b81c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_GenerateApp), @"mvc.1.0.view", @"/Views/Applications/GenerateApp.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18387ee0e5ff8e828b29d41258a57a9cca5b81c7", @"/Views/Applications/GenerateApp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1110f9e2465ec0046b8dd691b7e57a37367be7bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Applications_GenerateApp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessTrip.Models.Application>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
  
    ViewData["Title"] = "Редагувати";
    if (((ClaimsIdentity)User.Identity).Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value).Where(r => r == "admin").Count() != 0) { Layout = "~/Views/Shared/_AdminLayout.cshtml"; }
    else { Layout = "~/Views/Shared/_Layout.cshtml"; }

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <p align=\"right\">Ректору</p>\r\n    <p align=\"right\">Львівського національного</p>\r\n    <p align=\"right\">університету</p>\r\n    <p align=\"right\">імені Івана Франка</p>\r\n    <p align=\"right\">проф. Мельнику В. П. </p>\r\n    <p align=\"right\">");
#nullable restore
#line 20 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
                Write(Html.DisplayFor(m => m.Main_place_of_work));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p align=\"right\">");
#nullable restore
#line 21 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
                Write(Html.DisplayFor(m => m.Position_in_combination));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p align=\"right\">");
#nullable restore
#line 22 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
                Write(Html.DisplayFor(m => m.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n    <p align=\"center\">Заява</p>\r\n    <p align=\"center\">\r\n        Прошу вас відрядити мене ");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
                            Write(Html.DisplayFor(m => m.Saving_salary));

#line default
#line hidden
#nullable disable
            WriteLiteral(" y ");
#nullable restore
#line 25 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
                                                                     Write(Html.DisplayFor(m => m.Trip_city));

#line default
#line hidden
#nullable disable
            WriteLiteral(" з\r\n        метою ");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\GenerateApp.cshtml"
         Write(Html.DisplayFor(m => m.Purpose));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n    <td>\r\n    </td>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusinessTrip.Models.Application> Html { get; private set; }
    }
}
#pragma warning restore 1591
