using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.Business_Logic;

namespace QuanLyDiem.Presentation
{
    public partial class FormNhapDiem : Form
    {
        private MonHocBL mongoHocBl;
        public FormNhapDiem()
        {
            InitializeComponent();
            mongoHocBl = new MonHocBL();
        }

        private void FormNhapDiem_Load(object sender, EventArgs e)
        {
            this.cb_monhoc.ValueMember = "mamon";
            this.cb_monhoc.DisplayMember = "tenmon";
            this.cb_monhoc.DataSource = mongoHocBl.getAllMonHoc();}

        private void gridView1_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

        }
    }
}
