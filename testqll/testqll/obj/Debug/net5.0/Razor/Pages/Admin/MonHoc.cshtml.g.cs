#pragma checksum "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0e5001df888f22f7a3d3c886f9afd0b97c5bcf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Admin.Pages_Admin_MonHoc), @"mvc.1.0.razor-page", @"/Pages/Admin/MonHoc.cshtml")]
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
#line 2 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d0e5001df888f22f7a3d3c886f9afd0b97c5bcf", @"/Pages/Admin/MonHoc.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719759b60c9780723f33678849aa40a96d8570f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_MonHoc : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n    var dataMH = ");
#nullable restore
#line 12 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lstMH)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">Lớp</h1>
    <p>Danh sách môn học.</p>
    <button type=""button"" onclick=""openModalMH(null);"" class=""btn btn-outline-primary btn-sm"">Thêm Môn học</button>
    <table id=""tableMH""class=""table table-striped"">
        <tr>
            <th>Mã môn học</th>
            <th>Tên môn học</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 24 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
         foreach (MonHocDTO m  in Model.lstMH)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 828, "\"", 845, 2);
            WriteAttributeValue("", 833, "trMH_", 833, 5, true);
#nullable restore
#line 26 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
WriteAttributeValue("", 838, m.MaMh, 838, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <td>");
#nullable restore
#line 27 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
               Write(m.MaMh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
               Write(m.TenMh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 977, "\"", 1008, 3);
            WriteAttributeValue("", 987, "openModalMH(", 987, 12, true);
#nullable restore
#line 30 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
WriteAttributeValue("", 999, m.MaMh, 999, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1006, ");", 1006, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1103, "\"", 1132, 3);
            WriteAttributeValue("", 1113, "deleteMH(", 1113, 9, true);
#nullable restore
#line 31 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
WriteAttributeValue("", 1122, m.TenMh, 1122, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1130, ");", 1130, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xoá</button>\n                </td>\n            </tr>\n");
#nullable restore
#line 34 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\MonHoc.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalMH"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Sửa môn học: <span id=""MaMH""></span></h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""form-group"">
            <label for=""txtTenMH"">Tên môn học</label>
            <input type=""text"" class=""form-control"" id=""txtTenMH"" aria-describedby=""TenMHHelp"" placeholder=""Tên môn học"">
            <small id=""TenMHHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveMH()"" class=""btn bt");
            WriteLiteral("n-primary\">Save changes</button>\n      </div>\n      </div>\n    </div>\n   </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.MonHocModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.MonHocModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.MonHocModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.MonHocModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591