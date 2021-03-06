#pragma checksum "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7be8914b8a9e7aa3cede0a3fed098c767307c4c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_ChangeStatus), @"mvc.1.0.view", @"/Views/Applications/ChangeStatus.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
using BusinessTrip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7be8914b8a9e7aa3cede0a3fed098c767307c4c2", @"/Views/Applications/ChangeStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1110f9e2465ec0046b8dd691b7e57a37367be7bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Applications_ChangeStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Application>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
  
    ViewData["Title"] = "Редагувати";
    if (((ClaimsIdentity)User.Identity).Claims
                    .Where(c => c.Type == ClaimTypes.Role)
                    .Select(c => c.Value).Where(r => r == "admin").Count() != 0) { Layout = "~/Views/Shared/_AdminLayout.cshtml"; }
    else { Layout = "~/Views/Shared/_Layout.cshtml"; }

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
  
    ViewBag.Title = "Список заявок";
    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <section>\r\n        <h2>Змінити статус заявки</h2>\r\n        <p>Всього заявок: ");
#nullable restore
#line 19 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                      Write(Model.Count<Application>());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <table>\r\n\r\n");
#nullable restore
#line 22 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
             foreach (var item in Model)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td><b>");
#nullable restore
#line 26 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n\r\n                    <td>\r\n                        ");
#nullable restore
#line 29 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Lifecycle.Opened));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 32 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                   Write(Html.DisplayFor(modelItem => item.User.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                     using (Html.BeginForm())
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>\r\n                            ");
#nullable restore
#line 38 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                       Write(Html.Hidden("requestId", item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 39 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                       Write(Html.Display(item.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                             if (item.Status == (int)Application.RequestStatus.Open)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                           Write(Html.DropDownList("status", new[] { new SelectListItem() { Text = "На перевірці", Value = "2" },
                                    new SelectListItem() { Text = "Закрита", Value = "3" },new SelectListItem() { Text = "Відхилено", Value = "4" }}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                                                                                                                                                     
                            }
                            else if (item.Status == (int)Application.RequestStatus.Checking)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                           Write(Html.DropDownList("status", new[] { new SelectListItem() { Text = "Закрита", Value = "3" }, new SelectListItem() { Text = "Відхилено", Value = "4" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                                                                                                                                                                                        
                            }
                            else if (item.Status == (int)Application.RequestStatus.Rejected)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                           Write(Html.DropDownList("status", new[] { new SelectListItem() { Text = "Закрита", Value = "3" }, new SelectListItem() { Text = "На перевірці", Value = "2" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                                                                                                                                                                                           
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <input type=\"submit\" value=\"Змінити статус\" class=\"btn\"/>\r\n                        </td>\r\n");
#nullable restore
#line 58 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tr>\r\n");
#nullable restore
#line 60 "C:\Users\Dell\Desktop\CustomIdentityApp\BusinessTrip\Views\Applications\ChangeStatus.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n        <br />\r\n        <br />\r\n        <br />\r\n    </section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Application>> Html { get; private set; }
    }
}
#pragma warning restore 1591
