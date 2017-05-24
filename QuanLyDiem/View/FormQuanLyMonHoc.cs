using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.Controller;

namespace QuanLyDiem.View
{
    public partial class FormQuanLyMonHoc : Form
    {
        public FormQuanLyMonHoc()
        {
            InitializeComponent();
        }

        private void FormQuanLyMonHoc_Load(object sender, EventArgs e)
        {
            this.gridControl1.DataSource = MonHoc.getAllMonHoc();
        }

        private void resetAll()
        {
            this.txt_mamon.Text = "";
            this.txt_tenmon.Text = "";
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string tenmon = this.txt_tenmon.Text;
            bool isInserted = MonHoc.insertMonHoc(tenmon);
            if (isInserted)
            {
                MessageBox.Show("Đã Thêm");
                this.gridControl1.DataSource = MonHoc.getAllMonHoc();
                this.resetAll();
            }
            else
            {
                MessageBox.Show("Thêm Thất Bại");
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            int mamon = Convert.ToInt32(this.gridView1.GetRowCellValue(e.RowHandle, "MaMon").ToString());
            string tenmon = this.gridView1.GetRowCellValue(e.RowHandle, "TenMon").ToString();
            this.txt_mamon.Text = mamon.ToString();
            this.txt_tenmon.Text = tenmon;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                int mamon = Convert.ToInt32(this.txt_mamon.Text);
                string tenmon = this.txt_tenmon.Text;
                bool isUpdate = MonHoc.updateMonHoc(mamon, tenmon);
                if (isUpdate)
                {
                    MessageBox.Show("Đã Cập Nhật");
                    this.gridControl1.DataSource = MonHoc.getAllMonHoc();
                    this.resetAll();
                }
                else
                {
                    MessageBox.Show("Thất Bại");
                }
            }
            catch (Exception errorException)
            {
                MessageBox.Show(errorException.Message);
                throw;}
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int mamon = Convert.ToInt32(this.txt_mamon.Text);
                DialogResult result = MessageBox.Show("Bạn Có Muốn Xóa Môn Học", "Thông Báo", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    bool isDeleted = MonHoc.deleteMonHoc(mamon);
                    if (isDeleted)
                    {
                        MessageBox.Show("Đã Xóa");
                        this.gridControl1.DataSource = MonHoc.getAllMonHoc();
                        this.resetAll();}
                    else
                    {
                        MessageBox.Show("Thất Bại");
                    }    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
