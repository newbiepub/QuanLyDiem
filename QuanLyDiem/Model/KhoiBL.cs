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
            SqlParameter[] pr = new SqlParameter[0];
            return db.selectProc("getAllKhoi", pr);
        }

        public DataTable getAllLopFromKhoi(String makhoi)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@makhoi", makhoi),
            };
            return db.selectProc("getAllLopTheoKhoi", pr);
        }

        public DataTable getAllHocSinhFromLop(String malop)
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@malop", malop),
            };
            return db.selectProc("getAllHocSinhTheoLop", pr);
        }
    }
}
