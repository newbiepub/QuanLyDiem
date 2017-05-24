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
    class Lop
    {
        public static DataTable getLopByKhoi(int khoi, string nienkhoa)
        {
            LopBL bl = new LopBL(khoi, nienkhoa);
            return bl.getLopByKhoi();
        }

        public static DataTable getLop()
        {
            LopBL bl = new LopBL();
            return bl.getLop();
        }

        public static DataTable getNienKhoa()
        {
            LopBL bl = new LopBL();
            return bl.getNienKhoa();
        }
     }
}
