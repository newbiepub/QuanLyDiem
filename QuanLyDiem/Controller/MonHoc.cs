using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyDiem.Business_Logic;
using System.Data;
namespace QuanLyDiem.Controller
{
    class MonHoc
    {
        public static DataTable getAllMonHoc()
        {
            MonHocBL monhoc = new MonHocBL();
            return monhoc.getAllMonHoc();
        }
    }
}
