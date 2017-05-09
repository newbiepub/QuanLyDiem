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

                string query = "SELECT * FROM HOC_SINH WHERE MaHocSinh ='" + txtStudentCodeBasic.Text + "';";
                dataGridView1.DataSource = da.select(query);
            }
            else
            {
                string theDate = date.Value.ToString("dd/MM/yyyy");
                string query = "SELECT * FROM HOC_SINH,LOP WHERE HOC_SINH.MaLop = LOP.Malop and (NgaySinh ='" + theDate + "' or TenHocSinh ='" + studentName.Text + "' or LOP.TenLop ='" + studentClass.Text + "' or MaHocSinh ='" + studentCodeAdvance.Text + "' or LOP.khoi = '"+studentGrade.Text+"') ;";
                dataGridView1.DataSource = da.select(query);
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
