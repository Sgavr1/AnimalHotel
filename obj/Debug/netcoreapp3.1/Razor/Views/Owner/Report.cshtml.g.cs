#pragma checksum "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24788a5c8dbce2f8a60010cacbf2df9517fd88df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_Report), @"mvc.1.0.view", @"/Views/Owner/Report.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
using AnimalHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24788a5c8dbce2f8a60010cacbf2df9517fd88df", @"/Views/Owner/Report.cshtml")]
    public class Views_Owner_Report : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24788a5c8dbce2f8a60010cacbf2df9517fd88df4805", async() => {
                WriteLiteral("\r\n         <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor\" crossorigin=\"anonymous\">\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24788a5c8dbce2f8a60010cacbf2df9517fd88df5305", async() => {
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
                WriteLiteral("\r\n           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24788a5c8dbce2f8a60010cacbf2df9517fd88df6578", async() => {
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
                WriteLiteral("\r\n             ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "24788a5c8dbce2f8a60010cacbf2df9517fd88df7853", async() => {
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
                WriteLiteral("\r\n    ");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24788a5c8dbce2f8a60010cacbf2df9517fd88df9827", async() => {
                WriteLiteral(@"
    <header>
    <div class=""nav"">
        <ul class=""main_nav"">
            <li><a href=""/Owner/Branch"">Відділення</a></li>
            <li> <a href=""/Owner/Staff"">Співробітники</a></li>
            <li>  <a href=""/Owner/ControlType"">Управління Типами</a></li>
            <li>  <a href=""/Owner/Room"">Кімнати</a></li>
            <li class=""active""> <a href=""/Owner/Report"">Звіти</a></li>
            <li> <a href=""/Owner/Out"">Выйти</a></li>
        </ul>
    </div>
    </header>
    <div>

        <div class=""all_form"">
        <form action=""/Owner/AllReportByBranch"">
            <ul>
                <li>
                    <label>Отделение</label>
                </li>
                <li>
");
#nullable restore
#line 31 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                     for (int i = 0; i < ViewBag.Branches.Count; i++)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 1388, "\"", 1402, 2);
                WriteAttributeValue("", 1393, "branch_", 1393, 7, true);
#nullable restore
#line 33 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
WriteAttributeValue("", 1400, i, 1400, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"branch\"");
                BeginWriteAttribute("value", " value=\"", 1417, "\"", 1448, 1);
#nullable restore
#line 33 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
WriteAttributeValue("", 1425, ViewBag.Branches[i].id, 1425, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1484, "\"", 1499, 2);
                WriteAttributeValue("", 1490, "branch_", 1490, 7, true);
#nullable restore
#line 34 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
WriteAttributeValue("", 1497, i, 1497, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                                          Write(ViewBag.Branches[i].city);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                                                                    Write(ViewBag.Branches[i].street);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                                                                                                Write(ViewBag.Branches[i].number_house);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 35 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </li>
            </ul>
            <button class= ""main_button"" type=""submit"">Отчет поasd Отделению</button>
        </form>


        <form action=""/Owner/AllReportByYear"">
            <ul>
                <li>
                    <label>Год</label>
                </li>
                <li>
                    <input type=""number"" name=""year"" />
                </li>
            </ul>
            <button class= ""main_button"" type=""submit"">Отчет за год</button>
        </form>

        <form action=""/Owner/AllReport"">
            <button class= ""main_button"" type=""submit"">За всё время</button>
        </form>
    

    <div class=""reports"">
        <p>Всего зарабтано: ");
#nullable restore
#line 60 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                       Write(ViewBag.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n        <p>Всего заказов: ");
#nullable restore
#line 61 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                     Write(ViewBag.TotalCountOrder);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n        <p>Всего животных: ");
#nullable restore
#line 62 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                      Write(ViewBag.TotalCountAnimal);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n        <p>Всего заказано услуг: ");
#nullable restore
#line 63 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Report.cshtml"
                            Write(ViewBag.TotalCountService);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> \r\n    </div>\r\n    </div>\r\n\r\n    </div>\r\n");
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
