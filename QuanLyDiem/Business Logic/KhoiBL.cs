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
    class KhoiBL
    {
        private DataAccess db;

        public KhoiBL()
        {
            db = new DataAccess();
        }

        public DataTable getKhoiLopHocSinh()
        {
            String query = "select lop.MaLop, TenLop,khoiId, KHOI.Khoi, hoc_sinh.TenHocSinh, hoc_sinh.MaHocSinh from KHOI" +
                           " inner join LOP on KHOI.khoiId=LOP.Khoi inner join HOC_SINH on LOP.MaLop=HOC_SINH.MaLop";
            SqlParameter[] pr = new SqlParameter[0];
            return db.select(query, pr);
        }
    }
}
