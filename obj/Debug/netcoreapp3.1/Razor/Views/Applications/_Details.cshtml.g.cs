#pragma checksum "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5de91c52dc2c6c230d521a864652ad21e4f136c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications__Details), @"mvc.1.0.view", @"/Views/Applications/_Details.cshtml")]
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
#line 1 "D:\Поект остання версія\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Поект остання версія\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5de91c52dc2c6c230d521a864652ad21e4f136c2", @"/Views/Applications/_Details.cshtml")]
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
            WriteLiteral("\r\n<!DOCTYPE htm>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de91c52dc2c6c230d521a864652ad21e4f136c23269", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>caption-side</title>
    <style>
        table {
            width: 80%; /* Ширина таблицы */
            border-collapse: collapse; /* Убираем двойную рамку между ячейками */
        }

        td {
            border: 1px solid green; /* Параметры границы */
            padding: 5px; /* Поля в ячейке */
        }

        caption {
            caption-side: top; /* Заголовок под таблицей */
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5de91c52dc2c6c230d521a864652ad21e4f136c24710", async() => {
                WriteLiteral("\r\n   \r\n    <table align=\"center\">\r\n        <caption><b>Деталі заявки: Заявка №  ");
#nullable restore
#line 27 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
                                        Write(Html.DisplayFor(m => m.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</b></caption>\r\n\r\n        <tr>\r\n            <td><b>Email:</b></td>\r\n            <td>");
#nullable restore
#line 31 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n        <tr>\r\n            <td><b>Прізвище,ім\'я,по батькові</b></td>\r\n            <td>");
#nullable restore
#line 37 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Fullname));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Підрозділ та посада за основним місцем праці</b></td>\r\n            <td>");
#nullable restore
#line 41 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Main_place_of_work));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Відділ та посада за сумісництвом (за наявності)</b></td>\r\n            <td>");
#nullable restore
#line 45 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Position_in_combination));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Тип відрядження</b></td>\r\n            <td>");
#nullable restore
#line 49 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Type));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Мета відрядження</b></td>\r\n            <td>");
#nullable restore
#line 53 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Purpose));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Вид збереження заробітної плати</b></td>\r\n            <td>");
#nullable restore
#line 57 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Saving_salary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Місто відрядження</b></td>\r\n            <td>");
#nullable restore
#line 61 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Trip_city));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Країна відрядження</b></td>\r\n            <td>");
#nullable restore
#line 65 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Trip_country));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b> Установа, куди відряджаєтесь</b></td>\r\n            <td>");
#nullable restore
#line 69 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Institution));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Адреса установи куди відряджаєтесь</b></td>\r\n            <td>");
#nullable restore
#line 73 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.InstitutionLocation));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Дата початку відрядження</b></td>\r\n            <td>");
#nullable restore
#line 77 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Start_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Дата завершення відрядження</b></td>\r\n            <td>");
#nullable restore
#line 81 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.End_date));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Маршрут</b></td>\r\n            <td>");
#nullable restore
#line 85 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Itinerary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><b>Маршрут</b></td>\r\n            <td>");
#nullable restore
#line 89 "D:\Поект остання версія\BusinessTrip\Views\Applications\_Details.cshtml"
           Write(Html.DisplayFor(m => m.Itinerary));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n</html> ");
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