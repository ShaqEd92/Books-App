#pragma checksum "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39566a7f123115d1fa9857c261e63db3ca313939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UpdateInfo), @"mvc.1.0.view", @"/Views/Home/UpdateInfo.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/UpdateInfo.cshtml", typeof(AspNetCore.Views_Home_UpdateInfo))]
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
#line 1 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
using Lybrary.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39566a7f123115d1fa9857c261e63db3ca313939", @"/Views/Home/UpdateInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50916be5f769633663de69a0b6fcb6e2698234ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UpdateInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Reader>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavbarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../../SaveUpdate/Name"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("required", new global::Microsoft.AspNetCore.Html.HtmlString("required"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../../SaveUpdate/Email"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("../../SaveUpdate/Password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
  
ViewData["Title"] = "Update Account";

#line default
#line hidden
            BeginContext(86, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39566a7f123115d1fa9857c261e63db3ca3139396880", async() => {
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
            BeginContext(118, 31, true);
            WriteLiteral("</partial>\r\n\r\n<!-- ALERTS -->\r\n");
            EndContext();
#line 11 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
 if(ViewBag.UpdateError != null)
{

#line default
#line hidden
            BeginContext(186, 214, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 35%; text-align: center\">    \r\n        <div class=\"alert\" >\r\n            <span class=\"closebtn\" onclick=\"this.parentElement.style.display=\'none\';\">&times;</span>\r\n            ");
            EndContext();
            BeginContext(401, 19, false);
#line 16 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
       Write(ViewBag.UpdateError);

#line default
#line hidden
            EndContext();
            BeginContext(420, 30, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 19 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
}

#line default
#line hidden
            BeginContext(453, 98, true);
            WriteLiteral("\r\n<div style=\"color: #fff; font-family: \'Roboto\', sans-serif;\">\r\n    <div class=\"signup-form\">\r\n\r\n");
            EndContext();
#line 24 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
         if(ViewBag.info == "Name")
        {

#line default
#line hidden
            BeginContext(599, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(611, 956, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39566a7f123115d1fa9857c261e63db3ca3139399681", async() => {
                BeginContext(662, 61, true);
                WriteLiteral("\r\n                <h3 style=\"text-align: center\">Update Your ");
                EndContext();
                BeginContext(724, 12, false);
#line 27 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
                                                      Write(ViewBag.info);

#line default
#line hidden
                EndContext();
                BeginContext(736, 242, true);
                WriteLiteral("</h3>\r\n                <hr>\r\n                <div class=\"form-group\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-xs-6\">\r\n                            <input type=\"text\" class=\"form-control\" name=\"Firstname\"");
                EndContext();
                BeginWriteAttribute("placeholder", "\r\n                                placeholder=\"", 978, "\"", 1059, 1);
#line 33 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
WriteAttributeValue("", 1025, ViewBag.ReaderInSession.FirstName, 1025, 34, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1060, 160, true);
                WriteLiteral(" required=\"required\"></div>\r\n                        <div class=\"col-xs-6\">\r\n                            <input type=\"text\" class=\"form-control\" name=\"Lastname\"");
                EndContext();
                BeginWriteAttribute("placeholder", "\r\n                                placeholder=\"", 1220, "\"", 1300, 1);
#line 36 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
WriteAttributeValue("", 1267, ViewBag.ReaderInSession.LastName, 1267, 33, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1301, 259, true);
                WriteLiteral(@" required=""required""></div>
                    </div>
                </div>
                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-success btn-lg btn-block"">Update</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1567, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 43 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(1580, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 45 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
         if(ViewBag.info == "Email")
        {

#line default
#line hidden
            BeginContext(1631, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(1643, 588, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39566a7f123115d1fa9857c261e63db3ca31393914105", async() => {
                BeginContext(1695, 61, true);
                WriteLiteral("\r\n                <h3 style=\"text-align: center\">Update Your ");
                EndContext();
                BeginContext(1757, 12, false);
#line 48 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
                                                      Write(ViewBag.info);

#line default
#line hidden
                EndContext();
                BeginContext(1769, 91, true);
                WriteLiteral("</h3>\r\n                <hr>\r\n                <div class=\"form-group\">\r\n                    ");
                EndContext();
                BeginContext(1860, 160, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "39566a7f123115d1fa9857c261e63db3ca31393915050", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 51 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Email);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "placeholder", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 52 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
AddHtmlAttributeValue("", 1968, ViewBag.ReaderInSession.Email, 1968, 30, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2020, 204, true);
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <button type=\"submit\" class=\"btn btn-success btn-lg btn-block\">Update</button>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2231, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 58 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(2244, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 60 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
         if(ViewBag.info == "Password")
        {

#line default
#line hidden
            BeginContext(2298, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2310, 1043, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39566a7f123115d1fa9857c261e63db3ca31393919832", async() => {
                BeginContext(2365, 61, true);
                WriteLiteral("\r\n                <h3 style=\"text-align: center\">Update Your ");
                EndContext();
                BeginContext(2427, 12, false);
#line 63 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
                                                      Write(ViewBag.info);

#line default
#line hidden
                EndContext();
                BeginContext(2439, 907, true);
                WriteLiteral(@"</h3>
                <hr>
                <div class=""form-group"">
                    <input type=""password"" class=""form-control"" name=""CurrentPassword"" placeholder=""Current Password""
                        required=""required"">
                </div>
                <br>
                <div class=""form-group"">
                    <input type=""password"" class=""form-control"" name=""Password"" placeholder=""Password""
                        required=""required"">
                </div>
                <div class=""form-group"">
                    <input type=""password"" class=""form-control"" name=""ConfirmPassword""
                        placeholder=""Confirm Password"" required=""required"">
                </div>
                <div class=""form-group"">
                    <button type=""submit"" class=""btn btn-success btn-lg btn-block"">Update</button>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3353, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 82 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\UpdateInfo.cshtml"
        }

#line default
#line hidden
            BeginContext(3366, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Reader> Html { get; private set; }
    }
}
#pragma warning restore 1591
