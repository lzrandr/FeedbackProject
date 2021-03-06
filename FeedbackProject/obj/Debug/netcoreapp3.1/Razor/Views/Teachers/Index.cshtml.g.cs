#pragma checksum "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d5448998844442728319f717af4ec486ca2d502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teachers_Index), @"mvc.1.0.view", @"/Views/Teachers/Index.cshtml")]
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
#line 1 "D:\GIT\FeedbackProject\FeedbackProject\Views\_ViewImports.cshtml"
using FeedbackProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GIT\FeedbackProject\FeedbackProject\Views\_ViewImports.cshtml"
using FeedbackProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5448998844442728319f717af4ec486ca2d502", @"/Views/Teachers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"966dd18d413872cce059f2b431f77be863dfab3d", @"/Views/_ViewImports.cshtml")]
    public class Views_Teachers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FeedbackProject.Models.Teacher>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Teachers</h2>\r\n");
#nullable restore
#line 7 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>We don\'t have any teachers yet.</p>\r\n");
#nullable restore
#line 10 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-bordered table-hover\">\r\n        <thead>\r\n            <tr>\r\n                <th>Teacher</th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 20 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
             foreach (var teacher in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 23 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
                   Write(Html.ActionLink(teacher.FirstName, "Details", "Teachers", new { id = teacher.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 25 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 28 "D:\GIT\FeedbackProject\FeedbackProject\Views\Teachers\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FeedbackProject.Models.Teacher>> Html { get; private set; }
    }
}
#pragma warning restore 1591
