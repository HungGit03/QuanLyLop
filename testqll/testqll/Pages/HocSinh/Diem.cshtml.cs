using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QLL.BLL;
using QLL.DTO;

namespace QuanLyLop.Pages.HocSinh
{
    public class DiemModel : PageModel
    {
        public List<DiemDTO> bangDiem;

        private DiemBLL busDiem;

        public MonHocBLL busMonHoc;

        private HocSinhBLL busHs;

        public string tenMonHoc;
        public string tenHocSinh;

        public DiemModel() {
            busDiem = new DiemBLL();
            busMonHoc = new MonHocBLL();
            busHs = new HocSinhBLL();
        }

        public void OnGet() {
            var userId = HttpContext.Request.Cookies["user_id"];
            bangDiem = busDiem.getDiemHS((string)userId).ToList();
            tenHocSinh = busHs.getTenHS((string) userId);
        }
    }
}