#pragma checksum "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e639e5e021f784732a63c0f999db43635d2a8025"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/admin/Projects/PriceTag/PriceTag/Views/_ViewImports.cshtml"
using PriceTag;

#line default
#line hidden
#line 2 "/Users/admin/Projects/PriceTag/PriceTag/Views/_ViewImports.cshtml"
using PriceTag.Models;

#line default
#line hidden
#line 1 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
using System.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e639e5e021f784732a63c0f999db43635d2a8025", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a87b2ca9df7c53d89a8878d3b6acec5a4eaad7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "PriceTag";

#line default
#line hidden
            BeginContext(65, 57, true);
            WriteLiteral("\r\n<h4 class=\"pt-5 pb-3\">Items</h4>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
     foreach (DataRow dr in ViewBag.Items)
    {

#line default
#line hidden
            BeginContext(173, 71, true);
            WriteLiteral("        <div class=\"card ml-3\" style=\"width: 18rem;\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 244, "\"", 273, 2);
            WriteAttributeValue("", 250, "/images/", 250, 8, true);
#line 12 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
WriteAttributeValue("", 258, dr["FileName"], 258, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(274, 110, true);
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
            EndContext();
            BeginContext(385, 10, false);
#line 14 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
                                  Write(dr["Name"]);

#line default
#line hidden
            EndContext();
            BeginContext(395, 44, true);
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
            EndContext();
            BeginContext(440, 17, false);
#line 15 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
                                Write(dr["Description"]);

#line default
#line hidden
            EndContext();
            BeginContext(457, 42, true);
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 18 "/Users/admin/Projects/PriceTag/PriceTag/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(506, 106, true);
            WriteLiteral("</div>\r\n\r\n<div class=\"pt-5\">\r\n    <a href=\"/Home/PrintTags\" class=\"btn btn-primary\">Print Tags</a>\r\n</div>");
            EndContext();
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
