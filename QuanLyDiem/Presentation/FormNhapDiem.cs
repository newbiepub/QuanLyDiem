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
using DevExpress.Xpo.Helpers;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using Json;
using QuanLyDiem.Business_Logic;
using DataView = DevExpress.DataAccess.Native.Data.DataView;

namespace QuanLyDiem.Presentation
{
    public partial class FormNhapDiem : Form
    {

        private class Diem
        {
            public int diemMieng { get; set; }
            public int diemGiuaKi { get; set; }
            public int diemCuoiKi { get; set; }

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

        private MonHocBL monHocBl;
        private static DataTable dtDiem;
        private KhoiBL khoiBl;
        private static BindingSource bsKhoi;

        public FormNhapDiem()
        {
            InitializeComponent();
            monHocBl = new MonHocBL();
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
            this.cb_monhoc.ValueMember = "MaMon";
            this.cb_monhoc.DisplayMember = "TenMon";
            this.cb_monhoc.DataSource = monHocBl.getAllMonHoc();
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
            this.cb_khoi.ValueMember = "khoiId";
            this.cb_khoi.DisplayMember = "Khoi";
            this.cb_khoi.DataSource = dtInfo;
        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            this.loadHocKi();
            this.loadMonHoc();
            this.loadInfoHocSinh();
            this.dtp_namhoc.Format = DateTimePickerFormat.Custom;
            this.dtp_namhoc.CustomFormat = "yyyy";
            this.dtp_namhoc.ShowUpDown = true;
        }

        private void cb_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String makhoi = this.cb_khoi.SelectedValue.ToString();
                this.cb_lop.ValueMember = "MaLop";
                this.cb_lop.DisplayMember = "TenLop";
                this.cb_lop.DataSource = khoiBl.getAllLopFromKhoi(makhoi).Rows.Count > 0
                    ? khoiBl.getAllLopFromKhoi(makhoi)
                    : null;
            }
            catch (Exception)
            {
                this.cb_lop.DataSource = null;
                throw;
            }
        }

        private void cb_tenhocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_monhoc.SelectedValue != null)
            {
                this.loadCotDiem();
            }
        }

        private void cb_monhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_tenhocsinh.SelectedValue != null)
            {
                String mamon = this.cb_monhoc.SelectedValue.ToString();
            }

        }

        private void loadCotDiem()
        {
            try
            {
                String mahocsinh = this.cb_tenhocsinh.SelectedValue.ToString();
                String mamon = this.cb_monhoc.SelectedValue.ToString();
                dtDiem = monHocBl.getDiemFromMahsAndMaMon(mahocsinh, mamon);
                if (dtDiem.Rows.Count > 0)
                {
                    this.gridControl1.DataSource = dtDiem;
                }
                else
                {
                    dtDiem = new DataTable();
                    dtDiem.Columns.Add(new DataColumn("DiemMieng"));
                    dtDiem.Columns.Add(new DataColumn("DiemGiuaKy"));
                    dtDiem.Columns.Add(new DataColumn("DiemCuoiKy"));
                    this.gridControl1.DataSource = dtDiem;
                }
            }catch (Exception error)
            {
                Console.Write(error);
                throw;
            }
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String malop = this.cb_lop.SelectedValue.ToString();
                this.cb_tenhocsinh.DisplayMember = "TenHocSinh";
                this.cb_tenhocsinh.ValueMember = "MaHocSinh";
                this.cb_tenhocsinh.DataSource = khoiBl.getAllHocSinhFromLop(malop);
            }
            catch (Exception)
            {
                this.cb_tenhocsinh.DataSource = null;
                throw;
            }
        }
        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {
            if (dtDiem.Rows.Count > 0)
            {
                this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            }
            else
            {
                if (e.Valid)
                {
                    this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                }
                else
                {
                    return;
                }
            }

            GridView view = sender as GridView;
            GridColumn DiemMieng = view.Columns["DiemMieng"];
            GridColumn DiemGiuaKy = view.Columns["DiemGiuaKy"];
            GridColumn DiemCuoiKy = view.Columns["DiemCuoiKy"];int mieng = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, DiemMieng));
            int giuaki = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, DiemGiuaKy));
            int cuoiki = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, DiemCuoiKy));
            if (mieng > 10 || mieng < 0)
            {
                e.Valid = false;
                view.SetColumnError(DiemMieng, "Điểm Miệng Không Hợp Lệ");
            }
            else if (giuaki > 10 || giuaki < 0)
            {
                e.Valid = false;
                view.SetColumnError(DiemGiuaKy, "Điểm Giữa Kỳ Không Hợp Lệ");
            }
            else if (cuoiki > 10 || cuoiki < 0)
            {
                e.Valid = false;
                view.SetColumnError(DiemCuoiKy, "Điểm Cuối Kỳ Không Hợp Lệ");
            }
            else
            {
                e.Valid = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            int mieng = Convert.ToInt32(this.gridView1.GetRowCellValue(0, "DiemMieng"));
            int giuaki = Convert.ToInt32(this.gridView1.GetRowCellValue(0, "DiemGiuaKy"));
            int cuoiki = Convert.ToInt32(this.gridView1.GetRowCellValue(0, "DiemCuoiKy"));
            string mahocsinh = this.cb_tenhocsinh.SelectedValue.ToString();
            string MaMon = this.cb_monhoc.SelectedValue.ToString();
            string hocki = this.cb_hocki.SelectedValue.ToString();
            DateTime namhoc = this.dtp_namhoc.Value;
            bool isInsert = monHocBl.insertDiem(Convert.ToInt32(mahocsinh), Convert.ToInt32(MaMon), mieng, giuaki,
                cuoiki, hocki, namhoc, "");
            if (isInsert)
            {
                MessageBox.Show("Inserted");
            }
            else
            {
                MessageBox.Show("Failed");
            }
        }

        private void gridView1_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
