using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.Native.Data;
using QuanLyDiem.Business_Logic;
using DataTable = System.Data.DataTable;

namespace QuanLyDiem.Controller
{
    class Khoi
    {
        public static DataTable getAllKhoi()
        {
            KhoiBL khoi = new KhoiBL();
            return khoi.getAllKhoi();
        }
    }
}
