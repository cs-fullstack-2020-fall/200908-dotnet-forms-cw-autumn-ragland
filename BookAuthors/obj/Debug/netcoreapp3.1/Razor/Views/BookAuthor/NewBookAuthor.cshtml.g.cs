#pragma checksum "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "159b983bffd55120d4bec24e9176d83947094921"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BookAuthor_NewBookAuthor), @"mvc.1.0.view", @"/Views/BookAuthor/NewBookAuthor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"159b983bffd55120d4bec24e9176d83947094921", @"/Views/BookAuthor/NewBookAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"977ebd620a649fbc748c703698948a8b46cb5f7c", @"/Views/_ViewImports.cshtml")]
    public class Views_BookAuthor_NewBookAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookAuthors.Models.BookAuthorModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Add New Book Auhtor</h1>\r\n");
#nullable restore
#line 3 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
 if(@ViewData["errors"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n    ");
#nullable restore
#line 6 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
Write(ViewData["errors"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 8 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
 using (@Html.BeginForm("AddBookAuthor", "BookAuthor"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 12 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
   Write(Html.LabelFor(auth => auth.fName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 13 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
   Write(Html.TextBoxFor(auth => auth.fName, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 16 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
   Write(Html.LabelFor(auth => auth.lName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 17 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
   Write(Html.TextBoxFor(auth => auth.lName, new { @class="form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-check\">\r\n        ");
#nullable restore
#line 20 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
   Write(Html.CheckBoxFor(auth => auth.isActive, new { @class="form-check-input" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 21 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
   Write(Html.LabelFor(auth => auth.isActive, new { @class="form-check-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n");
#nullable restore
#line 24 "C:\Users\student\Code_School\cohort5\sprint_three\dotnet\200908\200908-dotnet-forms-cw-autumn-ragland\BookAuthors\Views\BookAuthor\NewBookAuthor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookAuthors.Models.BookAuthorModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
