using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Native.Data;
using QuanLyDiem.Data_Layer;
using DataTable = System.Data.DataTable;

namespace QuanLyDiem.Business_Logic
{
    class MonHocBL
    {
        private DataAccess db;

        public MonHocBL()
        {
            db = new DataAccess();
        }

        public DataTable getAllMonHoc()
        {
            String query = "select MaMon,TenMon from MON_HOC";
            SqlParameter[] pr = new SqlParameter[0];
            return db.select(query, pr);
        }
    }
}
