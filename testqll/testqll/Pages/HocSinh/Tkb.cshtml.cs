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
    public class TkbModel : PageModel
    {
       public HocSinhDTO hocSinh;
        public string TenHS;
        public string Lop;
        public List<TKBCTDTO> tkb;

        private HocSinhBLL busHS;
        private LopBLL busLop;

        private TKBCTBLL busTkb;

        public GiaoVienBLL busGV;

        public MonHocBLL busMonHoc;


        public TkbModel() {
            busHS = new HocSinhBLL();
            busLop = new LopBLL();
            busTkb = new TKBCTBLL();
            busGV = new GiaoVienBLL();
            busMonHoc = new MonHocBLL();
        }
        public void OnGet()
        {
            var userId = HttpContext.Request.Cookies["user_id"];
            hocSinh = busHS.GetIdHS((string) userId);
            TenHS = hocSinh.TenHs;
            Lop = busLop.GetLopById(hocSinh.MaLop).TenLop;
            tkb = busTkb.getTkbByLop(hocSinh.MaLop).ToList();
        }
    }
}