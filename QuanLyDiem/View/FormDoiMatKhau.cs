using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDiem.Presentation
{
    public partial class FormDoiMatKhau : Form
    {
        public FormDoiMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtpasscu.Text == "") MessageBox.Show("chưa nhập mật khẩu cũ");
            else if (txtpassmoi.Text == "") MessageBox.Show("chưa nhập mật khẩu mới");
            else if (txtxacminh.Text == "") MessageBox.Show("chưa nhập lại mật khẩu");
            else if (txtpassmoi.Text != txtxacminh.Text) MessageBox.Show("mật khẩu không trùng khớp");
           // else if (txtpasscu.Text != Program.password) MessageBox.Show("mật khẩu cũ không đúng");
            else
            {
                SqlCommand doipass = new SqlCommand();
                doipass.Connection = Program.conn;
                doipass.CommandType = CommandType.Text;
                doipass.CommandText = "'exec sp_password'" + txtpasscu.Text + "','" + txtpassmoi.Text + "','" + Program.mlogin + "'";
               // doipass.ExecuteNonQuery();
                MessageBox.Show("Đổi mật khẩu thành công");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
