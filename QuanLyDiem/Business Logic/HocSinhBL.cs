using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QuanLyDiem.Business_Logic
{
    class HocSinhBL
    {
        Data_Layer.DataAccess da = new Data_Layer.DataAccess();
        public DataTable gethocsinhwithlop(int maLop)
        {
            string query = "GetHocSinhWithLop";
            SqlParameter[] pr = 
            { 
                new SqlParameter("@malop", maLop),
            };
            return da.selectProc(query, pr);
        }
        public DataTable FindStudentByID(int maHocSinh)
        {
            string query = "TimHocSinhCoBan";
            SqlParameter[] pr =
                {
                    new SqlParameter("@mahocsinh", maHocSinh), 
                };
            DataTable dt = da.selectProc(query, pr);
            return dt;
        }
        public DataTable FindStudentAdvance(int code, int year, string name, int Class, string checkClass)
        {
            //querry ten
            string tenHocSinh = "";
            if (name != "")
            {
                tenHocSinh = "and TenHocSinh=@tenhocsinh";
            }
            //querry ma
            string maHocSinh = "";
            if (code != 0)
            {
                maHocSinh = "and MaHocSinh=@mahocsinh";
            }
           
            //querry Lop
            string lop = "";
            if (checkClass != "Không")
            {
                lop = "and LOP.MaLop=@malop";
            }
            //querry namsinh
            string namSinh = "";
            if (year != 0)
            {
                namSinh = "and year(NgaySinh)=@namsinh";
            }

            string query =
                    "select  MaHocSinh,TenHocSinh, NgaySinh,LOP.TenLop, GioiTinh, HOC_SINH.MaLop,NienKhoa, DiaChi, Khoi, GhiChu from HOC_SINH,LOP where HOC_SINH.MaLop=LOP.MaLop " + lop + " " + tenHocSinh + " " + maHocSinh + " " + namSinh + "";
            SqlParameter[] pr =
                {
                    new SqlParameter("@namsinh", year),
                    new SqlParameter("@tenhocsinh", name),
                    new SqlParameter("@malop", Class),
                    new SqlParameter("@mahocsinh", code),
                    
                };
            return da.select(query, pr);
        }

        public DataTable gethocsinh()
        {
            string query = "GetHocSinh";
            SqlParameter[] pr = {};
            return da.selectProc(query, pr);
        }
        public bool inserthocsinh(string tenHocSinh, string ngaySinh, int gioiTinh,int lop, string diaChi)
        {
            string query = "ThemHocSinh";
            SqlParameter[] pr =
            { 
                new SqlParameter( "@tenHocSinh", tenHocSinh),
                new SqlParameter( "@ngaysinh", ngaySinh),
                new SqlParameter( "@gioitinh", gioiTinh),
                new SqlParameter( "@malop", lop),
                new SqlParameter( "@diachi", diaChi)
            };
            return da.insertProc(query, pr);

        }
        public bool deletehocsinh(Int64 maHocSinh)
        {
            string query = "XoaHocSinh";
            SqlParameter[] pr =
            { 
                new SqlParameter( "@mahocsinh", maHocSinh)
            };
            return da.deleteProc(query, pr);
        }
        public bool updatehocsinh(Int64 maHocSinh, string tenHocSinh, string ngaySinh, int gioiTinh, int lop, string diaChi)
        {
            string query = "SuaHocSinh";
            SqlParameter[] pr =
            { 
                new SqlParameter( "@mahocsinh", maHocSinh),
                new SqlParameter( "@tenHocSinh", tenHocSinh),
                new SqlParameter( "@ngaysinh", ngaySinh),
                new SqlParameter( "@gioitinh", gioiTinh),
                new SqlParameter( "@malop", lop),
                new SqlParameter( "@diachi", diaChi)
            };
            return da.updateProc(query, pr);
        }
    }
}
