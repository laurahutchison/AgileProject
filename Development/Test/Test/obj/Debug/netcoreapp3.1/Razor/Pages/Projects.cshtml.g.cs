#pragma checksum "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab30bcbf6edf3042cbb5538d48b6694510c53f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Pages_Projects), @"mvc.1.0.razor-page", @"/Pages/Projects.cshtml")]
namespace Test.Pages
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
#line 1 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/_ViewImports.cshtml"
using Test;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab30bcbf6edf3042cbb5538d48b6694510c53f74", @"/Pages/Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833c942784ed960da1eb5cc8806f83c6bcae2c85", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Projects : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<section>\n    <div class=\"container\">\n        <h1>Projects</h1>\n        <div class=\"flex\">\n");
#nullable restore
#line 10 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml"
             foreach (var project in Model.projects)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <article class=\"card\">\n                    <h2>");
#nullable restore
#line 13 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml"
                   Write(project.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <h3>");
#nullable restore
#line 14 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml"
                   Write(project.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n                    <h5>");
#nullable restore
#line 15 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml"
                   Write(project.authorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                    <p>");
#nullable restore
#line 16 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml"
                  Write(project.coAuthorIds);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                </article>\n");
#nullable restore
#line 18 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Projects.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Pages.ProjectsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.ProjectsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.ProjectsModel>)PageContext?.ViewData;
        public Test.Pages.ProjectsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591