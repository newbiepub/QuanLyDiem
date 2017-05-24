using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;
using QuanLyDiem.Business_Logic;

namespace QuanLyDiem.Controller
{
    class Diem
    {
        public static DataTable getDiemFromMahsAndMaMon(int mahocsinh, int mamon, string hocky, DateTime namHoc)
        {
            DiemBL diem = new DiemBL(mahocsinh, mamon, hocky, namHoc);
            return diem.getDiemFromMahsAndMaMon();
        }

        public static bool insertDiem(int mahocsinh, int mamon, float mieng, float giuaky, float cuoiky, string hocky,
            DateTime namhoc, string ghichu)
        {
            DiemBL diem = new DiemBL(mahocsinh, mamon, mieng, giuaky, cuoiky, hocky, namhoc, ghichu);
            return diem.insertDiem();
        }

        public static DataTable getDiemFromMaHocSinhAndHocKyNamHoc(int maHocSinh, String hocKy, DateTime namHoc)
        {
            DiemBL diem = new DiemBL(maHocSinh, hocKy, namHoc);
            return diem.getDiemFromMaHocSinhAndHocKyNamHoc();
        }
    }
}
