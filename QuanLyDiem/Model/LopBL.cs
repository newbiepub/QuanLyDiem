using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Business_Logic
{
    class LopBL
    {
        Data_Layer.DataAccess da = new Data_Layer.DataAccess();

        public DataTable getLop()
        {
            String query = "select * from LOP";
            SqlParameter[] pr = new SqlParameter[0];
            return da.select(query, pr);
        }
        public DataTable getLopByKhoi(int Khoi, string nienKhoa)
        {
            String query = "select * from LOP where Khoi = '"+Khoi+"' and NienKhoa = '"+nienKhoa+"'";
            SqlParameter[] pr = new SqlParameter[0];
            return da.select(query, pr);
        }
        public DataTable getNienKhoa()
        {
            String query = "select NienKhoa from LOP group by NienKhoa";
            SqlParameter[] pr = new SqlParameter[0];
            return da.select(query, pr);
        }
    }
}
