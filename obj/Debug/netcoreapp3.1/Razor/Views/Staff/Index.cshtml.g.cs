#pragma checksum "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Staff_Index), @"mvc.1.0.view", @"/Views/Staff/Index.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
using AnimalHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"603cb0ef5dac7b276a0da55fbdee4d39ea822b8e", @"/Views/Staff/Index.cshtml")]
    public class Views_Staff_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_navigation.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_form.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style_staff.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e5159", async() => {
                WriteLiteral("\r\n\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.2.0-beta1/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-0evHe/X+R7YkIZDRvuzKMRqM+OrBnVFBL6DOitfPri4tjfHxaWutUpFmBp4vmVor\" crossorigin=\"anonymous\">\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e5658", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e6925", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e8192", async() => {
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
                WriteLiteral("\r\n     ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e9459", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "603cb0ef5dac7b276a0da55fbdee4d39ea822b8e11437", async() => {
                WriteLiteral(@"
    <header>
        <a href=""/Staff/Out"">Выйти</a>
    </header>
    <div>


        <div class=""all_form"">
            <form action=""/Staff/AddClient"">
                <ul>
                    <li>
                        <label>Телефон</label>
                    </li>
                    <li>
                        <input type=""tel"" name=""tel"" />
                    </li>
                    <li>
                        <label>Имя</label>
                    </li>
                    <li>
                        <input type=""text"" name=""first_name"" />
                    </li>
                    <li>
                        <label>Фамилия</label>
                    </li>
                    <li>
                        <input type=""text"" name=""last_name"" />
                    </li>
                    <li>
                        <label>Дата рождения</label>
                    </li>
                    <li>
                        <input type=""date"" name=""day_of_birth");
                WriteLiteral(@""" />
                    </li>
                    <li>
                        <label>Город</label>
                    </li>
                    <li>
                        <input type=""text"" name=""city"" />
                    </li>
                    <li>
                        <label>Улица</label>
                    </li>
                    <li>
                        <input type=""text"" name=""street"" />
                    </li>
                    <li>
                        <label>Номер дома</label>
                    </li>
                    <li>
                        <input type=""number"" name=""number_house"" />
                    </li>
                </ul>
               <input type=""submit"" value =""Добавить клиента"" />
            </form>
        </div>


        <div class=""main_order"">
            <div class=""all_form"">
            <form action=""/Staff/CheckClient"">
                <ul>
                    <li>
                        <label>Номер телефона");
                WriteLiteral(@"</label>
                    </li>
                    <li>
                        <input type=""tel"" name=""tel"" />
                    </li>
                </ul>
                <input type=""submit"" value=""Проверить"" />
            </form>
            </div>

");
#nullable restore
#line 85 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
             if (ViewBag.Client.id != 0)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>");
#nullable restore
#line 87 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
              Write(ViewBag.Client.first_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 87 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                         Write(ViewBag.Client.last_name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                <div class=""all_form"">
                    <p>Добавить животного</p>
                    <form action=""/Staff/AddAnimal"">
                        <ul>
                            <li>
                                <label>Тип Животного</label>
                            </li>
                            <li>
");
#nullable restore
#line 96 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                 for (int i = 0; i < ViewBag.AnimalType.Count; i++)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 3555, "\"", 3573, 2);
                WriteAttributeValue("", 3560, "animalType_", 3560, 11, true);
#nullable restore
#line 98 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 3571, i, 3571, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"animalType\"");
                BeginWriteAttribute("value", " value=\"", 3592, "\"", 3625, 1);
#nullable restore
#line 98 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 3600, ViewBag.AnimalType[i].id, 3600, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 3673, "\"", 3692, 2);
                WriteAttributeValue("", 3679, "animalType_", 3679, 11, true);
#nullable restore
#line 99 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 3690, i, 3690, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 99 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                                          Write(ViewBag.AnimalType[i].name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 100 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </li>
                            <li>
                                <label>Имя</label>
                            </li>
                            <li>
                                <input type=""text"" name=""name""/>
                            </li>
                        </ul>
                        <input type=""submit"" value =""Добавить Животное"" />
                    </form>
                </div>
                <div class=""all_form"">
                    <h2>Заказ</h2>
");
#nullable restore
#line 114 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                     if(ViewBag.Animal.id != 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <p>");
#nullable restore
#line 116 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                  Write(ViewBag.Animal.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 117 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                     if(ViewBag.SelectedRoom.id != 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <p>Номер комнаты ");
#nullable restore
#line 119 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                    Write(ViewBag.SelectedRoom.number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> <a");
                BeginWriteAttribute("href", " href=\"", 4564, "\"", 4624, 2);
                WriteAttributeValue("", 4571, "/Staff/RemoveRoomAnimalOrder/", 4571, 29, true);
#nullable restore
#line 119 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 4600, ViewBag.SelectedRoom.id, 4600, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Убрать</a>\r\n                        <p>Услуги</p>\r\n");
#nullable restore
#line 121 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                         foreach(ServiceModel service in ViewBag.SelectedServices)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p>");
#nullable restore
#line 123 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                          Write(service.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <a");
                BeginWriteAttribute("href", " href=\"", 4868, "\"", 4918, 2);
                WriteAttributeValue("", 4875, "/Staff/RemoveServiceAnimalOrder/", 4875, 32, true);
#nullable restore
#line 124 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 4907, service.id, 4907, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Убрать</a>\r\n");
#nullable restore
#line 125 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <form action=""/Staff/AddAnimalToOrder"">
                            <ul>
                                <li>
                                    <label>Количество дней</label>
                                </li>
                                <li>
                                    <input type=""number"" name=""countDay""/>
                                </li>
                                <li>
                                    <label>Скидка</label>
                                </li>
                                <li>
                                    <input type=""number"" name=""sale""/>
                                </li>
                            </ul>
                            <button type=""submit"">Добавить в заказ</button>
                        </form>
");
#nullable restore
#line 143 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div>
                        <p>Найти комнату по типу</p>
                        <form action=""/Staff/RoomToOrderAnimal"">
                            <ul>
                                <li>
                                    <label>Тип Комнаты</label>
                                </li>
                                <li>
");
#nullable restore
#line 153 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                     for (int i = 0; i < ViewBag.RoomType.Count; i++)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"radio\"");
                BeginWriteAttribute("id", " id=\"", 6356, "\"", 6374, 2);
                WriteAttributeValue("", 6361, "animalType_", 6361, 11, true);
#nullable restore
#line 155 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 6372, i, 6372, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"type\"");
                BeginWriteAttribute("value", " value=\"", 6387, "\"", 6418, 1);
#nullable restore
#line 155 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 6395, ViewBag.RoomType[i].id, 6395, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 6470, "\"", 6489, 2);
                WriteAttributeValue("", 6476, "animalType_", 6476, 11, true);
#nullable restore
#line 156 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 6487, i, 6487, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 156 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                                              Write(ViewBag.RoomType[i].name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n");
#nullable restore
#line 157 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </li>\r\n                            </ul>\r\n                            <button class = \"staff_btn\" type=\"submit\">Найти</button>\r\n                        </form>\r\n\r\n");
#nullable restore
#line 163 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                         if (ViewBag.SelectedRoom.id == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                             foreach (RoomModel room in ViewBag.RoomAnimalOrder)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div>\r\n                                    <p>");
#nullable restore
#line 168 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                  Write(room.number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 169 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                  Write(room.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 7150, "\"", 7187, 2);
                WriteAttributeValue("", 7157, "/Staff/fillSelectRoom/", 7157, 22, true);
#nullable restore
#line 170 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7179, room.id, 7179, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Выбрать</a>\r\n                                </div>\r\n");
#nullable restore
#line 172 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                             
                        }
                        else
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                             foreach (ServiceModel service in ViewBag.ServiceAnimals)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div>\r\n                                    <p>");
#nullable restore
#line 179 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                  Write(service.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p>");
#nullable restore
#line 180 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                  Write(service.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <a");
                BeginWriteAttribute("href", " href=\"", 7669, "\"", 7714, 2);
                WriteAttributeValue("", 7676, "/Staff/fillSelectedService/", 7676, 27, true);
#nullable restore
#line 181 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 7703, service.id, 7703, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Выбрать</a>\r\n                                </div>\r\n");
#nullable restore
#line 183 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 183 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </div>\r\n");
#nullable restore
#line 186 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"all_form\">\r\n                    <p>В заказе</p>\r\n");
#nullable restore
#line 190 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                     foreach (AnimalOrderModel animalOrder in ViewBag.Orders.animalOrders)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div>\r\n                            <p>");
#nullable restore
#line 193 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                          Write(animalOrder.animal.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" в комнату номер ");
#nullable restore
#line 193 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                                                   Write(animalOrder.room.number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                            <p>скидка ");
#nullable restore
#line 194 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                 Write(animalOrder.sale);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p><p>Цена ");
#nullable restore
#line 194 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                                              Write(animalOrder.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 195 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                             foreach (ServiceOrderModel serviceOrder in animalOrder.serviceOrders)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div>\r\n                                    <p>");
#nullable restore
#line 198 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                  Write(serviceOrder.service.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Цена ");
#nullable restore
#line 198 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                                                  Write(serviceOrder.price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <form action=\"/Staff/InputSaleService\">\r\n                                        <input type=\"number\" name=\"animalId\"");
                BeginWriteAttribute("value", " value=\"", 8711, "\"", 8734, 1);
#nullable restore
#line 200 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8719, animalOrder.id, 8719, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /><!--недолжно быть видно-->\r\n                                        <input type=\"number\" name=\"serviceId\"");
                BeginWriteAttribute("value", " value=\"", 8843, "\"", 8867, 1);
#nullable restore
#line 201 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 8851, serviceOrder.id, 8851, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" /><!--недолжно быть видно-->
                                        <ul>
                                            <li>
                                                <label>Скидка</label>
                                            </li>
                                            <li>
                                                <input type=""number"" name=""sale""");
                BeginWriteAttribute("value", " value=\"", 9247, "\"", 9273, 1);
#nullable restore
#line 207 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 9255, serviceOrder.sale, 9255, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                            </li>
                                        </ul>
                                        <button type=""submit"">Скидка</button>
                                    </form>
                                </div>
");
#nullable restore
#line 213 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <a");
                BeginWriteAttribute("href", " href=\"", 9602, "\"", 9649, 2);
                WriteAttributeValue("", 9609, "/Staff/RemoveAnimarOrder/", 9609, 25, true);
#nullable restore
#line 214 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 9634, animalOrder.id, 9634, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Удалить</a>\r\n                        </div>\r\n");
#nullable restore
#line 216 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <!-- <p>Цена ");
#nullable restore
#line 217 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                            Write(ViewBag.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>-->\r\n                </div>\r\n                    <a href=\"/Staff/InsertOrder\">Создать заказ</a>\r\n                    <a href=\"/Staff/CloseOrder\">Очистить</a>\r\n              \r\n\r\n\r\n                <div>\r\n");
#nullable restore
#line 225 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                     foreach(AnimalModel animal in ViewBag.Animals)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div>\r\n                        <p>");
#nullable restore
#line 228 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                      Write(animal.animalType.name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 228 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                                              Write(animal.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 10182, "\"", 10220, 2);
                WriteAttributeValue("", 10189, "/Staff/AnimalToOrder/", 10189, 21, true);
#nullable restore
#line 229 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
WriteAttributeValue("", 10210, animal.id, 10210, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Добавить в заказ</a>\r\n                    </div>\r\n");
#nullable restore
#line 231 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                  </div>\r\n");
#nullable restore
#line 234 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </div>





        <div class=""return_pet"">
            <p>Вернуть животных</p>
            <form action=""/Staff/RealseRoom"">
                <ul>
                    <li>
                        <label>Номер телефона</label>
                    </li>
                    <li>
                        <input type=""tel"" name=""tel"" />
                    </li>
                </ul>
                <button type=""submit"">Проверить</button>
            </form>
");
#nullable restore
#line 254 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
             foreach(int number in ViewBag.numberRoom)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <p>комната номер ");
#nullable restore
#line 256 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
                            Write(number);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 257 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Staff\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    </div>\r\n");
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
