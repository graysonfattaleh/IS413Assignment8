#pragma checksum "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83c621242b2c783ce4eb6765ca55df5b4f76fa38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/_ViewImports.cshtml"
using IS413Assignment5Real;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/_ViewImports.cshtml"
using IS413Assignment5Real.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/_ViewImports.cshtml"
using IS413Assignment5Real.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/_ViewImports.cshtml"
using IS413Assignment5Real.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83c621242b2c783ce4eb6765ca55df5b4f76fa38", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4512218e13b5f689f1ad49aef4952ed890ff7295", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IS413Assignment5Real.Models.ViewModels.BookListViewModel>
    {
        private global::AspNetCore.Views_Home_Index.__Generated__NavigationMenuViewComponentTagHelper __NavigationMenuViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "BookLists", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<!-- NEW BOOT STRAP COMMANDS I USED-->
<!--1. Table and table-dark provoide styking to my table-->
<!--2. list-group and list-group-item classes provide styling for my list-->
<!--3. I used the col and row spacing to space out my page agian-->
<h1 class=""text-center"" style=""font-family:Arial, Helvetica, sans-serif;"">Hover over your favorite books to see the details!</h1>
<div class=""container"" style=""margin-top:15px;transform .git -r"">
    <div class=""row justify-content-between"">
        <div class=""col-2 "" >  <div style=""width: 100%;"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:navigation-menu", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c621242b2c783ce4eb6765ca55df5b4f76fa385510", async() => {
            }
            );
            __NavigationMenuViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Home_Index.__Generated__NavigationMenuViewComponentTagHelper>();
            __tagHelperExecutionContext.Add(__NavigationMenuViewComponentTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div></div>\r\n            <div class=\"col-5 minnyguy\">\r\n\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83c621242b2c783ce4eb6765ca55df5b4f76fa386582", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n            </div>\r\n            <div class=\"col-4 \" style=\"margin-left:10px;\">\r\n");
#nullable restore
#line 19 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                 foreach (Book book in Model.Books)
                {
                    string book_id = "details" + book.BookId.ToString();


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("id", " id=", 1062, "", 1074, 1);
#nullable restore
#line 23 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
WriteAttributeValue("", 1066, book_id, 1066, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"display:none\">\r\n\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item list-group-item-info\">Book ID: ");
#nullable restore
#line 26 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                                 Write(book.BookId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item list-group-item-info\">Author Full Name: ");
#nullable restore
#line 27 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                                          Write(book.AuthorFirst);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                                                            Write(book.AuthorMiddle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                                                                               Write(book.AuthorLast);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n            <li class=\"list-group-item list-group-item-info\">Classification: ");
#nullable restore
#line 28 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                                        Write(book.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item list-group-item-info\">Category: ");
#nullable restore
#line 29 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                                  Write(book.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item list-group-item-info\">ISBN: ");
#nullable restore
#line 30 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                              Write(book.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item list-group-item-info\">Pages: ");
#nullable restore
#line 31 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
                                                               Write(book.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>");
#nullable restore
#line 33 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
          }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <br />\r\n\r\n    </div>\r\n<input type=\"hidden\" id=\"current_page\"");
            BeginWriteAttribute("value", " value=\"", 1862, "\"", 1899, 1);
#nullable restore
#line 40 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
WriteAttributeValue("", 1870, Model.PagingInfo.CurrentPage, 1870, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83c621242b2c783ce4eb6765ca55df5b4f76fa3812623", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 41 "/Users/graysonfattaleh/Desktop/Junior Core Comprehensive/IS 413/IS413Assignment5Real/IS413Assignment5Real/Views/Home/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IS413Assignment5Real.Models.ViewModels.BookListViewModel> Html { get; private set; }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:navigation-menu")]
        public class __Generated__NavigationMenuViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper __helper = null;
            public __Generated__NavigationMenuViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                __helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext __context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput __output)
            {
                (__helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var __helperContent = await __helper.InvokeAsync("NavigationMenu", new {  });
                __output.TagName = null;
                __output.Content.SetHtmlContent(__helperContent);
            }
        }
    }
}
#pragma warning restore 1591
