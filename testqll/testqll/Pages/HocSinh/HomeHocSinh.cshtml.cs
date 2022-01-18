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
    public class HomeHocSinhModel : PageModel
    {
        public HocSinhDTO hocSinh;

        public string maHS;
        public string TenHS;
        public string GioiTinh;
        public DateTime NgaySinh;
        public string DiaChi;
        public double? Sdt;
        public string Email;
        public string Lop;

        private HocSinhBLL busHS;
        private LopBLL busLop;

        public HomeHocSinhModel() {
            busHS = new HocSinhBLL();
            busLop = new LopBLL();
        }
        public void OnGet()
        {
            var userId = HttpContext.Request.Cookies["user_id"];
            hocSinh = busHS.GetIdHS((string) userId);
            maHS = hocSinh.MaHs;
            TenHS = hocSinh.TenHs;
            GioiTinh = hocSinh.GioiTinh;
            NgaySinh = hocSinh.NgaySinh;
            DiaChi = hocSinh.DiaChi;
            Sdt = hocSinh.Sdt;
            Email = hocSinh.Email;
            Lop = busLop.GetLopById(hocSinh.MaLop).TenLop;

        }
    }
}
