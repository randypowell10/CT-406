#pragma checksum "C:\Users\randy\source\repos\CT-406\ControllerDI\Views\Settings\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46842c2e3496fd91a709b62d905c8958c7f312e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Settings_Index), @"mvc.1.0.view", @"/Views/Settings/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Settings/Index.cshtml", typeof(AspNetCore.Views_Settings_Index))]
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
#line 1 "C:\Users\randy\source\repos\CT-406\ControllerDI\Views\_ViewImports.cshtml"
using ControllerDI;

#line default
#line hidden
#line 2 "C:\Users\randy\source\repos\CT-406\ControllerDI\Views\_ViewImports.cshtml"
using ControllerDI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46842c2e3496fd91a709b62d905c8958c7f312e7", @"/Views/Settings/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a4e53226910a5674016ed161e8501a6ec8bd2cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Settings_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 54, true);
            WriteLiteral("<h2>Configuration Settings</h2>\r\n<p>\r\n    Site Title: ");
            EndContext();
            BeginContext(55, 17, false);
#line 3 "C:\Users\randy\source\repos\CT-406\ControllerDI\Views\Settings\Index.cshtml"
           Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(72, 26, true);
            WriteLiteral("\r\n</p>\r\n<p>\r\n    Updates: ");
            EndContext();
            BeginContext(99, 19, false);
#line 6 "C:\Users\randy\source\repos\CT-406\ControllerDI\Views\Settings\Index.cshtml"
        Write(ViewData["Updates"]);

#line default
#line hidden
            EndContext();
            BeginContext(118, 6, true);
            WriteLiteral("\r\n</p>");
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