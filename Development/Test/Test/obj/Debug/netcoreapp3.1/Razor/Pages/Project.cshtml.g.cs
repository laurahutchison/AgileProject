#pragma checksum "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de8f775261e93094c01be8c29f44fee682bc5977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Pages_Project), @"mvc.1.0.razor-page", @"/Pages/Project.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de8f775261e93094c01be8c29f44fee682bc5977", @"/Pages/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833c942784ed960da1eb5cc8806f83c6bcae2c85", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Project : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Questionnaire", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-subpage", "questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("addBtn1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
  
    string name = Model._userService.GetNameById(Model.project.authorId);
    string names = Model._userService.GetNamesFromList(Model.project.coAuthorIds);

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\n    <div class=\"container\" style=\"padding: 0 73px\">\n        <h1 style=\"margin-left: 7px\">");
#nullable restore
#line 9 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                                Write(Model.project.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <p style=\"margin-left: 7px\">");
#nullable restore
#line 10 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                               Write(Model.project.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <div class=\"flex\">\n");
#nullable restore
#line 12 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
             foreach (var questionnaire in Model.questionnaires)
            {
                var random = new Random();
                List<string> primaryColours = new List<string> { "#4365e2ec", "#ff6264ec", "#01d17cec" };
                List<string> secondaryColours = new List<string> { "#f4cec3ec", "#ffecd2ec", "#d1e2f2ec", "#c4ebd0ec" };

                string degree = random.Next(0, 360).ToString() + "deg";
                string colour1 = primaryColours[random.Next(primaryColours.Count)];
                string colour2 = secondaryColours[random.Next(secondaryColours.Count)];

                string image = questionnaire.image;
                string background = "background-image: linear-gradient(" + degree + ", " + colour1 + ", " + colour2 + "), url('" + image + "');";

                string name2 = Model._userService.GetNameById(questionnaire.authorId);
                string names2 = Model._userService.GetNamesFromList(questionnaire.coAuthorIds);

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8f775261e93094c01be8c29f44fee682bc59777281", async() => {
                WriteLiteral("\n                    <article");
                BeginWriteAttribute("class", " class=\"", 1577, "\"", 1585, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        <h2 class=\"title\">");
#nullable restore
#line 29 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                                     Write(questionnaire.title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n                        <p class=\"authors\">\n                            <strong>");
#nullable restore
#line 31 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                               Write(name2);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong><br />\n                            ");
#nullable restore
#line 32 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                       Write(names2);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </p>\n                    </article>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                                                                        WriteLiteral(questionnaire.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-subpage", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subpage"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 27 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
AddHtmlAttributeValue("", 1535, background, 1535, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 36 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de8f775261e93094c01be8c29f44fee682bc597712177", async() => {
                WriteLiteral("\n                <button id=\"newProject\" class=\"card\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2000, "\"", 2010, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                    <h1>+</h1>\n                </button>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </div>\n        <p style=\"margin-left: 7px\">\n            <strong>Principle Researcher</strong> ");
#nullable restore
#line 44 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                                             Write(name);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n            <strong>Co-Researchers</strong> ");
#nullable restore
#line 45 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Project.cshtml"
                                       Write(names);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Pages.ProjectModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.ProjectModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.ProjectModel>)PageContext?.ViewData;
        public Test.Pages.ProjectModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
