using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.Business_Logic;
using System.Data;
namespace QuanLyDiem.Controller
{
    static class MonHoc
    {
        public static DataTable getAllMonHoc()
        {
            MonHocBL monhoc = new MonHocBL();
            return monhoc.getAllMonHoc();
        }

        public static bool insertMonHoc(string TenMon)
        {MonHocBL monhoc = new MonHocBL(TenMon);
            return monhoc.insertMonHoc();
        }

        public static bool updateMonHoc(int mamon, string tenmon)
        {
            MonHocBL monhoc = new MonHocBL(mamon, tenmon);
            return monhoc.updateMonHoc();
        }

        public static bool deleteMonHoc(int mamon)
        {
            MonHocBL monhoc = new MonHocBL(mamon);
            return monhoc.deleteMonHoc();
        }
    }
}
