#pragma checksum "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\RelatedHeader\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb536ef368bb61a5c3fb84e2757e23073d1d37c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminArea_Views_RelatedHeader_Detail), @"mvc.1.0.view", @"/Areas/AdminArea/Views/RelatedHeader/Detail.cshtml")]
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
#line 1 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using BackendProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using BackendProject.ViewModels.ProductHeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using BackendProject.ViewModels.TopHeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using BackendProject.ViewModels.RelatedHeaderViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\_ViewImports.cshtml"
using BackendProject.ViewModels.SliderViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb536ef368bb61a5c3fb84e2757e23073d1d37c0", @"/Areas/AdminArea/Views/RelatedHeader/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"256dc6f97d4740a28f2218a6ed89024032c27a06", @"/Areas/AdminArea/Views/_ViewImports.cshtml")]
    public class Areas_AdminArea_Views_RelatedHeader_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RelatedHeaderDetailVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\RelatedHeader\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<div class=\"container-fluid my-3 mx-3\">\r\n    <div class=\"table-responsive pt-3\">\r\n");
            WriteLiteral(@"        <table class=""table table-bordered"">
            <thead>
                <tr>

                    <th>
                        Title
                    </th>
                    <th>
                        Description
                    </th>

                </tr>
            </thead>
            <tbody>
                <tr>

                    <
                    <td>
                        ");
#nullable restore
#line 31 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\RelatedHeader\Detail.cshtml"
                   Write(Html.Raw(Model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 34 "C:\Users\ESQIN\OneDrive\İş masası\Asp.Net-BackendProject\BackendProject\Areas\AdminArea\Views\RelatedHeader\Detail.cshtml"
                   Write(Html.Raw(Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n");
            WriteLiteral("                </tr>\r\n\r\n\r\n            </tbody>\r\n        </table>\r\n    </div>\r\n");
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RelatedHeaderDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591