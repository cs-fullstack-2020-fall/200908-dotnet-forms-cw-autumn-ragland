#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e012f3c1768464e3c22a4d3d62dabd31f059a4b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookAuthor_Error), @"mvc.1.0.view", @"/Views/BookAuthor/Error.cshtml")]
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
#line 1 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\_ViewImports.cshtml"
using BookAuthors;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\_ViewImports.cshtml"
using BookAuthors.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e012f3c1768464e3c22a4d3d62dabd31f059a4b1", @"/Views/BookAuthor/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977ebd620a649fbc748c703698948a8b46cb5f7c", @"/Views/_ViewImports.cshtml")]
    public class Views_BookAuthor_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"jumbotron jumbotron-fluid\">\r\n  <div class=\"container\">\r\n    <h1 class=\"display-4\">Whoops!</h1>\r\n    <h3 class=\"text-danger\">");
#nullable restore
#line 4 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\Error.cshtml"
                       Write(ViewData["error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n  </div>\r\n</div>");
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
