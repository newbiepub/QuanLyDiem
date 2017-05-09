using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.Presentation
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            this.txt_tendangnhap.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_matkhau.Text == "admin" & txt_tendangnhap.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !!!");
            }
        }

    
        private void txt_matkhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null,null);
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            txt_matkhau.PasswordChar = '\0';
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            txt_matkhau.PasswordChar = '*';
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.button2, "Hiển thị mật khẩu");
          
        }
    }
}
