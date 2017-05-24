using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Native.Data;
using DevExpress.XtraRichEdit.Commands;
using QuanLyDiem.Controller;
using QuanLyDiem.Data_Layer;
using DataTable = System.Data.DataTable;

namespace QuanLyDiem.Business_Logic
{
    class MonHocBL
    {
        public int Mamon { get; set; }
        public string Tenmon { get; set; }
        public MonHocBL(int mamon, string tenmon)
        {
            this.Mamon = mamon;
            this.Tenmon = tenmon;
        }
        private DataAccess db = new DataAccess();
        public MonHocBL(string TenMon)
        {
            this.Tenmon = TenMon;
        }

        public MonHocBL(int mamon)
        {
            this.Mamon = mamon;
        }

        public MonHocBL()
        {
            
        }

        public DataTable getAllMonHoc()
        {
            String query = "select MaMon,TenMon from MON_HOC";
            SqlParameter[] pr = new SqlParameter[0];
            return db.select(query, pr);
        }

        public bool insertMonHoc()
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@TenMon", this.Tenmon),
            };
            return db.executeCommand("insertMonHoc", pr);
        }

        public bool updateMonHoc()
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaMon", this.Mamon),
                new SqlParameter("@TenMon", this.Tenmon)
            };
            return db.executeCommand("updateMonHoc", pr);
        }

        public bool deleteMonHoc()
        {
            SqlParameter[] pr =
            {
                new SqlParameter("@MaMon", this.Mamon),
            };
            return db.executeCommand("deleteMonHoc", pr);
        }
    }
}
