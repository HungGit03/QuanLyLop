#pragma checksum "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcc79a062739df969e28ad4da83bf2face20b38e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Admin.Pages_Admin_TaiKhoanGV), @"mvc.1.0.razor-page", @"/Pages/Admin/TaiKhoanGV.cshtml")]
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
#line 2 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcc79a062739df969e28ad4da83bf2face20b38e", @"/Pages/Admin/TaiKhoanGV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719759b60c9780723f33678849aa40a96d8570f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_TaiKhoanGV : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n    var dataTKGV = ");
#nullable restore
#line 12 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
              Write(Html.Raw(JsonSerializer.Serialize(Model.lstTKGV)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">Lớp</h1>
    <p>Danh tài khoản Giáo viên.</p>
    <button type=""button"" onclick=""openModalTKGV(null);"" class=""btn btn-outline-primary btn-sm"">Thêm Tài khoản giáo viên</button>
    <table id=""tableTKGV""class=""table table-striped"">
        <tr>
            <th>Mã tài khoản</th>
            <th>Tên đăng nhập</th>
            <th>Mật khẩu</th>
            <th>Mã giáo viên</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 26 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
         foreach (TaiKhoanGVDTO tkgv in Model.lstTKGV)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 935, "\"", 957, 2);
            WriteAttributeValue("", 940, "trTKGV_", 940, 7, true);
#nullable restore
#line 28 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
WriteAttributeValue("", 947, tkgv.MaTk, 947, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <td>");
#nullable restore
#line 29 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
               Write(tkgv.MaTk);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
               Write(tkgv.TenDangNhap);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 31 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
               Write(tkgv.MatKhau);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 32 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
               Write(tkgv.MaGv);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1176, "\"", 1212, 3);
            WriteAttributeValue("", 1186, "openModalTKGV(", 1186, 14, true);
#nullable restore
#line 34 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
WriteAttributeValue("", 1200, tkgv.MaTk, 1200, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1210, ");", 1210, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1307, "\"", 1340, 3);
            WriteAttributeValue("", 1317, "deleteTKHS(", 1317, 11, true);
#nullable restore
#line 35 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
WriteAttributeValue("", 1328, tkgv.MaTk, 1328, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1338, ");", 1338, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xoá</button>\n                </td>\n            </tr>\n");
#nullable restore
#line 38 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\TaiKhoanGV.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalTKGV"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Sửa Tài khoản: <span id=""MaTKGV""></span></h5>
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
            <label for=""txtMaGv"">Mật khẩu</label>
            <input type=""text"" class=""form-control"" id=""txtMaGV"" aria-describedby=""MaGVHelp"" placeholder=""Nhập nã giáo viên"">
            <small id=""MaGVHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveTKGV()"" class=""btn btn-primary"">Save changes</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.TaiKhoanGVModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.TaiKhoanGVModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.TaiKhoanGVModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.TaiKhoanGVModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
