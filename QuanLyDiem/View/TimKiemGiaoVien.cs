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
using QuanLyDiem.Controller;

namespace QuanLyDiem.Presentation
{
    public partial class TimKiemGiaoVien : Form
    {
        public TimKiemGiaoVien()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
            this.groupBoxAdvance.Hide();
            this.groupBoxBasic.Show();
        }
        DataTable lop;
        Data_Layer.DataAccess da = new Data_Layer.DataAccess();
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var radioButton = ((RadioButton) sender);
            if (radioButton.Checked && radioButton.Tag.ToString() == "basic")
            {
                this.groupBoxBasic.Show();
                this.groupBoxAdvance.Hide();
            }
            else if (radioButton.Checked && radioButton.Tag.ToString() == "advance")
            {
                this.groupBoxBasic.Hide();
                this.groupBoxAdvance.Show();
                Reset_Click(null, null);
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                dataGridView1.DataSource = GiaoVien.FindTeacherByID((Int32)teacherCodeBasic.Value);
            }
            else
            {

                dataGridView1.DataSource = GiaoVien.FindTeacherAdvance((Int32)teacherCodeAdvance.Value, subjectSpecialize.Text, teacherName.Text,Convert.ToInt32(teacherClass.SelectedValue),teacherClass.Text);
            }


            dataGridView1.Columns["MaGiaoVien"].HeaderText = "Mã Giáo Viên";
            dataGridView1.Columns["TenGiaoVien"].HeaderText = "Tên Giáo Viên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView1.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            dataGridView1.Columns["TenMon"].HeaderText = "Tên Môn";
            dataGridView1.Columns["Khoi"].HeaderText = "Khối";
            dataGridView1.Columns["NienKhoa"].HeaderText = "Niên Khóa";
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không có giáo viên !!!");
            }
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            // Startup load Supject
            Business_Logic.MonHocBL monHoc = new Business_Logic.MonHocBL();
            DataTable data = monHoc.getAllMonHoc();
            data.Rows.Add(0,"Không");
            subjectSpecialize.DataSource = data;
            subjectSpecialize.DisplayMember = "TenMon";
            subjectSpecialize.Text = "Không";
            // Load Lop
            Business_Logic.LopBL lopBl = new Business_Logic.LopBL();
            lop = lopBl.getLop();
            // load nien khoa
            year.DataSource = lopBl.getNienKhoa();
            year.DisplayMember = "NienKhoa";
            year.Text = "";
        }
        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Find_Click(null, null);
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
       
            teacherName.Text = "";
            teacherClass.Text = "Không";
            grade.Text = "Không";
            teacherCodeAdvance.Value = 0;
            teacherCodeBasic.Value = 0;
            subjectSpecialize.Text = "Không";
        }

        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class();
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class();
        }
        public void Load_Class()
        {
            if (year.Text != "" && (grade.Text != "Không" && grade.Text != ""))
            {
                teacherClass.Text = "";
                DataView dv = new DataView(lop);
                dv.RowFilter = "Khoi = "+grade.Text+" and NienKhoa = '" + year.Text + "'";
                teacherClass.DataSource = dv;
                teacherClass.DisplayMember = "TenLop";
                teacherClass.ValueMember = "MaLop";

            }
            else
            {
                teacherClass.DataSource = null;
                teacherClass.Text = "Không";
            }
        }
    }
}
