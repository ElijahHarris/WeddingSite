#pragma checksum "C:\Users\Elijah Harris\source\repos\SecWeddingSite\SecWeddingSite\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "032406297bdd9d2a02aee2b0bf8596b56d8e37de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Elijah Harris\source\repos\SecWeddingSite\SecWeddingSite\Views\_ViewImports.cshtml"
using SecWeddingSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Elijah Harris\source\repos\SecWeddingSite\SecWeddingSite\Views\_ViewImports.cshtml"
using SecWeddingSite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"032406297bdd9d2a02aee2b0bf8596b56d8e37de", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e630fedda631b275a614cca3b907a3220fde9daf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Elijah Harris\source\repos\SecWeddingSite\SecWeddingSite\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    string venmo = "@Eli-Harris-10";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-center"">
        <h1 class=""display-4"">Welcome!</h1>
        <div class=""links"">
            <p>Visit our <a href=""https://www.amazon.com/wedding/share/retrosunflower""> Amazon Registry</a></p>
            <p>Cash App: $EChidwick</p>
            <p>PayPal: PayPal.me/echidwick</p>
            <p>Venmo: ");
#nullable restore
#line 12 "C:\Users\Elijah Harris\source\repos\SecWeddingSite\SecWeddingSite\Views\Home\Index.cshtml"
                 Write(venmo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n");
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
