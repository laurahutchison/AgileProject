#pragma checksum "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/FormEditor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08ed9f83ba421f2b28200dab2f18b79c5875dd08"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Pages_FormEditor), @"mvc.1.0.razor-page", @"/Pages/FormEditor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08ed9f83ba421f2b28200dab2f18b79c5875dd08", @"/Pages/FormEditor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833c942784ed960da1eb5cc8806f83c6bcae2c85", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FormEditor : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section>\n    <div class=\"container\">\n        <h1>");
#nullable restore
#line 8 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/FormEditor.cshtml"
       Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Pages.FormEditorModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.FormEditorModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.FormEditorModel>)PageContext?.ViewData;
        public Test.Pages.FormEditorModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591