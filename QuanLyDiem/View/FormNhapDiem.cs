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
using QuanLyDiem.Controller;
using DataView = DevExpress.DataAccess.Native.Data.DataView;

namespace QuanLyDiem.Presentation
{
    public partial class FormNhapDiem : Form
    {

        private MonHocBL monHocBl;
        private static DataTable dtDiem;
        private static BindingSource bsKhoi;

        public FormNhapDiem()
        {
            InitializeComponent();
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
            this.cb_monhoc.DataSource = MonHoc.getAllMonHoc();
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

        private void loadKhoi()
        {
            DataTable dtInfo = Khoi.getAllKhoi();
            this.cb_khoi.ValueMember = "khoiId";
            this.cb_khoi.DisplayMember = "Khoi";
            this.cb_khoi.DataSource = dtInfo;
        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            this.cb_namhoc.DisplayMember = "NienKhoa";
            this.cb_namhoc.ValueMember = "NienKhoa";
            this.cb_namhoc.DataSource = Lop.getNienKhoa();
            this.loadHocKi();
            this.loadMonHoc();this.loadKhoi();
        }

        private void cb_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String makhoi = this.cb_khoi.SelectedValue.ToString();
                String nienKhoa = this.cb_namhoc.SelectedValue.ToString();
                this.cb_lop.ValueMember = "MaLop";
                this.cb_lop.DisplayMember = "TenLop";
                this.cb_lop.DataSource = Lop.getLopByKhoi(Convert.ToInt32(makhoi), nienKhoa).Rows.Count > 0
                    ? Lop.getLopByKhoi(Convert.ToInt32(makhoi), nienKhoa)
                    : null;}
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
                this.loadCotDiem();}

        }

        private void loadCotDiem()
        {
            try
            {
                String mahk = this.cb_hocki.SelectedValue.ToString();
                int mahocsinh = Convert.ToInt32(this.cb_tenhocsinh.SelectedValue.ToString());
                int mamon = Convert.ToInt32(this.cb_monhoc.SelectedValue.ToString());
                DateTime namHoc = new DateTime(Convert.ToInt32(this.cb_namhoc.SelectedValue.ToString()), 1, 1);
                dtDiem = Diem.getDiemFromMahsAndMaMon(mahocsinh, mamon, mahk, namHoc);
                if (dtDiem.Rows.Count > 0)
                {
                    foreach (DataRow rowData in dtDiem.Rows)
                    {
                        this.cb_namhoc.SelectedValue = Convert.ToDateTime(rowData["NamHoc"]).Year;
                    }
                    this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.None;
                    this.gridControl1.DataSource = dtDiem;
                }
                else
                {
                    dtDiem = new DataTable();
                    dtDiem.Columns.Add(new DataColumn("DiemMieng"));
                    dtDiem.Columns.Add(new DataColumn("DiemGiuaKy"));
                    dtDiem.Columns.Add(new DataColumn("DiemHocKy"));
                    this.gridView1.OptionsView.NewItemRowPosition = NewItemRowPosition.Top;
                    this.gridControl1.DataSource = dtDiem;
                }
            }
            catch (Exception error)
            {
                Console.Write(error);
                this.gridControl1.DataSource = null;}
        }
        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String malop = this.cb_lop.SelectedValue.ToString();
                this.cb_tenhocsinh.DisplayMember = "TenHocSinh";
                this.cb_tenhocsinh.ValueMember = "MaHocSinh";
                this.cb_tenhocsinh.DataSource = HocSinh.getAllHocSinhFromLop(malop);
            }
            catch (Exception)
            {
                this.cb_tenhocsinh.DataSource = null;
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
            GridColumn DiemCuoiKy = view.Columns["DiemHocKy"];int mieng = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, DiemMieng));
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
        {int mieng = Convert.ToInt32(this.gridView1.GetRowCellValue(0, "DiemMieng"));
            int giuaki = Convert.ToInt32(this.gridView1.GetRowCellValue(0, "DiemGiuaKy"));
            int cuoiki = Convert.ToInt32(this.gridView1.GetRowCellValue(0, "DiemHocKy"));
            string mahocsinh = this.cb_tenhocsinh.SelectedValue.ToString();
            string MaMon = this.cb_monhoc.SelectedValue.ToString();
            string hocki = this.cb_hocki.SelectedValue.ToString();
            DateTime namhoc = new DateTime(Convert.ToInt32(this.cb_namhoc.SelectedValue.ToString()), 1, 1);
            bool isInsert = Diem.insertDiem(Convert.ToInt32(mahocsinh), Convert.ToInt32(MaMon), mieng, giuaki,
                cuoiki, hocki, namhoc, "");
            if (isInsert)
            {
                MessageBox.Show("Đã Nhập");
            }
            else
            {
                MessageBox.Show("Nhập Thất Bại");
            }
        }

        private void gridView1_InvalidRowException(object sender,
            DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void cb_hocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.loadCotDiem();
            }
            catch (Exception)
            {
                this.gridControl1.DataSource = null;
            }}

        private void cb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.loadCotDiem();}
    }
}
