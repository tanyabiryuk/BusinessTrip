#pragma checksum "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0da3e54962a83cbd042c95b5ae5547fdcbd699d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Applications_Create), @"mvc.1.0.view", @"/Views/Applications/Create.cshtml")]
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
#line 1 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\_ViewImports.cshtml"
using BusinessTrip.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0da3e54962a83cbd042c95b5ae5547fdcbd699d", @"/Views/Applications/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1110f9e2465ec0046b8dd691b7e57a37367be7bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Applications_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusinessTrip.Models.Application>
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0da3e54962a83cbd042c95b5ae5547fdcbd699d3324", async() => {
                WriteLiteral("\r\n    <script src=\"https://code.jquery.com/jquery-3.1.0.min.js\"></script>\r\n\r\n");
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
            WriteLiteral("\r\n<section>\r\n    <h1>Заявка на відрядження</h1>\r\n\r\n");
#nullable restore
#line 13 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <h4></h4>\r\n            <hr />\r\n            ");
#nullable restore
#line 18 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Email, "Електронна адреса"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 23 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br /><hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 31 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Fullname, "1. Ваше прізвище, ім'я, по- батькові (в родовому відмінку)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Fullname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 34 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Fullname, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br /><hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 41 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Main_place_of_work, "2.Вкажіть підрозділ та посаду за основним місцем праці"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 43 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Main_place_of_work));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 44 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Main_place_of_work, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br /><hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 51 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Position_in_combination, "3.Вкажіть відділ та посаду за сумісництвом (за наявності)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 53 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Position_in_combination));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 54 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Position_in_combination, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br /><hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 61 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Type, "4. Вкажіть тип відрядження"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 63 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Type, "Відрядження по Україні", new { onclick = "hideCountry()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>Відрядження по Україні</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 66 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Type, "Відрядження закордон", new { onclick = "showCountry()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <label>Відрядження закордон</label>
                    <script type=""text/javascript"">
                        function showCountry() {
                            document.getElementById('country').style.display = ""block"";
                            document.getElementById('way').style.display = ""none"";
                            document.getElementById('transport').style.display = ""none"";
                        };
                        function hideCountry() {
                            document.getElementById('country').style.display = ""none"";
                            document.getElementById('way').style.display = ""block"";
                            document.getElementById('transport').style.display = ""block"";
                        };
                    </script>
                </div>
            </div>

            <br /><hr />

            <div class=""form-group"">
                ");
#nullable restore
#line 86 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Purpose, "4. Вкажіть мету відрядження"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 88 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Purpose, "З метою реалізації права на академічну мобільність відповідно до Постанови Кабінету Міністрів України від 12.08.2019 р. №579",
                   new { onchange = "otherHide(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>З метою реалізації права на академічну мобільність відповідно до Постанови Кабінету Міністрів України від 12.08.2019 р. №579</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 92 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Purpose, "проходження стажування",
                   new { onchange = "otherHide(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>проходження стажування</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 96 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Purpose, "для викладу лекційного курсу",
                   new { onchange = "otherHide(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>для викладу лекційного курсу</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 100 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Purpose, "участь в проектній зустрічі",
                   new { onchange = "otherHide(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>участь в проектній зустрічі</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 104 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Purpose, "участь у тренінгу",
                   new { onchange = "otherHide(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>участь у тренінгу</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 108 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Purpose, "Інше",
                   new { id = "r6" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label for=\"otherAnswer\">Інше:</label>\r\n                    <div id=\"otherAnswer\" style=\"display:none\">\r\n                        ");
#nullable restore
#line 112 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.EditorFor(model => model.Purpose, new { oninput = "otherRes(this)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </fieldset>
                <script type=""text/javascript"">
                    var purpose;
                    function otherHide(radiobutton) {
                        document.getElementById('otherAnswer').style.display = ""none"";
                        purpose = radiobutton.value;
                    };
                    $('#r6').click(function () {
                        document.getElementById('otherAnswer').style.display = ""block"";
                    });
                </script>
            </div>

            <br /><hr />

            <div class=""form-group"">
                ");
#nullable restore
#line 130 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Saving_salary, "5. Вкажіть вид збереження заробітної плати"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <fieldset>\r\n                    ");
#nullable restore
#line 132 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Saving_salary, "зі збереженням середньої зарплати за основним місце праці"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>зі збереженням середньої зарплати за основним місце праці</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 135 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Saving_salary, "зі збереженням середньої зарплати за основним місцем праці та за сумісництвом"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>зі збереженням середньої зарплати за основним місцем праці та за сумісництвом</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 138 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Saving_salary, "без збереження заробітної плати (тривалість відрядження більше 10-ти днів)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>без збереження заробітної плати (тривалість відрядження більше 10-ти днів)</label>\r\n                </fieldset>\r\n            </div>\r\n\r\n            <br /><hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 146 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Trip_city, "6. Вкажіть місто відрядження "));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 148 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Trip_city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 149 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Trip_city, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br /><hr />\r\n            <div class=\"form-group\" id=\"country\" style=\"display:none\">\r\n                ");
#nullable restore
#line 155 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Trip_country, "7. Вкажіть країну відрядження (для закордонного відрядження)"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 157 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Trip_country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 158 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Trip_country, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <br /><hr />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 165 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Institution, "8. Вкажіть установу, куди відряджаєтесь"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 167 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Institution, "Міністерство освіти і науки України",
                   new { onchange = "otherInstHide()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>Міністерство освіти і науки України</label>\r\n                    <br />\r\n                    ");
#nullable restore
#line 171 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.RadioButtonFor(model => model.Institution, "Інше",
                   new { onchange = "otherInstShow()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label for=\"otherInstitut\">Інше:</label>\r\n                    <div id=\"otherInstitut\" style=\"display:none\">\r\n                        ");
#nullable restore
#line 175 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.EditorFor(model => model.Institution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    ");
#nullable restore
#line 177 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Institution, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                <script type=""text/javascript"">
                    function otherInstHide() {
                        document.getElementById('otherInstitut').style.display = ""none"";
                    };
                    function otherInstShow() {
                        document.getElementById('otherInstitut').style.display = ""block"";
                    };
                </script>
            </div>

            <div class=""form-group"">
                ");
#nullable restore
#line 190 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.LabelFor(model => model.Institution, "8. Вкажіть адресу установи куди відряджаєтесь"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <div>\r\n                    ");
#nullable restore
#line 192 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.EditorFor(model => model.Institution));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 193 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Institution, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n                <br /><hr />\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 199 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.LabelFor(model => model.Start_date, "9. Вкажіть дату початку відрядження"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        ");
#nullable restore
#line 201 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.TextBoxFor(model => model.Start_date, new { @type = "date", @class = "form-control datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 202 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Start_date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <br /><hr />\r\n\r\n                <div class=\"form-group\">\r\n                    ");
#nullable restore
#line 209 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.LabelFor(model => model.Start_date, "10. Вкажіть дату завершення відрядження"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        ");
#nullable restore
#line 211 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.TextBoxFor(model => model.End_date, new { @type = "date", @class = "form-control datepicker" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 212 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.End_date, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <br /><hr />\r\n\r\n                <div class=\"form-group\" id=\"way\" style=\"display:none\">\r\n                    ");
#nullable restore
#line 219 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.LabelFor(model => model.Itinerary, "11. Вкажіть маршрут поїздки (для відряджень по Україні). Наприклад: Львів-Київ-Львів"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div class=\"col-md-10\">\r\n                        ");
#nullable restore
#line 221 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.EditorFor(model => model.Itinerary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 222 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Itinerary, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n                <br /><hr />\r\n                <div class=\"form-group\" id=\"transport\" style=\"display:none\">\r\n                    ");
#nullable restore
#line 228 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.LabelFor(model => model.App_transport_Id, "12. Вкажіть транспорт, яким будете подорожувати (для відряджень по Україні)."));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div>
                        <input type=""checkbox"" id=""checkTransport1"" value=""Залізничий"">
                        <label for=""checkTransport1"">Залізничий</label><br>
                        <input type=""checkbox"" id=""checkTransport2"" value=""Автомобільний"">
                        <label for=""checkTransport2"">Автомобільний</label><br>
                        <input type=""checkbox"" id=""checkTransport3"" value=""Літак"">
                        <label for=""checkTransport3"">Літак</label><br>
                        <input type=""checkbox"" id=""checkTransport4"" value=""Інше"">
                        <label for=""checkTransport4"">Інше:</label><br>
                        <div id=""otherTransport"" style=""display:none"">
                            ");
#nullable restore
#line 239 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                       Write(Html.EditorFor(model => model.Institution));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <script type=""text/javascript"">
                        $('#checkTransport4').click(function () {
                            if (document.getElementById('checkTransport4').checked == true)
                                document.getElementById('otherTransport').style.display = ""block"";
                            else document.getElementById('otherTransport').style.display = ""none"";
                        })
                    </script>
                </div>

                <br /><hr />

                <div class=""form-group"">
                    ");
#nullable restore
#line 254 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.LabelFor(model => model.Payment, "13. Вкажіть, як буде здійснюватись оплата видатків на відрядження"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <div>\r\n                        ");
#nullable restore
#line 256 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.RadioButtonFor(model => model.Payment, "за власний кошт/ за рахунок приймаючої сторони",
                       new { onchange = "otherPaymentHide()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>за власний кошт/ за рахунок приймаючої сторони</label>\r\n                        <br />\r\n                        ");
#nullable restore
#line 260 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.RadioButtonFor(model => model.Payment, "витрати на проїзд, добові за рахунок коштів факультету відповідно до кошторису",
                       new { onchange = "otherPaymentHide()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>витрати на проїзд, добові за рахунок коштів факультету відповідно до кошторису</label>\r\n                        <br />\r\n                        ");
#nullable restore
#line 264 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.RadioButtonFor(model => model.Payment, "витрати на проїзд, добові за рахунок коштів університету відповідно до кошторису",
                       new { onchange = "otherPaymentHide()" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label>витрати на проїзд, добові за рахунок коштів університету відповідно до кошторису</label>\r\n                        <br />\r\n                        ");
#nullable restore
#line 268 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                   Write(Html.RadioButtonFor(model => model.Payment, "Інше",
                       new { id = "op" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <label for=\"otherPayment\">Інше:</label>\r\n                        <div id=\"otherPayment\" style=\"display:none\">\r\n                            ");
#nullable restore
#line 272 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
                       Write(Html.EditorFor(model => model.Payment));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                        <script type=""text/javascript"">
                            function otherPaymentHide() {
                                document.getElementById('otherPayment').style.display = ""none"";
                            };
                            $('#op').click(function () {
                                document.getElementById('otherPayment').style.display = ""block"";
                            });
                        </script>
                    </div>
                </div>

                <br /><hr />

                <div class=""form-group"">
                    ");
#nullable restore
#line 288 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
               Write(Html.LabelFor(model => model.App_fundation_Id, "14. Вкажіть підставу відрядження "));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    <div>
                        <input type=""checkbox"" id=""checkFoundation1"" value=""запрошення"">
                        <label for=""checkFoundation1"">запрошення</label><br>
                        <input type=""checkbox"" id=""checkFoundation2"" value=""витяг з протоколу засідання Вченої Ради факультету"">
                        <label for=""checkFoundation2"">витяг з протоколу засідання Вченої Ради факультету</label><br>
                        <input type=""checkbox"" id=""checkFoundation3"" value=""рапорт проректора"">
                        <label for=""checkFoundation3"">рапорт проректора</label><br>
                        <input type=""checkbox"" id=""checkFoundation4"" value=""Інше"">
                        <label for=""checkFoundation4"">Інше:</label><br>
                        <div id=""otherFoundation"" style=""display:none"">
                            <input type=""text"" />
                        </div>
                    </div>

                    <script type=""text/javascript"">
 ");
            WriteLiteral(@"                       $('#checkFoundation4').click(function () {
                            if (document.getElementById('checkFoundation4').checked == true)
                                document.getElementById('otherFoundation').style.display = ""block"";
                            else document.getElementById('otherFoundation').style.display = ""none"";
                        })
                    </script>
                </div>

                <br /><hr />

                <div class=""form-group"">
                    <label>16. Про зміни у суттєвих умовах відрядження (дострокового повернення, зміні дати повернення) повідомити працівників відділу кадрів в найкоротший термін на електронну пошту vk101dok@gmail.com *</label>
                    <div>
                        <input type=""checkbox"" id=""acceptCheckBox"" value=""Зобов'язуюсь повідомити"">
                        <label for=""acceptCheckBox"">Зобов'язуюсь повідомити</label><br>
                    </div>
                </div>

  ");
            WriteLiteral(@"              <br /><hr />


                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" />
                    </div>
                </div>
            </div>
            <div>
                ");
#nullable restore
#line 332 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
           Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 335 "C:\Users\Dell\Desktop\BusinessTrip1\BusinessTrip\Views\Applications\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n\r\n");
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
