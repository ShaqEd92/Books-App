#pragma checksum "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e74004950aa8bc81df17ebf7e794319b47c8bed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_YourBooks), @"mvc.1.0.view", @"/Views/Home/YourBooks.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/YourBooks.cshtml", typeof(AspNetCore.Views_Home_YourBooks))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e74004950aa8bc81df17ebf7e794319b47c8bed3", @"/Views/Home/YourBooks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50916be5f769633663de69a0b6fcb6e2698234ca", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_YourBooks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "NavbarPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
  
ViewData["Title"] = "Your Books";

#line default
#line hidden
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(44, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e74004950aa8bc81df17ebf7e794319b47c8bed34607", async() => {
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
            BeginContext(74, 16, true);
            WriteLiteral("</partial>\r\n\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "Added" && ViewBag.BooksAdded.Count == 0)
{

#line default
#line hidden
            BeginContext(156, 222, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 70%; text-align: center\">\r\n        <br>\r\n        <h3>Books You Added</h3>\r\n        <hr>    \r\n        <h5 style=\"font-style: italic\">You haven\'t added any books yet.</h5>\r\n    </div>\r\n");
            EndContext();
#line 16 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(381, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "Added" && ViewBag.BooksAdded.Count > 0)
{

#line default
#line hidden
            BeginContext(450, 468, true);
            WriteLiteral(@"    <div class=""mx-auto"" style=""width: 70%; text-align: center"">
        <br>
        <h3>Books You Added</h3>
        <hr>    
        <table class=""table table-hover table-dark"">
            <thead>
                <tr>
                    <th scope=""col"">Book title</th>
                    <th scope=""col"">Number of reads</th>
                    <th scope=""col"">Number of favorites</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 34 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                 foreach(var book in ViewBag.BooksAdded)
                {
                    int readSum = 0; 
                    int faveSum = 0; 
                    

#line default
#line hidden
#line 38 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                     foreach(var x in ViewBag.AllReads)
                    {
                        if(x.BookID == @book.BookID)
                        {
                            readSum+=1;
                        }
                    }

#line default
#line hidden
#line 45 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                     foreach(var y in ViewBag.AllFavorites)
                    {
                        if(y.BookID == @book.BookID)
                        {
                            faveSum+=1;
                        }
                    }

#line default
#line hidden
            BeginContext(1585, 89, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\"><a style=\"color: white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1674, "\"", 1708, 2);
            WriteAttributeValue("", 1681, "../DisplayBook/", 1681, 15, true);
#line 53 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 1696, book.BookID, 1696, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1709, 22, true);
            WriteLiteral(" style=\"color: black\">");
            EndContext();
            BeginContext(1732, 10, false);
#line 53 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                                                                                                                   Write(book.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1742, 39, true);
            WriteLiteral("</a></th>\r\n                        <td>");
            EndContext();
            BeginContext(1782, 7, false);
#line 54 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                       Write(readSum);

#line default
#line hidden
            EndContext();
            BeginContext(1789, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1825, 7, false);
#line 55 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                       Write(faveSum);

#line default
#line hidden
            EndContext();
            BeginContext(1832, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                }

#line default
#line hidden
            BeginContext(1885, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 61 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(1940, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 64 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "ReadList" && ViewBag.ReaderInSession.ReadingList == null)
{

#line default
#line hidden
            BeginContext(2027, 248, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 70%; text-align: center\">\r\n        <br>\r\n        <h3>Books on Your Reading List</h3>\r\n        <hr>\r\n        <h5 style=\"font-style: italic\">You currently have no books on your \'To Read List\'.</h5>\r\n    </div>\r\n");
            EndContext();
#line 72 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(2278, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 75 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "ReadList" && ViewBag.ReaderInSession.ReadingList != null)
{

#line default
#line hidden
            BeginContext(2365, 479, true);
            WriteLiteral(@"    <div class=""mx-auto"" style=""width: 70%; text-align: center"">
        <br>
        <h3>Books on Your Reading List</h3>
        <hr>
        <table class=""table table-hover table-dark"">
            <thead>
                <tr>
                    <th scope=""col"">Book title</th>
                    <th scope=""col"">Mark as read</th>
                    <th scope=""col"">Remove from 'To Read List'</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 90 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                 foreach(var book in ViewBag.ReaderInSession.ReadingList)
                {

#line default
#line hidden
            BeginContext(2938, 85, true);
            WriteLiteral("                <tr>\r\n                        <th scope=\"row\"><a style=\"color: white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3023, "\"", 3057, 2);
            WriteAttributeValue("", 3030, "../DisplayBook/", 3030, 15, true);
#line 93 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 3045, book.BookID, 3045, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3058, 22, true);
            WriteLiteral(" style=\"color: black\">");
            EndContext();
            BeginContext(3081, 18, false);
#line 93 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                                                                                                                   Write(book.TheBook.Title);

#line default
#line hidden
            EndContext();
            BeginContext(3099, 81, true);
            WriteLiteral("</a></th>\r\n                    <td>                    \r\n                        ");
            EndContext();
            BeginContext(3180, 308, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74004950aa8bc81df17ebf7e794319b47c8bed314078", async() => {
                BeginContext(3274, 50, true);
                WriteLiteral("\r\n                            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 3324, "\"", 3351, 1);
#line 96 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 3331, book.TheBook.BookID, 3331, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3352, 129, true);
                WriteLiteral(">\r\n                            <button style=\"border: none; background: transparent\">&#x1F4D7;</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3194, "../DidRead/", 3194, 11, true);
#line 95 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
AddHtmlAttributeValue("", 3205, book.TheBook.BookID, 3205, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 3225, "/YourList", 3225, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3488, 108, true);
            WriteLiteral("         \r\n                    </td>\r\n                    <td>                    \r\n                        ");
            EndContext();
            BeginContext(3596, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74004950aa8bc81df17ebf7e794319b47c8bed317130", async() => {
                BeginContext(3682, 50, true);
                WriteLiteral("\r\n                            <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 3732, "\"", 3759, 1);
#line 102 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 3739, book.TheBook.BookID, 3739, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3760, 128, true);
                WriteLiteral(">\r\n                            <button style=\"border: none; background: transparent\">&#10060;</button>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3610, "../WontRead/", 3610, 12, true);
#line 101 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
AddHtmlAttributeValue("", 3622, book.TheBook.BookID, 3622, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3895, 61, true);
            WriteLiteral("         \r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 107 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                }

#line default
#line hidden
            BeginContext(3975, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 111 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(4030, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 114 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "ReadAlready" && ViewBag.ReaderInSession.BooksRead == null)
{

#line default
#line hidden
            BeginContext(4118, 231, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 70%; text-align: center\">\r\n        <br>\r\n        <h3>Books You\'ve Read</h3>\r\n        <hr>\r\n        <h5 style=\"font-style: italic\">You haven\'t finished reading any books yet.</h5>\r\n    </div>\r\n");
            EndContext();
#line 122 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(4352, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 125 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "ReadAlready" && ViewBag.ReaderInSession.BooksRead != null)
{

#line default
#line hidden
            BeginContext(4440, 468, true);
            WriteLiteral(@"    <div class=""mx-auto"" style=""width: 70%; text-align: center"">
        <br>
        <h3>Books You've Read</h3>
        <hr>
        <table class=""table table-hover table-dark"">
            <thead>
                <tr>
                    <th scope=""col"">Book title</th>
                    <th scope=""col"">Mark as unread</th>
                    <th scope=""col"">Add/Remove as favorite</th>
                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 140 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                 foreach(var book in ViewBag.ReaderInSession.BooksRead)
                {
                    bool faved = false;

                    

#line default
#line hidden
#line 144 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                     if(@ViewBag.ReaderInSession.MyFaves != null)
                    {
                        

#line default
#line hidden
#line 146 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                         foreach(var liked in @ViewBag.ReaderInSession.MyFaves)
                        {
                            if(@liked.BookID == @book.BookID)
                            {
                                faved = true;
                            }
                        }

#line default
#line hidden
#line 152 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                           
                    }

#line default
#line hidden
            BeginContext(5467, 89, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\"><a style=\"color: white\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5556, "\"", 5598, 2);
            WriteAttributeValue("", 5563, "../DisplayBook/", 5563, 15, true);
#line 156 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 5578, book.TheBook.BookID, 5578, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5599, 22, true);
            WriteLiteral(" style=\"color: black\">");
            EndContext();
            BeginContext(5622, 18, false);
#line 156 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                                                                                                                           Write(book.TheBook.Title);

#line default
#line hidden
            EndContext();
            BeginContext(5640, 69, true);
            WriteLiteral("</a></th>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(5709, 314, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74004950aa8bc81df17ebf7e794319b47c8bed324614", async() => {
                BeginContext(5797, 54, true);
                WriteLiteral("\r\n                                <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 5851, "\"", 5878, 1);
#line 159 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 5858, book.TheBook.BookID, 5858, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5879, 137, true);
                WriteLiteral(">\r\n                                <button style=\"border: none; background: transparent\">&#128213;</button>\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5723, "../DidNotRead/", 5723, 14, true);
#line 158 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
AddHtmlAttributeValue("", 5737, book.TheBook.BookID, 5737, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6023, 63, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n");
            EndContext();
#line 164 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                             if(faved == false)
                            {

#line default
#line hidden
            BeginContext(6166, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(6198, 359, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74004950aa8bc81df17ebf7e794319b47c8bed327907", async() => {
                BeginContext(6295, 58, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 6353, "\"", 6380, 1);
#line 167 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 6360, book.TheBook.BookID, 6360, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6381, 169, true);
                WriteLiteral(">\r\n                                    <button style=\"border: none; background: transparent\" title=\"Add as favorite\">&#128154;</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6212, "../AddToFaves/", 6212, 14, true);
#line 166 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
AddHtmlAttributeValue("", 6226, book.TheBook.BookID, 6226, 20, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 6246, "/YourList", 6246, 9, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6557, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 170 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(6655, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(6687, 358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e74004950aa8bc81df17ebf7e794319b47c8bed331262", async() => {
                BeginContext(6780, 58, true);
                WriteLiteral("\r\n                                    <input type=\"hidden\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 6838, "\"", 6865, 1);
#line 174 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 6845, book.TheBook.BookID, 6845, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(6866, 172, true);
                WriteLiteral(">\r\n                                    <button style=\"border: none; background: transparent\" title=\"Remove as favorite\">&#128148;</button>\r\n                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6701, "../RemoveFromFaves/", 6701, 19, true);
#line 173 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
AddHtmlAttributeValue("", 6720, book.TheBook.BookID, 6720, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7045, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 177 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                            }

#line default
#line hidden
            BeginContext(7078, 58, true);
            WriteLiteral("                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 180 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                }

#line default
#line hidden
            BeginContext(7155, 52, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            EndContext();
#line 184 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(7210, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 187 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "Favorites" && ViewBag.ReaderInSession.MyFaves == null)
{

#line default
#line hidden
            BeginContext(7294, 224, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 70%; text-align: center\">\r\n        <br>\r\n        <h3>Your Favorites</h3>\r\n        <hr>\r\n        <h5 style=\"font-style: italic\">You don\'t currently have any favorites.</h5>\r\n    </div>\r\n");
            EndContext();
#line 195 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
}

#line default
#line hidden
            BeginContext(7521, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 198 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
 if(ViewBag.List == "Favorites" && ViewBag.ReaderInSession.MyFaves != null)
{

#line default
#line hidden
            BeginContext(7605, 166, true);
            WriteLiteral("    <div class=\"mx-auto\" style=\"width: 50%; text-align: center\">\r\n        <br>\r\n        <h3>Your Favorites</h3>\r\n        <hr>\r\n        <ul style=\"list-style: none\">\r\n");
            EndContext();
#line 205 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
             foreach(var book in ViewBag.ReaderInSession.MyFaves)
            {

#line default
#line hidden
            BeginContext(7853, 36, true);
            WriteLiteral("            <li>\r\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 7889, "\"", 7923, 2);
            WriteAttributeValue("", 7896, "../DisplayBook/", 7896, 15, true);
#line 208 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
WriteAttributeValue("", 7911, book.BookID, 7911, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(7924, 22, true);
            WriteLiteral(" style=\"color: black\">");
            EndContext();
            BeginContext(7947, 18, false);
#line 208 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
                                                                      Write(book.TheBook.Title);

#line default
#line hidden
            EndContext();
            BeginContext(7965, 25, true);
            WriteLiteral("</a>\r\n            </li>\r\n");
            EndContext();
#line 210 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
            }

#line default
#line hidden
            BeginContext(8005, 27, true);
            WriteLiteral("        </ul>\r\n    </div>\r\n");
            EndContext();
#line 213 "C:\Users\Shaquille Hakili\Documents\Projects\Books\Lybrary\Views\Home\YourBooks.cshtml"
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
