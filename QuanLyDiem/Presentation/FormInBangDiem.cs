﻿using System;
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
                    OnPropertyChanged("NamHoc");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;

            protected virtual void OnPropertyChanged(string propertyName)
            {
                var handler = PropertyChanged;
                if (handler != null)
                {
                    handler(this, new PropertyChangedEventArgs(propertyName));
                }
                if (this._maHocSinh != null && this._hocKy != null)
                {
                    FrmInstance.gridControl1.DataSource = FrmInstance.diemBl.getDiemFromMaHocSinhAndHocKyNamHoc(this._maHocSinh, this._hocKy, this._namHoc);
                }
            }
        }

        private KhoiBL khoiBl;
        private MonHocBL monHocBl;
        private DiemBL diemBl;
        private static SqlParams sqlParams;

        public FormInBangDiem()
        {
            InitializeComponent();
            monHocBl = new MonHocBL();
            khoiBl = new KhoiBL();
            diemBl = new DiemBL();
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
            DataTable dtInfo = khoiBl.getKhoiLopHocSinh();
            this.cb_khoi.ValueMember = "khoiId";
            this.cb_khoi.DisplayMember = "Khoi";
            this.cb_khoi.DataSource = dtInfo;
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
        private void FormInBangDiem_Load(object sender, EventArgs e)
        {
            sqlParams = new SqlParams(this);
            sqlParams.NamHoc = this.dtp_namhoc.Value;this.loadKhoi();
        }

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                String malop = this.cb_lop.SelectedValue.ToString();
                this.cb_tenhocsinh.DisplayMember = "TenHocSinh";
                this.cb_tenhocsinh.ValueMember = "MaHocSinh";
                this.loadHocKi();this.cb_tenhocsinh.DataSource = khoiBl.getAllHocSinhFromLop(malop);
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

        private void dtp_namhoc_ValueChanged(object sender, EventArgs e)
        {
            sqlParams.NamHoc = this.dtp_namhoc.Value;
        }

        private void cb_tenhocsinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mahs = this.cb_tenhocsinh.SelectedValue.ToString();
            sqlParams.MaHocSinh = mahs;
        }
    }
}