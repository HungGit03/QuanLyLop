#pragma checksum "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "530efe6688fe2bc5b5235aa0d5e1bb103a6cef69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.HocSinh.Pages_HocSinh_Diem), @"mvc.1.0.razor-page", @"/Pages/HocSinh/Diem.cshtml")]
namespace testqll.Pages.HocSinh
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
#line 1 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\_ViewImports.cshtml"
using testqll;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"530efe6688fe2bc5b5235aa0d5e1bb103a6cef69", @"/Pages/HocSinh/Diem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719759b60c9780723f33678849aa40a96d8570f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_HocSinh_Diem : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"diemhs-section\">\n    <h1 style=\"text-align: center; margin-bottom: 30px;\">Điểm</h1>\n    <h3 style=\"margin-bottom: 20px;\">");
#nullable restore
#line 12 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
                                Write(Model.tenHocSinh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n    <table class=\"table\">\n        <thead class=\"thead-dark\">\n            <tr>\n                <th scope=\"col\">Tên môn học</th>\n                <th scope=\"col\">Điểm</th>\n            </tr>\n        </thead>\n");
#nullable restore
#line 20 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
         foreach(DiemDTO diem in Model.bangDiem){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tbody>\n                <tr>\n                    <th>");
#nullable restore
#line 23 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
                   Write(Model.busMonHoc.getTenMH(diem.MaMh));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                    <td>");
#nullable restore
#line 24 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
                   Write(diem.Diem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                </tr>\n            </tbody>\n");
#nullable restore
#line 27 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\HocSinh\Diem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAntiforgery antiforgery { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop.Pages.HocSinh.DiemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop.Pages.HocSinh.DiemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop.Pages.HocSinh.DiemModel>)PageContext?.ViewData;
        public QuanLyLop.Pages.HocSinh.DiemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591