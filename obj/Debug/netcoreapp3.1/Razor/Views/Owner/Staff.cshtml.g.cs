#pragma checksum "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Staff.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45b884777f221fac3481ac964c716a970e929e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_Staff), @"mvc.1.0.view", @"/Views/Owner/Staff.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Staff.cshtml"
using AnimalHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b884777f221fac3481ac964c716a970e929e45", @"/Views/Owner/Staff.cshtml")]
    public class Views_Owner_Staff : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Сотрудники\r\n</p>\r\n");
#nullable restore
#line 5 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Staff.cshtml"
 foreach(StaffModel staff in ViewBag.Staffs)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
#nullable restore
#line 7 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Staff.cshtml"
              Write(staff.salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Staff.cshtml"
            }

#line default
#line hidden
#nullable disable
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
