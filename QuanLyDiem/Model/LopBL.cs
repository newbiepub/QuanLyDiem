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

        public int Khoi { get; set; }

        public string  NienKhoa { get; set; }

        public LopBL()
        {
            
        }

        public LopBL(int khoi, string nienkhoa)
        {
            this.Khoi = khoi;
            this.NienKhoa = nienkhoa;
        }

        public DataTable getLop()
        {
            String query = "select * from LOP";
            SqlParameter[] pr = new SqlParameter[0];
            return da.select(query, pr);
        }
        public DataTable getLopByKhoi()
        {
            String query = "select * from LOP where Khoi=@makhoi and NienKhoa=@nienkhoa";
            SqlParameter[] pr =
            {
                new SqlParameter("@makhoi", this.Khoi),
                new SqlParameter("@nienkhoa", this.NienKhoa), 
            };
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
