#pragma checksum "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e53b07ad3d69bc64576a838a1c6683a14f04ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_DisplayBook), @"mvc.1.0.view", @"/Views/Home/DisplayBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/DisplayBook.cshtml", typeof(AspNetCore.Views_Home_DisplayBook))]
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
#line 1 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\_ViewImports.cshtml"
using Lybrary;

#line default
#line hidden
#line 2 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\_ViewImports.cshtml"
using Lybrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e53b07ad3d69bc64576a838a1c6683a14f04ac", @"/Views/Home/DisplayBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50916be5f769633663de69a0b6fcb6e2698234ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_DisplayBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Lybrary.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavbarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
  
ViewData["Title"] = @Model.Title;

#line default
#line hidden
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30e53b07ad3d69bc64576a838a1c6683a14f04ac5243", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(104, 103, true);
            WriteLiteral("</partial>\r\n\r\n<div class=\"mx-auto\" id=\"displayDashboard\">\r\n\r\n    <div style=\"width: 40%\">\r\n        <h2>");
            EndContext();
            BeginContext(208, 11, false);
#line 12 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(219, 49, true);
            WriteLiteral("</h2>\r\n        <h6 style=\"font-style: italic\">By ");
            EndContext();
            BeginContext(269, 12, false);
#line 13 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                     Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(281, 59, true);
            WriteLiteral("</h6>\r\n        <hr>\r\n        <p style=\"font-style: italic\">");
            EndContext();
            BeginContext(341, 17, false);
#line 15 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                 Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(358, 166, true);
            WriteLiteral("</p>\r\n    </div>\r\n\r\n    <div style=\"width: 50%\">\r\n        <h4 style=\"font-family: serif; font-style: italic\">Thoughts?</h4>\r\n        <div id=\"notebook\">\r\n            ");
            EndContext();
            BeginContext(524, 278, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30e53b07ad3d69bc64576a838a1c6683a14f04ac7972", async() => {
                BeginContext(584, 211, true);
                WriteLiteral("\r\n                <textarea style=\"width: 100%; font-size: 0.75em\" name=\"Content\" required rows=\"3\"></textarea>\r\n                <button type=\"submit\" class=\"btn btn-success btn-sm\" >Share</button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 538, "../../AddComment/", 538, 17, true);
#line 21 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
AddHtmlAttributeValue("", 555, Model.BookID, 555, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(802, 20, true);
            WriteLiteral("\r\n            <hr>\r\n");
            EndContext();
#line 26 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
             if(@Model.BookComments.Count > 0)
            {
                

#line default
#line hidden
#line 28 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                 foreach(var c in @Model.BookComments)
                {

#line default
#line hidden
            BeginContext(960, 80, true);
            WriteLiteral("                    <p><span style=\"font-weight: bold; font-family: sans-serif\">");
            EndContext();
            BeginContext(1041, 21, false);
#line 30 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                                                           Write(c.TheReader.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 9, true);
            WriteLiteral(": </span>");
            EndContext();
            BeginContext(1072, 9, false);
#line 30 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                                                                                          Write(c.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1081, 55, true);
            WriteLiteral("</p>\r\n                    <p style=\"font-size: 0.75em\">");
            EndContext();
            BeginContext(1137, 44, false);
#line 31 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                            Write(c.CommentedAt.ToString("MM/dd/yyyy h:mm tt"));

#line default
#line hidden
            EndContext();
            BeginContext(1181, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 32 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                     if(@c.ReaderID == ViewBag.ReaderInSession.ReaderID)
                    { 

#line default
#line hidden
            BeginContext(1281, 81, true);
            WriteLiteral("                        <button id=\"modalIcon\" data-toggle=\"modal\" data-target=\"#");
            EndContext();
            BeginContext(1363, 13, false);
#line 34 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                                                            Write(c.CommentCode);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 45, true);
            WriteLiteral("\" title=\"Edit\">\r\n                            ");
            EndContext();
            BeginContext(1421, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "30e53b07ad3d69bc64576a838a1c6683a14f04ac13159", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1444, 39, true);
            WriteLiteral("\r\n\r\n                        </button>\r\n");
            EndContext();
#line 38 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                    }

#line default
#line hidden
            BeginContext(1506, 52, true);
            WriteLiteral("                    </p>\r\n                    <br>\r\n");
            EndContext();
#line 41 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                }

#line default
#line hidden
#line 41 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                 
            }
            else
            {

#line default
#line hidden
            BeginContext(1625, 51, true);
            WriteLiteral("                <p>There are no comments yet.</p>\r\n");
            EndContext();
#line 46 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
            }

#line default
#line hidden
            BeginContext(1691, 69, true);
            WriteLiteral("        </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n<!-- Edit Comment Modal -->\r\n");
            EndContext();
#line 53 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
 foreach(var c in @Model.BookComments)
{

#line default
#line hidden
            BeginContext(1803, 27, true);
            WriteLiteral("    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1830, "\"", 1837, 1);
#line 55 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
WriteAttributeValue("", 1835, c, 1835, 2, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1838, 584, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Test</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>");
            EndContext();
            BeginContext(2423, 9, false);
#line 65 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                  Write(c.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2432, 29, true);
            WriteLiteral("</p>\r\n                    <p>");
            EndContext();
            BeginContext(2462, 13, false);
#line 66 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                  Write(c.CommentedAt);

#line default
#line hidden
            EndContext();
            BeginContext(2475, 293, true);
            WriteLiteral(@"</p>
                    <p>Content</p>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
    
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
#line 76 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
}

#line default
#line hidden
            BeginContext(2771, 46, true);
            WriteLiteral("\r\n<!-- Delete Comment Confirmation Modal -->\r\n");
            EndContext();
#line 79 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
 foreach(var c in @Model.BookComments)
{

#line default
#line hidden
            BeginContext(2860, 27, true);
            WriteLiteral("    <div class=\"modal fade\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2887, "\"", 2906, 1);
#line 81 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
WriteAttributeValue("", 2892, c.CommentCode, 2892, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2907, 332, true);
            WriteLiteral(@" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel""
        aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Are you sure you want to delete '");
            EndContext();
            BeginContext(3240, 1, false);
#line 86 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
                                                                                               Write(c);

#line default
#line hidden
            EndContext();
            BeginContext(3241, 396, true);
            WriteLiteral(@"'?</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    ");
            EndContext();
            BeginContext(3637, 251, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30e53b07ad3d69bc64576a838a1c6683a14f04ac20022", async() => {
                BeginContext(3710, 46, true);
                WriteLiteral("\r\n                        <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 3756, "\"", 3765, 1);
#line 94 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
WriteAttributeValue("", 3763, c, 3763, 2, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3766, 115, true);
                WriteLiteral(">\r\n                        <button class=\"btn btn-danger\" title=\"Delete Book\">Delete</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3651, "Delete/", 3651, 7, true);
#line 93 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
AddHtmlAttributeValue("", 3658, c, 3658, 2, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3660, "/Dashboard", 3660, 10, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3888, 74, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 101 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\DisplayBook.cshtml"
}

#line default
#line hidden
            BeginContext(3965, 279, true);
            WriteLiteral(@"
<script src=""http://code.jquery.com/jquery-2.2.0.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js""
    integrity=""sha384-0mSbJDEHialfmuBBQP6A4Qrprq5OVfW37PRR3j5ELqxss1yVqOtnepnHVP9aJ7xS""
    crossorigin=""anonymous""></script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Lybrary.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
