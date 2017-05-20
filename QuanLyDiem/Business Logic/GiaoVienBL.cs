using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Business_Logic
{
    class GiaoVienBL
    {
        Data_Layer.DataAccess da = new Data_Layer.DataAccess();

        public DataTable FindTeacherByID(int maGiaovien)
        {
            string query = "TimGiaoVienCoBan";
            SqlParameter[] pr =
                {
                    new SqlParameter("@magiaovien", maGiaovien), 
                };
            DataTable dt = da.selectProc(query, pr);
            return dt;
        }
        public DataTable FindTeacherAdvance(int code, string supjectSpecialize, string name, int Class,string checkClass)
        {

            //querry ten
            string TenGiaoVien = "";
            if (name != "")
            {
                TenGiaoVien = "and TenGiaoVien=@tengiaovien";
            }
            //querry ma
            string MaGiaoVien = "";
            if (code != 0)
            {
                MaGiaoVien = "and MaGiaoVien=@MaGiaoVien";
            }
            //querry mon
            string mon = "";
            if (supjectSpecialize != "Không")
            {
                mon = "and TenMon= @tenmonhoc";
            }
            
            //querry Lop
            string lop = "";
            if (checkClass != "Không")
            {
                lop = "and LOP.MaLop=@malop";
            }

            string query =
                "select MaGiaoVien,TenGiaoVien,NgaySinh,GioiTinh,NienKhoa, LOP.MaLop,TenMon,TenLop,Khoi,SoDienThoai,DiaChi from DAY,GIAO_VIEN,LOP,MON_HOC where LOP.MaLop = DAY.MaLop and MaGiaoVien = MaGV and MON_HOC.MaMon = DAY.MaMon " + mon + " " + lop + " " + TenGiaoVien + " " + MaGiaoVien + "";
            SqlParameter[] pr =
                {
        
                    new SqlParameter("@tengiaovien", name),
                    new SqlParameter("@malop", Class),
                    new SqlParameter("@MaGiaoVien",code),
                    new SqlParameter("@tenmonhoc",supjectSpecialize),
                   
                };

            return da.select(query, pr);
        }
        public DataTable getgiaovien()
        {
            string query = "GetGiaoVien";
            SqlParameter[] pr = { };
            return da.selectProc(query, pr);
        }
        public bool insertgiaovien(string tenGiaoVien, string ngaySinh, int gioiTinh, int lop, string diaChi, string soDienThoai,int mon)
        {
            string query = "ThemGiaoVien";
            SqlParameter[] pr =
            { 
                new SqlParameter( "@ten", tenGiaoVien),
                new SqlParameter( "@ngaysinh", ngaySinh),
                new SqlParameter( "@gioitinh", gioiTinh),
                new SqlParameter( "@lop", lop),
                new SqlParameter( "@diachi", diaChi),
                new SqlParameter( "@sodienthoai", soDienThoai),
                new SqlParameter( "@mon", mon)
            };
            return da.insertProc(query, pr);

        }
        public bool deletegiaovien(Int64 maGiaoVien)
        {
            string query = "XoaGiaoVien";
            SqlParameter[] pr =
            { 
                new SqlParameter( "@ma", maGiaoVien)
            };
            return da.deleteProc(query, pr);
        }
        public bool updategiaovien(Int64 maGiaoVien, string tenGiaoVien, string ngaySinh, int gioiTinh, int lop, string diaChi, string soDienThoai, int mon)
        {
            string query = "SuaGiaoVien";
            SqlParameter[] pr =
            { 
                new SqlParameter( "@ma", maGiaoVien),
                 new SqlParameter( "@ten", tenGiaoVien),
                new SqlParameter( "@ngaysinh", ngaySinh),
                new SqlParameter( "@gioitinh", gioiTinh),
                new SqlParameter( "@lop", lop),
                new SqlParameter( "@diachi", diaChi),
                new SqlParameter( "@sodienthoai", soDienThoai),
                new SqlParameter( "@mon", mon)
            };
            return da.updateProc(query, pr);
        }
    }
}
