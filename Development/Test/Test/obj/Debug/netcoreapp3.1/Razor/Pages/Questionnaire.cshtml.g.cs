#pragma checksum "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7db25c4942cb20ecc69aeb1e510c2a09f7ae86d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Test.Pages.Pages_Questionnaire), @"mvc.1.0.razor-page", @"/Pages/Questionnaire.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7db25c4942cb20ecc69aeb1e510c2a09f7ae86d", @"/Pages/Questionnaire.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"833c942784ed960da1eb5cc8806f83c6bcae2c85", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Questionnaire : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-user"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Project", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-fragment", "qContent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-subpage", "responses", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline-block;flex: 0 0 57px;margin:21px 21px 21px 0;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-subpage", "questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
  
    int sectionCount = 0;
    int questionCount = 0;

    var random = new Random();
    List<string> primaryColours = new List<string> { "#4365e2ec", "#ff6264ec", "#01d17cec" };
    List<string> secondaryColours = new List<string> { "#f4cec3ec", "#ffecd2ec", "#d1e2f2ec", "#c4ebd0ec" };

    string degree = random.Next(0, 360).ToString() + "deg";
    string colour1 = primaryColours[random.Next(primaryColours.Count)];
    string colour2 = secondaryColours[random.Next(secondaryColours.Count)];

    string image = Model.questionnaire.image;
    string background = "background-image: linear-gradient(" + degree + ", " + colour1 + ", " + colour2 + "), url('" + image + "');";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<section>\n    <div class=\"container\" style=\"padding: 0 73px\">\n        <h1 style=\"margin-left: 7px\">");
#nullable restore
#line 21 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                Write(Model.questionnaire.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n        <div class=\"flex\" height=\"224px\">\n");
            WriteLiteral("            <div class=\"img\" height=\"210px\" width=\"210px\"");
            BeginWriteAttribute("style", " style=\"", 1033, "\"", 1052, 1);
#nullable restore
#line 24 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
WriteAttributeValue("", 1041, background, 1041, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <div width=\"210px\" height=\"210px\"></div>\n            </div>\n            <p class=\"description\" height=\"210px\" width=\"210px\">");
#nullable restore
#line 27 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                                           Write(Model.questionnaire.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n        \n    </div>\n</section>\n<section>\n    <div class=\"container\" style=\"padding: 0 73px\">\n        <h1 style=\"margin-left: 7px\">Researchers</h1>\n        <div class=\"flex\">\n");
#nullable restore
#line 36 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
             foreach (var user in Model.users)
            {
                degree = random.Next(0, 360).ToString() + "deg";
                colour1 = primaryColours[random.Next(primaryColours.Count)];
                colour2 = secondaryColours[random.Next(secondaryColours.Count)];

                image = user.image;
                background = "background-image: linear-gradient(" + degree + ", " + colour1 + ", " + colour2 + "), url('" + image + "');";

                string name = Model._userService.GetNameByID(user.id);


#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7db25c4942cb20ecc69aeb1e510c2a09f7ae86d8998", async() => {
                WriteLiteral("\n                    <article");
                BeginWriteAttribute("class", " class=\"", 2096, "\"", 2104, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                        <h2 class=\"title\">");
#nullable restore
#line 49 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                     Write(name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n                    </article>\n                ");
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
#line 47 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                                                       WriteLiteral(user.id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 47 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
AddHtmlAttributeValue("", 2054, background, 2054, 11, false);

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
#line 52 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"card\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2258, "\"", 2268, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                <h1>+</h1>\n            </button>\n        </div>\n    </div>\n</section>\n<section>\n    <div class=\"container\" id=\"qContent\">\n        <h1>");
#nullable restore
#line 61 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
       Write(Model.subpage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n\n");
#nullable restore
#line 63 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
         if (Model.subpage == "questions")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"flex-left\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7db25c4942cb20ecc69aeb1e510c2a09f7ae86d13615", async() => {
                WriteLiteral("Responses");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Fragment = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                                                     WriteLiteral(Model.id);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subpage"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("            </div>\n");
#nullable restore
#line 70 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
             foreach (var part in Model.sections)
            {
                sectionCount++;
                Model.questions = Model._questionService.GetQuestionsBySection(part.id);


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"section\"");
            BeginWriteAttribute("id", " id=\"", 3207, "\"", 3220, 1);
#nullable restore
#line 75 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
WriteAttributeValue("", 3212, part.id, 3212, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                    <h2>");
#nullable restore
#line 76 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                   Write(sectionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" . ");
#nullable restore
#line 76 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                   Write(part.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n                    <p>");
#nullable restore
#line 77 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                  Write(part.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n\n");
#nullable restore
#line 80 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                     foreach (var question in Model.questions)
                    {
                        questionCount++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><strong>");
#nullable restore
#line 84 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                              Write(questionCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 84 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                              Write(question.question);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong><br /></p>\n                        <ul>\n");
#nullable restore
#line 86 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                             foreach (var option in question.answerOptions)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 88 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                               Write(option);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 89 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </ul>\n");
#nullable restore
#line 91 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\n");
#nullable restore
#line 93 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
             
        }
        else if (Model.subpage == "responses")
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"flex-left\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7db25c4942cb20ecc69aeb1e510c2a09f7ae86d21253", async() => {
                WriteLiteral("Questions");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Fragment = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
                                                                     WriteLiteral(Model.id);

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
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["subpage"] = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            WriteLiteral("            </div>\n");
#nullable restore
#line 101 "/Users/parsnips/Documents/Uni/Year 3/Agile/Assignment/Repo/Development/Test/Test/Pages/Questionnaire.cshtml"
        }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test.Pages.QuestionnaireModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.QuestionnaireModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Test.Pages.QuestionnaireModel>)PageContext?.ViewData;
        public Test.Pages.QuestionnaireModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
