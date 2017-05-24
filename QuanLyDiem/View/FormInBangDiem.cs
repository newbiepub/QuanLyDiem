using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;
using DevExpress.XtraPrinting.Native;
using QuanLyDiem.Business_Logic;
using QuanLyDiem.Controller;

namespace QuanLyDiem.Presentation
{
    public partial class FormInBangDiem : Form
    {

        private class SqlParams : INotifyPropertyChanged
        {

            private static FormInBangDiem FrmInstance;
            public SqlParams()
            {
                
            }

            public SqlParams(FormInBangDiem frmInBangDiem)
            {
                FrmInstance = frmInBangDiem;
            }

            private String _maHocSinh;
            private String _hocKy;
            private DateTime _namHoc;

            public String MaHocSinh
            {
                get { return _maHocSinh; }
                set
                {
                    _maHocSinh = value;
                    OnPropertyChanged("MaHocSinh");
                }
            }

            public String HocKy
            {
                get { return _hocKy; }
                set
                {
                    _hocKy = value;
                    OnPropertyChanged("HocKy");
                }
            }

            public DateTime NamHoc
            {
                get { return _namHoc; }
                set
                {
                    _namHoc = value;
                    OnPropertyChanged("NamHoc");}
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                var handler = PropertyChanged;
                if (handler != null)
                {handler(this, new PropertyChangedEventArgs(propertyName));
                }
                if (this._maHocSinh != null && this._hocKy != null)
                {
                    FrmInstance.gridControl1.DataSource = Diem.getDiemFromMaHocSinhAndHocKyNamHoc(Convert.ToInt32(this._maHocSinh), this._hocKy, this._namHoc);
                }
            }
        }

        private KhoiBL khoiBl;
        private MonHocBL monHocBl;
       
        private static SqlParams sqlParams = new SqlParams();

        public FormInBangDiem()
        {
            InitializeComponent();
            monHocBl = new MonHocBL();
            khoiBl = new KhoiBL();}

        private DataRow dtDiemAddRow(DataTable dtDiem, String hocki, String mahk)
        {
            DataRow dataRow = dtDiem.NewRow();
            dataRow.BeginEdit();
            dataRow["hocki"] = hocki;
            dataRow["mahk"] = mahk;
            dataRow.EndEdit();
            return dataRow;
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

        private void cb_khoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String makhoi = this.cb_khoi.SelectedValue.ToString();
                String namHoc = this.cb_namhoc.SelectedValue.ToString();
                this.cb_lop.ValueMember = "MaLop";
                this.cb_lop.DisplayMember = "TenLop";
                this.cb_lop.DataSource = Lop.getLopByKhoi(Convert.ToInt32(makhoi), namHoc).Rows.Count > 0
                    ? Lop.getLopByKhoi(Convert.ToInt32(makhoi), namHoc): null;
            }
            catch (Exception)
            {
                this.cb_lop.DataSource = null;
                throw;
            }
        }
        private void FormInBangDiem_Load(object sender, EventArgs e)
        {
            this.cb_namhoc.ValueMember = "NienKhoa";
            this.cb_namhoc.DisplayMember = "NienKhoa";
            this.cb_namhoc.DataSource = Lop.getNienKhoa();
            sqlParams = new SqlParams(this);
            sqlParams.NamHoc = new DateTime(Convert.ToInt32(this.cb_namhoc.SelectedValue.ToString()), 1, 1);
            this.loadKhoi();
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String malop = this.cb_lop.SelectedValue.ToString();
                this.cb_tenhocsinh.DisplayMember = "TenHocSinh";
                this.cb_tenhocsinh.ValueMember = "MaHocSinh";
                this.loadHocKi();this.cb_tenhocsinh.DataSource = HocSinh.getAllHocSinhFromLop(malop);
                }
            catch (Exception)
            {
                this.cb_tenhocsinh.DataSource = null;
            }}

        private void cb_hocki_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hocKy = this.cb_hocki.SelectedValue.ToString();
            sqlParams.HocKy = hocKy;
        }

        private void cb_tenhocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahs = this.cb_tenhocsinh.SelectedValue.ToString();
            sqlParams.MaHocSinh = mahs;
        }

        private void cb_namhoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime namHoc = new DateTime(Convert.ToInt32(this.cb_namhoc.SelectedValue), 1, 1);
            sqlParams.NamHoc = namHoc;
        }
    }
}
