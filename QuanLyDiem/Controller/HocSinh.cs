using QuanLyDiem.Business_Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Controller
{
    class HocSinh
    {
        public static DataTable gethocsinhwithlop(int malop)
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.gethocsinhwithlop(malop);
        }

        public static DataTable FindStudentByID(int maHocSinh)
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.FindStudentByID(maHocSinh);
        }

        public static DataTable FindTeacherAdvance(int code,int year,string name, int Class, string checkClass)
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.FindStudentAdvance(code, year, name, Class, checkClass);
        }

        public static DataTable gethocsinh()
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.gethocsinh();
        }

        public static bool inserthocsinh(string tenHocSinh, string ngaySinh, int gioiTinh, int lop, string diaChi)
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.inserthocsinh(tenHocSinh, ngaySinh, gioiTinh, lop, diaChi);
        }

        public static bool deletehocsinh(int maHocSinh)
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.deletehocsinh(maHocSinh);
        }

        public static bool updategiaovien(Int64 maHocSinh, string tenHocSinh, string ngaySinh, int gioiTinh, int lop, string diaChi)
        {
            HocSinhBL hs = new HocSinhBL();
            return hs.updatehocsinh(maHocSinh, tenHocSinh,  ngaySinh,  gioiTinh,  lop,  diaChi);
        }
    }
}
