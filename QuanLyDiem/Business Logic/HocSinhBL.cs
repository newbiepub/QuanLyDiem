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
        public DataTable gethocsinh()
        {
            string query = "GetHocSinh";
            SqlParameter[] pr = {};
            return da.selectProc(query, pr);
        }
        public bool inserthocsinh(string tenHocSinh, string ngaySinh, int gioiTinh,string lop, string diaChi)
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
        public bool updatehocsinh(Int64 maHocSinh, string tenHocSinh, string ngaySinh, int gioiTinh, string lop, string diaChi)
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
