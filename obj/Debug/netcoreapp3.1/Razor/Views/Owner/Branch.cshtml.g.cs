#pragma checksum "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Branch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea2abaaf4b47c0645ad878040ab0a317c555f1bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Owner_Branch), @"mvc.1.0.view", @"/Views/Owner/Branch.cshtml")]
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
#line 1 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Branch.cshtml"
using AnimalHotel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea2abaaf4b47c0645ad878040ab0a317c555f1bf", @"/Views/Owner/Branch.cshtml")]
    public class Views_Owner_Branch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<p>\r\n    Отделения\r\n</p>\r\n");
#nullable restore
#line 5 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Branch.cshtml"
 foreach (BranchModel branch in ViewBag.Branches)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>branch = ");
#nullable restore
#line 7 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Branch.cshtml"
           Write(branch.city);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 8 "C:\Users\Alex\Desktop\Бд Карина\Git\AnimalHotel\Views\Owner\Branch.cshtml"
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
