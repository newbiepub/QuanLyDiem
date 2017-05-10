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

namespace QuanLyDiem.Presentation
{
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
        public FormNhapDiem()
        {
            InitializeComponent();
            mongoHocBl = new MonHocBL();
            dtDiem = new DataTable();
        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        { 

            this.cb_monhoc.ValueMember = "mamon";
            this.cb_monhoc.DisplayMember = "tenmon";
            this.cb_monhoc.DataSource = mongoHocBl.getAllMonHoc();
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
                        diemGiuaKi = giuaki,diemCuoiKi = cuoiki
                    },
                };
                string json = new JavaScriptSerializer().Serialize(obj);
                MessageBox.Show(json, "Serialized");
            }
        }
    }
}
