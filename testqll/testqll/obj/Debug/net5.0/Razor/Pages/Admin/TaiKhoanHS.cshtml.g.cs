#pragma checksum "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a758dbaa47bc82af76aec57b3c17bb76744a1823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Admin.Pages_Admin_TaiKhoanHS), @"mvc.1.0.razor-page", @"/Pages/Admin/TaiKhoanHS.cshtml")]
namespace testqll.Pages.Admin
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
#line 2 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a758dbaa47bc82af76aec57b3c17bb76744a1823", @"/Pages/Admin/TaiKhoanHS.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719759b60c9780723f33678849aa40a96d8570f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_TaiKhoanHS : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n    var dataTKHS = ");
#nullable restore
#line 12 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
              Write(Html.Raw(JsonSerializer.Serialize(Model.lstTKHS)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"" onload=""onLoadBody"">
    <h1 class=""display-4"">Lớp</h1>
    <p>Danh tài khoản học sinh.</p>
    <button type=""button"" onclick=""openModalTKHS(null);"" class=""btn btn-outline-primary btn-sm"">Thêm Tài khoản học sinh</button>
    <table id=""tableTKHS""class=""table table-striped"">
        <tr>
            <th>Mã tài khoản</th>
            <th>Tên đăng nhập</th>
            <th>Mật khẩu</th>
            <th>Mã học sinh</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 26 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
         foreach (TaiKhoanHSDTO tkhs in Model.lstTKHS)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 952, "\"", 974, 2);
            WriteAttributeValue("", 957, "trTKHS_", 957, 7, true);
#nullable restore
#line 28 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
WriteAttributeValue("", 964, tkhs.MaTk, 964, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <td>");
#nullable restore
#line 29 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
               Write(tkhs.MaTk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
               Write(tkhs.TenDangNhap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
               Write(tkhs.MatKhau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
               Write(tkhs.MaHs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1193, "\"", 1229, 3);
            WriteAttributeValue("", 1203, "openModalTKHS(", 1203, 14, true);
#nullable restore
#line 34 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
WriteAttributeValue("", 1217, tkhs.MaTk, 1217, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1227, ");", 1227, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1324, "\"", 1357, 3);
            WriteAttributeValue("", 1334, "deleteTKHS(", 1334, 11, true);
#nullable restore
#line 35 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
WriteAttributeValue("", 1345, tkhs.MaTk, 1345, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1355, ");", 1355, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xoá</button>\n                </td>\n            </tr>\n");
#nullable restore
#line 38 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanHS.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalTKHS"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Sửa Tài khoản: <span id=""MaTKHS""></span></h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""form-group"">
            <label for=""txtTDN"">Tên đăng nhập</label>
            <input type=""text"" class=""form-control"" id=""txtTDN"" aria-describedby=""TDNHelp"" placeholder=""Tên Đăng nhập"">
            <small id=""TDNHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtMK"">Mật khẩu</label>
            <input type=""text"" class=""form-control"" id=""txtMK"" aria-describedby=""MKHelp"" placeholder=""Nhập mật khẩu"">
         ");
            WriteLiteral(@"   <small id=""MKHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtMaHS"">Mã học sinh</label>
            <input type=""text"" class=""form-control"" id=""txtMaHS"" aria-describedby=""MaHSHelp"" placeholder=""Nhập mã học sinh"">
            <small id=""MaHSHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveTKHS()"" class=""btn btn-primary"">Save changes</button>
      </div>
    </div>
  </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.TaiKhoanHSModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.TaiKhoanHSModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.TaiKhoanHSModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.TaiKhoanHSModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591