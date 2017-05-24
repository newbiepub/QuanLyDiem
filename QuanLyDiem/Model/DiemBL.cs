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
        public int MaHocSinh { get; set; }

        public int MaMon { get; set; }

        public float DiemMieng { get; set; }

        public float DiemGiuaKy { get; set; }

        public float DiemHocKy { get; set; }

        public String HocKy { get; set; }

        public DateTime NamHoc { get; set; }

        public String GhiChu { get; set; }

        private DataAccess db;
        public DiemBL()
        {
            db = new DataAccess();
        }

        public DiemBL(int MaHocSinh, int MaMonHoc, String mahk)
        {
            db = new DataAccess();
            this.MaHocSinh = MaHocSinh;
            this.MaMon = MaMonHoc;
            this.HocKy = mahk;
        }

        public DiemBL(int mahocsinh, int mamon, float mieng, float giuaky, float cuoiky, string hocky, DateTime namhoc, string ghichu) 
        {
            db = new DataAccess();
            this.MaHocSinh = mahocsinh;
            this.MaMon = mamon;
            this.DiemMieng = mieng;
            this.DiemGiuaKy = giuaky;
            this.DiemHocKy = cuoiky;
            this.HocKy = hocky;
            this.NamHoc = namhoc;
            this.GhiChu = ghichu;
        }

        public DiemBL(int maHocSinh, String hocKy, DateTime namHoc)
        {
            db = new DataAccess();
            this.MaHocSinh = maHocSinh;
            this.HocKy = hocKy;
            this.NamHoc = namHoc;
        }

        public DataTable getDiemFromMahsAndMaMon()
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHocSinh", this.MaHocSinh),
                new SqlParameter("@MaMon", this.MaMon), 
                new SqlParameter("@HocKy", this.HocKy), 
            };
            return db.selectProc("select_diem_from_mahocsinh_mamonhoc", pr);
        }

        public bool insertDiem()
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHocSinh", this.MaHocSinh),
                new SqlParameter("@MaMon", this.MaMon),
                new SqlParameter("@DiemMieng", this.DiemMieng),
                new SqlParameter("@DiemGiuaKy", this.DiemGiuaKy),
                new SqlParameter("@DiemHocKy", this.DiemHocKy),
                new SqlParameter("@HocKy", this.HocKy),
                new SqlParameter("@NamHoc", this.NamHoc),
                new SqlParameter("@GhiChu", this.GhiChu),
            };
            return db.executeCommand("insert_diem", pr);
        }

        public DataTable getDiemFromMaHocSinhAndHocKyNamHoc()
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaHocSinh", this.MaHocSinh),
                new SqlParameter("@HocKy", this.HocKy), 
                new SqlParameter("@NamHoc", this.NamHoc), 
            };return db.selectProc("sDiemTheoMaHSvaHocKy", pr);
        }
    }
}
