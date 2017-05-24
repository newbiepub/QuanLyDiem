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

        public int maKhoi { get; set; }

        public int maLop { get; set; }

        private DataAccess db = new DataAccess();

        public KhoiBL()
        {
           
        }

        public KhoiBL(int makhoi)
        {
            this.maKhoi = makhoi;
        }

        public DataTable getAllKhoi()
        {
            SqlParameter[] pr = new SqlParameter[0];
            return db.selectProc("getAllKhoi", pr);
        }

    }
}
