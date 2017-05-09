using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDiem.Entity
{
    class MonHoc
    {
        public Int32 MaMon { get; set; }
        public String TenMon { get; set; }

        public MonHoc()
        {
            
        }

        public MonHoc(Int32 maMon, String tenMon)
        {
            this.MaMon = maMon;
            this.TenMon = tenMon;
        }
    }
}
