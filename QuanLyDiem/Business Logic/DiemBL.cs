using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.Data_Layer;

namespace QuanLyDiem.Business_Logic
{
    class DiemBL
    {
        private DataAccess db;
        public DiemBL()
        {
            db = new DataAccess();
        }

        public DataTable getDiemFromMahsAndMaMon(String MaHocSinh, String MaMonHoc, String mahk)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHocSinh", MaHocSinh),
                new SqlParameter("@MaMon", MaMonHoc), 
                new SqlParameter("@HocKy", mahk), 
            };
            return db.selectProc("select_diem_from_mahocsinh_mamonhoc", pr);
        }

        public bool insertDiem(int mahocsinh, int mamon, int mieng, int giuaky, int cuoiky, String hocky, DateTime namhoc,
            String ghichu)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHocSinh", mahocsinh),
                new SqlParameter("@MaMon", mamon),
                new SqlParameter("@DiemMieng", mieng),
                new SqlParameter("@DiemGiuaKy", giuaky),
                new SqlParameter("@DiemHocKy", cuoiky),
                new SqlParameter("@HocKy", hocky),
                new SqlParameter("@NamHoc", namhoc),
                new SqlParameter("@GhiChu", ghichu),
            };
            return db.executeCommand("insert_diem", pr);
        }

        public DataTable getDiemFromMaHocSinhAndHocKyNamHoc(String maHocSinh, String hocKy, DateTime namHoc)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHocSinh", maHocSinh),
                new SqlParameter("@HocKy", hocKy), 
                new SqlParameter("@NamHoc", namHoc), 
            };
            return db.selectProc("sDiemTheoMaHSvaHocKy", pr);
        }
    }
}
