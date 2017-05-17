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
