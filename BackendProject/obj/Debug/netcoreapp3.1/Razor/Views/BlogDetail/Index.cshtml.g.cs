#pragma checksum "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fad714145c0f6dfc0b79da150b6cbab487c7238b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BlogDetail_Index), @"mvc.1.0.view", @"/Views/BlogDetail/Index.cshtml")]
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
#line 1 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.ViewModels.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.ViewModels.TopHeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\_ViewImports.cshtml"
using BackendProject.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fad714145c0f6dfc0b79da150b6cbab487c7238b", @"/Views/BlogDetail/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d09cfb617f9e0a56c42dbb8b012b00ffd971a359", @"/Views/_ViewImports.cshtml")]
    public class Views_BlogDetail_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("author thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("widget-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("post thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("blog thumb"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/blog/comment-icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BlogDetail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Comment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
  
    ViewData["Title"] = "Blog Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <!-- breadcrumb area start -->
    <div class=""breadcrumb-area bg-img"" data-bg=""~/assets/img/banner/breadcrumb-banner.jpg"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <div class=""breadcrumb-wrap text-center"">
                        <nav aria-label=""breadcrumb"">
                            <h1 class=""breadcrumb-title"">Blog</h1>
                            <ul class=""breadcrumb"">
                                <li class=""breadcrumb-item""><a href=""index.html"">Home</a></li>
                                <li class=""breadcrumb-item""><a href=""blog-right-sidebar.html"">Blog</a></li>
                                <li class=""breadcrumb-item active"" aria-current=""page"">Blog Details</li>
                            </ul>
                        </nav>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- breadcrumb area end -->
    <!-- blog main wrapper star");
            WriteLiteral(@"t -->
    <div class=""blog-main-wrapper section-padding"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 order-2"">
                    <div class=""blog-widget-wrapper"">
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <div class=""blog-widget-img"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fad714145c0f6dfc0b79da150b6cbab487c7238b10191", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1523, "~/assets/img/blog/", 1523, 18, true);
#nullable restore
#line 36 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
AddHtmlAttributeValue("", 1541, Model.Widget.Image, 1541, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"blog-author-title text-center\">\r\n                                <h5>");
#nullable restore
#line 39 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                               Write(Model.Widget.Fullname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <span>");
#nullable restore
#line 40 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                 Write(Model.Widget.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                <div class=\"blog-widget-icon\">\r\n");
#nullable restore
#line 42 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                     foreach (var social in Model.Socials)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\"><i");
            BeginWriteAttribute("class", " class=\"", 2057, "\"", 2080, 2);
            WriteAttributeValue("", 2065, "fa", 2065, 2, true);
#nullable restore
#line 44 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
WriteAttributeValue(" ", 2067, social.Icon, 2068, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></a>\r\n");
#nullable restore
#line 45 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </div>
                            </div>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Search</h4>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad714145c0f6dfc0b79da150b6cbab487c7238b14090", async() => {
                WriteLiteral("\r\n                                <input placeholder=\"Search keyword\" type=\"text\" class=\"search-field\">\r\n                                <button type=\"submit\" class=\"search-btn\"><i class=\"fa fa-search\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Recent Posts</h4>
                            <ul class=""recent-posts-inner"">
");
#nullable restore
#line 63 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                 foreach (var blog in Model.RecentBlogs.OrderByDescending(m => m.Id))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\"recent-posts\">\r\n                                      \r\n                                        <div class=\"recent-posts-image\">\r\n                                            <a href=\"blog-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fad714145c0f6dfc0b79da150b6cbab487c7238b16605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3498, "~/assets/img/blog/", 3498, 18, true);
#nullable restore
#line 68 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
AddHtmlAttributeValue("", 3516, blog.Image, 3516, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a>\r\n                                        </div>\r\n                                        <div class=\"recent-posts-body\">\r\n                                            <span class=\"recent-posts-meta\">");
#nullable restore
#line 71 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                                       Write(blog.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            <h6 class=\"recent-posts-title\"><a href=\"blog-details.html\">");
#nullable restore
#line 72 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                                                                  Write(blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h6>\r\n                                        </div>\r\n                                    </li>\r\n");
#nullable restore
#line 75 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Categories</h4>
                            <ul class=""blog-categories"">
");
#nullable restore
#line 84 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                 foreach (var category in Model.Categories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li><a href=\"blog-details.html\">");
#nullable restore
#line 86 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                               Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a><span>(");
#nullable restore
#line 86 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                                                        Write(category.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span></li>\r\n");
#nullable restore
#line 87 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </ul>
                        </div>
                        <!-- widget item end -->
                        <!-- widget item start -->
                        <div class=""blog-widget"">
                            <h4 class=""blog-widget-title"">Tags</h4>
                            <div class=""blog-tag"">
");
#nullable restore
#line 96 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                 foreach (var tag in Model.Tags)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <a href=\"blog-details.html\">");
#nullable restore
#line 98 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                           Write(tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 99 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            </div>
                        </div>
                        <!-- widget item end -->
                    </div>
                </div>
                <div class=""col-lg-9 order-1"">
                    <div class=""row"">
                        <div class=""col-12"">
                            <!-- blog single item start -->
                           
                                <div class=""blog-post-item"">
                                    <div class=""blog-thumb"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fad714145c0f6dfc0b79da150b6cbab487c7238b23029", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5769, "~/assets/img/blog/", 5769, 18, true);
#nullable restore
#line 112 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
AddHtmlAttributeValue("", 5787, Model.Blog.Image, 5787, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"blog-content blog-details\">\r\n                                        <h5 class=\"blog-title\">\r\n                                            ");
#nullable restore
#line 116 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                       Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </h5>\r\n                                        <ul class=\"blog-meta\">\r\n                                            <li><span>By: </span>");
#nullable restore
#line 119 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                            Write(Model.Blog.By);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                            <li><span>On: </span>14.07.2029</li>\r\n                                        </ul>\r\n                                        <p>\r\n                                           ");
#nullable restore
#line 123 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                      Write(Model.Blog.ArticleHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <blockquote>\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 127 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                           Write(Model.Blog.ArticleQuote);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </p>\r\n                                        </blockquote>\r\n                                        <p>\r\n                                            ");
#nullable restore
#line 131 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                       Write(Model.Blog.ArticleContext);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </p>
                                    </div>
                                </div>
                            
                            <!-- blog single item start -->
                            <!-- comment area start -->
                            <div class=""comment-section section-padding"">
                                <h5>03 Comment</h5>
                                <ul>
");
#nullable restore
#line 141 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                     foreach (var item in Model.Comments.Where(m=>m.BlogId==Model.Blog.Id))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <li>\r\n                                            <div class=\"author-avatar\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "fad714145c0f6dfc0b79da150b6cbab487c7238b28131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                            <div class=""comment-body"">
                                                <span class=""reply-btn""><a href=""#"">Reply</a></span>
                                                <h5 class=""comment-author"">");
#nullable restore
#line 149 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                                      Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                <div class=\"comment-post-date\">\r\n                                                    ");
#nullable restore
#line 151 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                               Write(item.Datetime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </div>\r\n                                                <p>\r\n                                                    ");
#nullable restore
#line 154 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                               Write(item.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                            </div>\r\n                                        </li>\r\n");
#nullable restore
#line 158 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </ul>
                            </div>
                            <!-- comment area end -->
                            <!-- start blog comment box -->
                            <div class=""blog-comment-wrapper"">
                                <h5>Leave A Reply</h5>
                                <p>Email address will not be published. Required fields are marked *</p>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fad714145c0f6dfc0b79da150b6cbab487c7238b31617", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                                    <div class=\"comment-post-box\">\r\n                                        <div class=\"row\">\r\n                                            <div class=\"col-12\">\r\n\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fad714145c0f6dfc0b79da150b6cbab487c7238b32168", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#nullable restore
#line 173 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Comments.FirstOrDefault().BlogId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 173 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
                                                                                                                  WriteLiteral(Model.Blog.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                                <label>Comment</label>\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fad714145c0f6dfc0b79da150b6cbab487c7238b34827", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 176 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Views\BlogDetail\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Comments.FirstOrDefault().Content);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                            </div>\r\n");
                WriteLiteral("                                        </div>\r\n                                    </div>\r\n                                    <button class=\"btn\" type=\"submit\">Comment</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_10.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_10);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <!-- start blog comment box -->
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- blog main wrapper end -->
</main>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
