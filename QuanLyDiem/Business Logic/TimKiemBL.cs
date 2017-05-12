using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanLyDiem.Business_Logic
{
    class TimKiemBL
    {
        Data_Layer.DataAccess da = new Data_Layer.DataAccess();
        public DataTable FindStudentByID(int maHocSinh)
        {
            string query = "TimHocSinhCoBan";
            SqlParameter[] pr =
                {
                    new SqlParameter("@mahocsinh", maHocSinh), 
                };
            DataTable dt = da.selectProc(query,pr);
            return dt;
        }
        public DataTable FindStudentAdvance(int code, int year, string name ,string Class,string grade )
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
            //querry khoi
            string khoi = "";
            if (grade != "Không")
            {
                khoi = "and LOP.khoi=@khoi";
            }
            //querry Lop
            string lop = "";
            if (Class != "Không")
            {
                lop = "and LOP.TenLop=@tenlop";
            }
            //querry namsinh
            string namSinh = "";
            if (year != 0)
            {
                namSinh = "and year(NgaySinh)=@namsinh";
            }
               
            string query =
                    "select  MaHocSinh,TenHocSinh, NgaySinh,LOP.TenLop, GioiTinh, HOC_SINH.MaLop, DiaChi, Khoi, GhiChu from HOC_SINH,LOP where HOC_SINH.MaLop=LOP.MaLop " + khoi + " " + lop + " " + tenHocSinh + " " + maHocSinh + " " + namSinh + "";
            SqlParameter[] pr =
                {
                    new SqlParameter("@namsinh", year),
                    new SqlParameter("@tenhocsinh", name),
                    new SqlParameter("@tenlop", Class),
                    new SqlParameter("@mahocsinh", code),
                    new SqlParameter("@khoi", grade),
                };
            return da.select(query, pr);
        }

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
        public DataTable FindTeacherAdvance(int code, string supjectSpecialize, string name, string Class)
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
            if (Class != "Không")
            {
                lop = "and LOP.TenLop=@tenlop";
            }

            string query =
                "select MaGiaoVien,TenGiaoVien,NgaySinh,GioiTinh,LOP.MaLop,TenMon,TenLop,Khoi,SoDienThoai,DiaChi from DAY,GIAO_VIEN,LOP,MON_HOC where LOP.MaLop = DAY.MaLop and MaGiaoVien = MaGV and MON_HOC.MaMon = DAY.MaMon " + mon + " " + lop + " " + TenGiaoVien + " " + MaGiaoVien + "";
            SqlParameter[] pr =
                {
        
                    new SqlParameter("@tengiaovien", name),
                    new SqlParameter("@tenlop", Class),
                    new SqlParameter("@MaGiaoVien",code),
                    new SqlParameter("@tenmonhoc",supjectSpecialize),
                };
          
            return da.select(query, pr);
        }

    }
}
