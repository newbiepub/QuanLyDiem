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
        Business_Logic.TimKiemBL timKiemBL = new Business_Logic.TimKiemBL();
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

        private void Find(object sender, EventArgs e)
        {
            string query = "";
            if(radioButton1.Checked)
            {
                dataGridView1.DataSource =timKiemBL.FindStudentByID((Int32)txtStudentCodeBasic.Value);
            }
            else
            {
               
               
                dataGridView1.DataSource =timKiemBL.FindStudentAdvance((Int32)studentCodeAdvance.Value, (Int32)year.Value,studentName.Text,studentClass.Text, studentGrade.Text);
            }


            dataGridView1.Columns["MaHocSinh"].HeaderText = "Mã Hoc Sinh";
            dataGridView1.Columns["TenHocSinh"].HeaderText = "Tên Học Sinh";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView1.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["Khoi"].HeaderText = "Khối";
            dataGridView1.Columns["GhiChu"].HeaderText = "Ghi Chú";
            if(dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không có hoc sinh !!!");
            }
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Find(null,null);
            }
        }

        private void Reset(object sender, EventArgs e)
        {
            year.Value = 0;
            studentName.Text = "";
            studentGrade.Text = "Không";
            studentCodeAdvance.Value = 0;
            txtStudentCodeBasic.Value = 0;
            studentClass.Text = "Không";

        }

        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {
            Business_Logic.LopBL lopBl = new Business_Logic.LopBL();
            DataTable dataClass = lopBl.getLop();
            dataClass.Rows.Add("Không");
            studentClass.DataSource = dataClass;
            studentClass.DisplayMember = "TenLop";
            studentClass.Text = "Không";
            
        }


     
    }
}
