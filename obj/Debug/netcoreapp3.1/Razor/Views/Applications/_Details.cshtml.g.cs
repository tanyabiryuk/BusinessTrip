#pragma checksum "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e525106a81b436e42a2f1e6f254a6e203cfd54d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications__Details), @"mvc.1.0.view", @"/Views/Applications/_Details.cshtml")]
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
#line 2 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e525106a81b436e42a2f1e6f254a6e203cfd54d", @"/Views/Applications/_Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1110f9e2465ec0046b8dd691b7e57a37367be7bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Applications__Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessTrip.Models.Application>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
  
    ViewData["Title"] = "Редагувати";
    if (((ClaimsIdentity)User.Identity).Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value).Where(r => r == "admin").Count() != 0) { Layout = "~/Views/Shared/_AdminLayout.cshtml"; }
    else { Layout = "~/Views/Shared/_Layout.cshtml"; }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!DOCTYPE htm>\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e525106a81b436e42a2f1e6f254a6e203cfd54d4196", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>caption-side</title>
    <style>
        table {
            width: 80%;
            border-collapse: collapse;
        }

        td {
            border: 1px solid black;
            padding: 5px;
        }

        caption {
            caption-side: top;
            font-family: 'Segoe UI';
            font-size: xx-large;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<section>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e525106a81b436e42a2f1e6f254a6e203cfd54d5593", async() => {
                WriteLiteral("\r\n\r\n        <table align=\"center\">\r\n            <caption><b>Деталі заявки: Заявка №  ");
#nullable restore
#line 42 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
                                            Write(Html.DisplayFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></caption>\r\n\r\n            <tr>\r\n                <td><b>Email:</b></td>\r\n                <td>");
#nullable restore
#line 46 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n            </tr>\r\n            <tr>\r\n                <td><b>Прізвище,ім\'я,по батькові</b></td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Fullname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Підрозділ та посада за основним місцем праці</b></td>\r\n                <td>");
#nullable restore
#line 56 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Main_place_of_work));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Відділ та посада за сумісництвом (за наявності)</b></td>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Position_in_combination));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Тип відрядження</b></td>\r\n                <td>");
#nullable restore
#line 64 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Мета відрядження</b></td>\r\n                <td>");
#nullable restore
#line 68 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Purpose));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Вид збереження заробітної плати</b></td>\r\n                <td>");
#nullable restore
#line 72 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Saving_salary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Місто відрядження</b></td>\r\n                <td>");
#nullable restore
#line 76 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Trip_city));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Країна відрядження</b></td>\r\n                <td>");
#nullable restore
#line 80 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Trip_country));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b> Установа, куди відряджаєтесь</b></td>\r\n                <td>");
#nullable restore
#line 84 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Institution));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Адреса установи куди відряджаєтесь</b></td>\r\n                <td>");
#nullable restore
#line 88 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.InstitutionLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Дата початку відрядження</b></td>\r\n                <td>");
#nullable restore
#line 92 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Start_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Дата завершення відрядження</b></td>\r\n                <td>");
#nullable restore
#line 96 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.End_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td><b>Маршрут</b></td>\r\n                <td>");
#nullable restore
#line 100 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\_Details.cshtml"
               Write(Html.DisplayFor(m => m.Itinerary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n            </tr>\r\n            \r\n        </table>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n<br/>\r\n<br/>\r\n</section>\r\n");
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
