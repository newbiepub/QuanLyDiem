using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using QuanLyDiem.Presentation;
using QuanLyDiem.View;

namespace QuanLyDiem
{
    public partial class QuanLyDiemForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public QuanLyDiemForm()
        {
            InitializeComponent();
        }

       

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyHocSinh formQuanLyHocSinh = new QuanLyHocSinh();
            formQuanLyHocSinh.Show(this);
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            QuanLyGiaoVien formGiaoVien = new QuanLyGiaoVien();
            formGiaoVien.Show(this);
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form_QuanLyLop formQuanLyLop = new Form_QuanLyLop();
            formQuanLyLop.Show(this);
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormQuanLyMonHoc frmMonHoc = new FormQuanLyMonHoc();
            frmMonHoc.Show(this);
        }

        private void h_ItemClick(object sender, ItemClickEventArgs e)
        {
            FormNhapDiem formNhapDiem = new FormNhapDiem();
            formNhapDiem.Show(this);
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimKiemHocSinh formTimKiemHocSinh = new TimKiemHocSinh();
            formTimKiemHocSinh.Show(this);
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            TimKiemGiaoVien formTimKiemGiaoVien = new TimKiemGiaoVien();
            formTimKiemGiaoVien.Show(this);
        }

        private void QuanLyDiemForm_Load(object sender, EventArgs e)
        {
            FormDangNhap dn = new FormDangNhap();
            if (dn.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}