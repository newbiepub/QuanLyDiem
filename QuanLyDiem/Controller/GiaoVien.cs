using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.Business_Logic;

namespace QuanLyDiem.Controller
{
    class GiaoVien
    {
        public static DataTable getgiaovienwithlop(int malop)
        {
            GiaoVienBL gv = new GiaoVienBL();
            return gv.getgiaovienwithlop(malop);
        }

        public static DataTable FindTeacherByID(int maGiaoVien)
        {
            GiaoVienBL gv = new GiaoVienBL();
            return gv.FindTeacherByID(maGiaoVien);
        }

        public static DataTable FindTeacherAdvance(int code, string supjectSpecialize, string name, int Class, string checkClass)
        {
            GiaoVienBL gv = new GiaoVienBL();
            return gv.FindTeacherAdvance(code, supjectSpecialize, name, Class, checkClass);
        }

        public static DataTable getgiaovien()
        {
            GiaoVienBL gv = new GiaoVienBL();
            return gv.getgiaovien();
        }

        public static bool insertgiaovien(string tenGiaoVien, string ngaySinh, int gioiTinh, int lop, string diaChi, string soDienThoai, int mon)
        {
            GiaoVienBL gv = new GiaoVienBL(tenGiaoVien, ngaySinh, gioiTinh, lop, diaChi, soDienThoai, mon);
            return gv.insertgiaovien();
        }

        public static bool deletegiaovien(int maGiaoVien)
        {
            GiaoVienBL gv = new GiaoVienBL();
            return gv.deletegiaovien(maGiaoVien);
        }

        public static bool updategiaovien(int maGiaoVien, string tenGiaoVien, string ngaySinh, int gioiTinh, int lop, string diaChi, string soDienThoai, int mon)
        {
            GiaoVienBL gv = new GiaoVienBL(maGiaoVien, tenGiaoVien, ngaySinh, gioiTinh, lop, diaChi, soDienThoai, mon);
            return gv.updategiaovien();
        }
    }
}
