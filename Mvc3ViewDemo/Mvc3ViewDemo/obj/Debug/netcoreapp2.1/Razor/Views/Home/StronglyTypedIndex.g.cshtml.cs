#pragma checksum "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\Home\StronglyTypedIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac12b7d840e7d34e6f7c721e13a2f6c3c30325e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StronglyTypedIndex), @"mvc.1.0.view", @"/Views/Home/StronglyTypedIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/StronglyTypedIndex.cshtml", typeof(AspNetCore.Views_Home_StronglyTypedIndex))]
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
#line 1 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\_ViewImports.cshtml"
using Mvc3ViewDemo;

#line default
#line hidden
#line 2 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\_ViewImports.cshtml"
using Mvc3ViewDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac12b7d840e7d34e6f7c721e13a2f6c3c30325e1", @"/Views/Home/StronglyTypedIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4bc78125a534b4f863bce7082a82574b729ecf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StronglyTypedIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mvc3ViewDemo.Controllers.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\Home\StronglyTypedIndex.cshtml"
  
    ViewData["Title"] = "StronglyTypedIndex";

#line default
#line hidden
            BeginContext(105, 42, true);
            WriteLiteral("\r\n<h2> Strongly Typed Index</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 9 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\Home\StronglyTypedIndex.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(190, 14, true);
            WriteLiteral("        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 204, "\"", 220, 1);
#line 12 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\Home\StronglyTypedIndex.cshtml"
WriteAttributeValue("", 211, item.URL, 211, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(221, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(223, 9, false);
#line 12 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\Home\StronglyTypedIndex.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(232, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 13 "C:\Users\randy\source\repos\CT-406\Mvc3ViewDemo\Mvc3ViewDemo\Views\Home\StronglyTypedIndex.cshtml"

    }

#line default
#line hidden
            BeginContext(252, 7, true);
            WriteLiteral("</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mvc3ViewDemo.Controllers.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
