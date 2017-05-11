using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using Json;
using QuanLyDiem.Business_Logic;

namespace QuanLyDiem.Presentation{
    public partial class FormNhapDiem : Form
    {

        private class Diem
        {
            public int diemMieng { get; set; }
            public int  diemGiuaKi { get; set; }
            public int  diemCuoiKi { get; set; }

            public Diem()
            {
                
            }

            public Diem(int mieng, int giuaki, int cuoiki)
            {
                this.diemMieng = mieng;
                this.diemGiuaKi = giuaki;
                this.diemCuoiKi = cuoiki;
            }
        }
        private MonHocBL mongoHocBl;
        private static DataTable dtDiem;
        private KhoiBL khoiBl;
        private static BindingSource bsKhoi;
        public FormNhapDiem()
        {
            InitializeComponent();
            mongoHocBl = new MonHocBL();
            khoiBl = new KhoiBL();
            dtDiem = new DataTable();
            bsKhoi = new BindingSource();
        }

        private DataRow dtDiemAddRow(DataTable dtDiem, String hocki, String mahk)
        {
            DataRow dataRow = dtDiem.NewRow();
            dataRow.BeginEdit();
            dataRow["hocki"] = hocki;
            dataRow["mahk"] = mahk;
            dataRow.EndEdit();
            return dataRow;
        }

        private void loadMonHoc()
        {
            this.cb_monhoc.ValueMember = "mamon";
            this.cb_monhoc.DisplayMember = "tenmon";
            this.cb_monhoc.DataSource = mongoHocBl.getAllMonHoc();
        }

        private void loadHocKi()
        {
            DataTable dtHocKi = new DataTable();
            dtHocKi.Columns.Add(new DataColumn("hocki"));
            dtHocKi.Columns.Add(new DataColumn("mahk"));
            dtHocKi.Rows.Add(this.dtDiemAddRow(dtHocKi, "Học Kì 1", "hk1"));
            dtHocKi.Rows.Add(this.dtDiemAddRow(dtHocKi, "Học Kì 2", "hk2"));
            this.cb_hocki.ValueMember = "mahk";
            this.cb_hocki.DisplayMember = "hocki";
            this.cb_hocki.DataSource = dtHocKi;
        }

        private void loadInfoHocSinh()
        {
            DataTable dtInfo = khoiBl.getKhoiLopHocSinh();
            bsKhoi.DataSource = dtInfo;
            this.cb_khoi.ValueMember = "khoiId";
            this.cb_khoi.DisplayMember = "Khoi";
            this.cb_lop.ValueMember = "MaLop";
            this.cb_lop.DisplayMember = "TenLop";
            this.cb_tenhocsinh.ValueMember = "MaHocSinh";
            this.cb_tenhocsinh.DisplayMember = "TenHocSinh";
            this.cb_khoi.DataBindings.Add("SelectedValue", bsKhoi, "khoiId");
            this.cb_khoi.DataSource = dtInfo;
            this.cb_lop.DataBindings.Add("SelectedValue", bsKhoi, "MaLop");
            this.cb_lop.DataSource = dtInfo;
            this.cb_tenhocsinh.DataBindings.Add("SelectedValue", bsKhoi, "MaHocSinh");
            this.cb_tenhocsinh.DataSource = dtInfo;}

        private void FormNhapDiem_Load(object sender, EventArgs e)
        { 
            this.loadHocKi();this.loadMonHoc();
            this.loadInfoHocSinh();
            dtDiem.Columns.Add(new DataColumn("mieng"));
            dtDiem.Columns.Add(new DataColumn("giuaki"));
            dtDiem.Columns.Add(new DataColumn("cuoiki"));
            this.gridControl1.DataSource = dtDiem;}

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (e.Valid)
            {
                this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                int mieng = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, "mieng"));
                int giuaki = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, "giuaki"));
                int cuoiki = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, "cuoiki"));
                var obj = new Diem[]
                {
                    new Diem
                    {
                        diemMieng = mieng,
                        diemGiuaKi = giuaki,
                        diemCuoiKi = cuoiki
                    },
                };
                string json = new JavaScriptSerializer().Serialize(obj);
            }
        }
    }
}
