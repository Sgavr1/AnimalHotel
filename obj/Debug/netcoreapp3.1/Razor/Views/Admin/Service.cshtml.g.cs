#pragma checksum "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d830fadd50cf13f654df19f60336377d4cabdf8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Service), @"mvc.1.0.view", @"/Views/Admin/Service.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
using AnimalHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d830fadd50cf13f654df19f60336377d4cabdf8e", @"/Views/Admin/Service.cshtml")]
    public class Views_Admin_Service : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_navigation.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_form.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d830fadd50cf13f654df19f60336377d4cabdf8e4811", async() => {
                WriteLiteral("\r\n         <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor\" crossorigin=\"anonymous\">\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d830fadd50cf13f654df19f60336377d4cabdf8e5311", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d830fadd50cf13f654df19f60336377d4cabdf8e6578", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d830fadd50cf13f654df19f60336377d4cabdf8e7845", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d830fadd50cf13f654df19f60336377d4cabdf8e9823", async() => {
                WriteLiteral(@"
    <header>
    <div class=""nav"">
        <ul class=""main_nav"">
            <li> <a href=""/Admin/Staff"">Співробітники</a></li>
            <li>  <a href=""/Admin/Room"">Кімнати</a></li>
            <li> <a href=""/Admin/Report"">Звіти</a></li>
            <li class=""active""> <a href=""/Admin/Service"">Послуги</a></li>
            <li> <a href=""/Admin/Out"">Выйти</a></li>
        </ul>
    </div>
    </header>


    <div>
   <div class=""all_form"">
            <h2>Форма добавления услуг</h2>
        <form action=""/Admin/AddService"">
            <ul>
                <li>
                    <label>Название</label>
                </li>
                <li>
                    <input type=""text"" name=""name"" />
                </li>
                <li>
                    <label>Животное</label>
                </li>
                <li>
");
#nullable restore
#line 39 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                     for (int i = 0; i < ViewBag.AnimalType.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1527, "\"", 1545, 2);
                WriteAttributeValue("", 1532, "animalType_", 1532, 11, true);
#nullable restore
#line 41 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
WriteAttributeValue("", 1543, i, 1543, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"animalType\"");
                BeginWriteAttribute("value", " value=\"", 1564, "\"", 1597, 1);
#nullable restore
#line 41 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
WriteAttributeValue("", 1572, ViewBag.AnimalType[i].id, 1572, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1633, "\"", 1652, 2);
                WriteAttributeValue("", 1639, "animalType_", 1639, 11, true);
#nullable restore
#line 42 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
WriteAttributeValue("", 1650, i, 1650, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 42 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                              Write(ViewBag.AnimalType[i].name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 43 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </li>
                <li>
                    <label>Цена</label>
                </li>
                <li>
                    <input type=""number"" name=""price"" />
                </li>
            </ul>
            <input type=""submit"" value=""Добавить новую услугу"" />
        </form>
        </div>


         <div class=""all_types"">

    
        <div class=""types"" id=""room_types"">
                <p>Все типы комнат</p>
");
#nullable restore
#line 62 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
             foreach (RoomTypeModel roomType in ViewBag.RoomType)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 64 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
              Write(roomType.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 65 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n\r\n        <div class=\"types\" id=\"pet_types\">\r\n                    <p>Все типы животных</p>\r\n");
#nullable restore
#line 71 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
             foreach (AnimalTypeMode animalType in ViewBag.AnimalType)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 73 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
              Write(animalType.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 74 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        </div>\r\n\r\n\r\n        <div class=\"uslugi\"> \r\n        <h2>Все услуги</h2>\r\n");
#nullable restore
#line 82 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
             foreach (ServiceModel service in ViewBag.Service)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"types\" id=\"usl_types\" >\r\n                <p>");
#nullable restore
#line 85 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
              Write(ViewBag.Branch.city);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                   Write(ViewBag.Branch.street);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 85 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                                          Write(ViewBag.Branch.number_house);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 86 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                 if (service.status)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>");
#nullable restore
#line 88 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                  Write(service.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 88 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                Write(service.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 88 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                               Write(service.animalType.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <a class=\"open_close\"");
                BeginWriteAttribute("href", " href=\"", 3072, "\"", 3110, 2);
                WriteAttributeValue("", 3079, "/Admin/CloseService/", 3079, 20, true);
#nullable restore
#line 89 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
WriteAttributeValue("", 3099, service.id, 3099, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">закрыть</a>\r\n");
#nullable restore
#line 90 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>");
#nullable restore
#line 93 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                  Write(service.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 93 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                Write(service.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 93 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                                               Write(service.animalType.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <a class=\"open_close\"");
                BeginWriteAttribute("href", " href=\"", 3308, "\"", 3345, 2);
                WriteAttributeValue("", 3315, "/Admin/OpenService/", 3315, 19, true);
#nullable restore
#line 94 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
WriteAttributeValue("", 3334, service.id, 3334, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">открыть</a>\r\n");
#nullable restore
#line 95 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 97 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Admin\Service.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n    </div>\r\n\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
