#pragma checksum "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c27bfb8ee07919822847ecf2fd0e866fcf30977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(testqll.Pages.Admin.Pages_Admin_Diem), @"mvc.1.0.razor-page", @"/Pages/Admin/Diem.cshtml")]
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
#line 2 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
using QLL.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
using Microsoft.AspNetCore.Antiforgery;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c27bfb8ee07919822847ecf2fd0e866fcf30977", @"/Pages/Admin/Diem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"719759b60c9780723f33678849aa40a96d8570f4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Diem : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
  
   var token = antiforgery.GetAndStoreTokens(HttpContext).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("<script type=\"text/javascript\">\n    var dataD = ");
#nullable restore
#line 12 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
           Write(Html.Raw(JsonSerializer.Serialize(Model.lstd)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
</script>
<div class=""text-center"">
    <h1 class=""display-4"">Lớp</h1>
    <p>Danh sách Điểm.</p>
    <button type=""button"" onclick=""openModalD(null, null);"" class=""btn btn-outline-primary btn-sm"">Thêm điểm</button>
    <table id=""tableD""class=""table table-striped"">
        <tr>
            <th>Mã môn học</th>
            <th>Mã học sinh</th>
            <th>Điểm</th>
            <th>Action</th>
        </tr>
");
#nullable restore
#line 25 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
         foreach (DiemDTO m  in Model.lstd)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("id", " id=\"", 845, "\"", 868, 3);
            WriteAttributeValue("", 850, "trD_", 850, 4, true);
#nullable restore
#line 27 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
WriteAttributeValue("", 854, m.MaMh, 854, 7, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
WriteAttributeValue("", 861, m.MaHs, 861, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                <td>");
#nullable restore
#line 28 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
               Write(m.MaMh);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
               Write(m.MaHs);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 30 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
               Write(m.Diem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1032, "\"", 1073, 6);
            WriteAttributeValue("", 1042, "openModalD(", 1042, 11, true);
#nullable restore
#line 32 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
WriteAttributeValue("", 1053, m.MaMh, 1053, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1060, ",", 1060, 1, true);
            WriteAttributeValue(" ", 1061, "\'", 1062, 2, true);
#nullable restore
#line 32 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
WriteAttributeValue("", 1063, m.MaHs, 1063, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1070, "\');", 1070, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1168, "\"", 1206, 6);
            WriteAttributeValue("", 1178, "deleteD(", 1178, 8, true);
#nullable restore
#line 33 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
WriteAttributeValue("", 1186, m.MaMh, 1186, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1193, ",", 1193, 1, true);
            WriteAttributeValue(" ", 1194, "\'", 1195, 2, true);
#nullable restore
#line 33 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
WriteAttributeValue("", 1196, m.MaHs, 1196, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1203, "\');", 1203, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">xoá</button>\n                </td>\n            </tr>\n");
#nullable restore
#line 36 "E:\ĐỒ ÁN LTCSDL_THƯƠNG\QuanLyLop\testqll\testqll\Pages\Admin\Diem.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id =""DivModalD"" class=""modal"" tabindex=""-1"" role=""dialog"">
  <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header"">
        <h5 class=""modal-title"">Sửa điểm:  
            <span id=""MaMH""></span>
            <span id=""MaHS""></span>
        </h5>
        <button type=""button"" class=""close"" data-dismiss=""modal"" onclick=""closeModal()"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        <div class=""form-group"">
            <label for=""txtMaMH"">Mã môn học</label>
            <input type=""text"" class=""form-control"" id=""txtMaMH"" aria-describedby=""MaMHHelp"" placeholder=""Mã môn học"">
            <small id=""MaMHHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtMaHS"">Mã học sinh</label>
            <input type=""text"" class=""form-control"" id=""txtMaHS"" aria-descr");
            WriteLiteral(@"ibedby=""MaHSHelp"" placeholder=""Mã học sinh"">
            <small id=""MaHSHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
        <div class=""form-group"">
            <label for=""txtDiem"">Mã môn học</label>
            <input type=""text"" class=""form-control"" id=""txtDiem"" aria-describedby=""DiemHelp"" placeholder=""Điểm"">
            <small id=""DiemHelp"" class=""form-text text-muted"">Không được bỏ trống.</small>
        </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary"" onclick=""closeModal()"" data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveD()"" class=""btn btn-primary"">Save changes</button>
      </div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyLop2_ASP.NETCore.Pages.DiemModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.DiemModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<QuanLyLop2_ASP.NETCore.Pages.DiemModel>)PageContext?.ViewData;
        public QuanLyLop2_ASP.NETCore.Pages.DiemModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591