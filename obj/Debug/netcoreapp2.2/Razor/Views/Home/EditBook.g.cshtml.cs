#pragma checksum "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbce64ee49b0d479584b73fb0d82d0a9f3cf8da0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_EditBook), @"mvc.1.0.view", @"/Views/Home/EditBook.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/EditBook.cshtml", typeof(AspNetCore.Views_Home_EditBook))]
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
#line 1 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\_ViewImports.cshtml"
using Stacks;

#line default
#line hidden
#line 2 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\_ViewImports.cshtml"
using Stacks.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbce64ee49b0d479584b73fb0d82d0a9f3cf8da0", @"/Views/Home/EditBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b7668ce16c3a83c512201c486d606abb30e750", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_EditBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavbarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
  
ViewData["Title"] = "Edit Book";

#line default
#line hidden
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(43, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fbce64ee49b0d479584b73fb0d82d0a9f3cf8da04237", async() => {
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
            BeginContext(73, 220, true);
            WriteLiteral("</partial>\r\n\r\n<br>\r\n\r\n<div class=\"mx-auto\"\r\n    style=\"width: 35%; text-align: center; color: darkgray; font-family: Cambria, Cochin, Georgia, Times, \'Times New Roman\', serif\">\r\n    <h3>Edit Book</h3>\r\n</div>\r\n\r\n<br>\r\n\r\n");
            EndContext();
#line 16 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
 if((ViewBag.TheBook.AddedAt.AddHours(1) > ViewBag.Deadline) == false)
{

#line default
#line hidden
            BeginContext(368, 54, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 35%\">\r\n        ");
            EndContext();
            BeginContext(422, 1970, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbce64ee49b0d479584b73fb0d82d0a9f3cf8da06102", async() => {
                BeginContext(489, 189, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12\">\r\n                        <h6>Title: <span style=\"font-weight: normal\">");
                EndContext();
                BeginContext(679, 21, false);
#line 23 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
                                                                Write(ViewBag.TheBook.Title);

#line default
#line hidden
                EndContext();
                BeginContext(700, 112, true);
                WriteLiteral("</span></h6>                    \r\n                        <input type=\"hidden\" class=\"form-control\" name=\"Title\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 812, "\"", 871, 1);
#line 25 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 849, ViewBag.TheBook.Title, 849, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(872, 247, true);
                WriteLiteral(" required=\"required\">\r\n                    </div>\r\n                </div>\r\n                <br>\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12\">\r\n                        <h6>Author: <span style=\"font-weight: normal\">");
                EndContext();
                BeginContext(1120, 22, false);
#line 31 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
                                                                 Write(ViewBag.TheBook.Author);

#line default
#line hidden
                EndContext();
                BeginContext(1142, 93, true);
                WriteLiteral("</span></h6>\r\n                        <input type=\"hidden\" class=\"form-control\" name=\"Author\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 1235, "\"", 1295, 1);
#line 33 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 1272, ViewBag.TheBook.Author, 1272, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1296, 246, true);
                WriteLiteral(" required=\"required\">\r\n                    </div>\r\n                </div>\r\n                <br>\r\n                <div class=\"row\">\r\n                    <div class=\"col-xs-12\">\r\n                        <h6>Genre: <span style=\"font-weight: normal\">");
                EndContext();
                BeginContext(1543, 21, false);
#line 39 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
                                                                Write(ViewBag.TheBook.Genre);

#line default
#line hidden
                EndContext();
                BeginContext(1564, 92, true);
                WriteLiteral("</span></h6>\r\n                        <input type=\"hidden\" class=\"form-control\" name=\"Genre\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 1656, "\"", 1715, 1);
#line 41 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 1693, ViewBag.TheBook.Genre, 1693, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1716, 309, true);
                WriteLiteral(@" required=""required"">
                    </div>
                </div>
                <br>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <h6>Description:</h6>
                        <textarea type=""text"" class=""form-control"" name=""Description""");
                EndContext();
                BeginWriteAttribute("placeholder", "\r\n                            placeholder=\"", 2025, "\"", 2096, 1);
#line 49 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 2068, ViewBag.TheBook.Description, 2068, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2097, 288, true);
                WriteLiteral(@" required=""required""></textarea>
                    </div>
                </div>
                <br>
            </div>
            <div class=""form-group"">
                <button type=""submit"" class=""btn btn-success btn-lg btn-block"">Edit</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 436, "../UpdateBook/", 436, 14, true);
#line 19 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
AddHtmlAttributeValue("", 450, ViewBag.TheBook.BookID, 450, 23, false);

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
            BeginContext(2392, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 59 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
}

else
{

#line default
#line hidden
            BeginContext(2420, 54, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 35%\">\r\n        ");
            EndContext();
            BeginContext(2474, 1779, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbce64ee49b0d479584b73fb0d82d0a9f3cf8da013377", async() => {
                BeginContext(2541, 262, true);
                WriteLiteral(@"
            <div class=""form-group"">
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <label>Title:</label>                   
                        <input type=""text"" class=""form-control"" name=""Title""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 2803, "\"", 2862, 1);
#line 70 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 2840, ViewBag.TheBook.Title, 2840, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2863, 304, true);
                WriteLiteral(@" required=""required"">
                    </div>
                </div>
                <br>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <label>Author:</label>  
                        <input type=""text"" class=""form-control"" name=""Author""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 3167, "\"", 3227, 1);
#line 78 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 3204, ViewBag.TheBook.Author, 3204, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3228, 302, true);
                WriteLiteral(@" required=""required"">
                    </div>
                </div>
                <br>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <label>Genre:</label>  
                        <input type=""text"" class=""form-control"" name=""Genre""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 3530, "\"", 3589, 1);
#line 86 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 3567, ViewBag.TheBook.Genre, 3567, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3590, 313, true);
                WriteLiteral(@" required=""required"">
                    </div>
                </div>
                <br>
                <div class=""row"">
                    <div class=""col-xs-12"">
                        <label>Description:</label> 
                        <input type=""text"" class=""form-control"" name=""Description""");
                EndContext();
                BeginWriteAttribute("value", "\r\n                            value=\"", 3903, "\"", 3968, 1);
#line 94 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
WriteAttributeValue("", 3940, ViewBag.TheBook.Description, 3940, 28, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3969, 277, true);
                WriteLiteral(@" required=""required"">
                    </div>
                </div>
                <br>
            </div>
            <div class=""form-group"">
                <button type=""submit"" class=""btn btn-success btn-lg btn-block"">Edit</button>
            </div>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2488, "../UpdateBook/", 2488, 14, true);
#line 64 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
AddHtmlAttributeValue("", 2502, ViewBag.TheBook.BookID, 2502, 23, false);

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
            BeginContext(4253, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 104 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Stacks\Views\Home\EditBook.cshtml"
}

#line default
#line hidden
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
