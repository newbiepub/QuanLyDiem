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
    public partial class TimKiemHocSinh : Form
    {
        public TimKiemHocSinh()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
            this.groupBasic.Show();
            this.groupAdvance.Hide();
            studentGrade.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var radButton = ((RadioButton)sender);
            if (radButton.Checked)
            {
                if (radButton.Tag.ToString() == "basic")
                {
                    this.groupAdvance.Hide();
                    this.groupBasic.Show();
                }
                else if (radButton.Tag.ToString() == "advance")
                {
                    this.groupAdvance.Show();
                    this.groupBasic.Hide();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data_Layer.DataAccess da = new Data_Layer.DataAccess();
            if(radioButton1.Checked)
            {

                string query = "select * from HOC_SINH where MaHocSinh=@mahocsinh;";
                SqlParameter [] pr =
                {
                    new SqlParameter("@mahocsinh", txtStudentCodeBasic.Text), 
                };
                dataGridView1.DataSource = da.select(query, pr);
            }
            else
            {
                string theDate = date.Value.ToString("dd/MM/yyyy");
                string query =
                    "select * from HOC_SINH,LOP where HOC_SINH.MaLop=LOP.MaLop and (NgaySinh=@ngaysinh or TenHocSinh=@tenhocsinh or LOP.TenLop=@tenlop or MaHocSinh=@mahocsinh or LOP.khoi=@khoi);";
                SqlParameter[] pr =
                {
                    new SqlParameter("@ngaysinh", theDate),
                    new SqlParameter("@tenhocsinh", studentName.Text),
                    new SqlParameter("@tenlop", studentClass.Text),
                    new SqlParameter("@mahocsinh", studentCodeAdvance.Text),
                    new SqlParameter("@khoi", studentGrade.Text),
                };
                dataGridView1.DataSource = da.select(query, pr);
            }
            if(dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không có học sinh !!");
            }
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(null,null);
            }
        }

      

     
    }
}
