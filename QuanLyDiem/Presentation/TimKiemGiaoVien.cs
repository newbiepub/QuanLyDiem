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
    public partial class TimKiemGiaoVien : Form
    {
        public TimKiemGiaoVien()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
            this.groupBoxAdvance.Hide();
            this.groupBoxBasic.Show();
        }
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
            }
        }

        private void Find_Click(object sender, EventArgs e)
        {
            string query = "";
            if (radioButton1.Checked)
            {

                query = "select MaGiaoVien,TenGiaoVien,NgaySinh,GioiTinh,LOP.MaLop,TenMon,TenLop,Khoi,SoDienThoai,DiaChi from DAY,GIAO_VIEN,LOP,MON_HOC where LOP.MaLop = DAY.MaLop and MaGiaoVien = MaGV and MON_HOC.MaMon = DAY.MaMon and MaGiaoVien=@magiaovien;";
                SqlParameter[] pr =
                {
                    new SqlParameter("@magiaovien", teacherCodeBasic.Value), 
                };
                dataGridView1.DataSource = da.select(query, pr);
            }
            else
            {

                //querry ten
                string TenGiaoVien = "";
                if (teacherName.Text != "")
                {
                    TenGiaoVien = "and TenGiaoVien=@tengiaovien";
                }
                //querry ma
                string MaGiaoVien = "";
                if (teacherCodeAdvance.Value != 0)
                {
                    MaGiaoVien = "and MaGiaoVien=@MaGiaoVien";
                }
                //querry mon
                string mon = "";
                if (subjectSpecialize.Text != "Không")
                {
                    mon = "and TenMon=@tenmonhoc";
                }
                //querry Lop
                string lop = "";
                if (teacherClass.Text != "Không")
                {
                    lop = "and LOP.TenLop=@tenlop";
                }
               
                query =
                    "select MaGiaoVien,TenGiaoVien,NgaySinh,GioiTinh,LOP.MaLop,TenMon,TenLop,Khoi,SoDienThoai,DiaChi from DAY,GIAO_VIEN,LOP,MON_HOC where LOP.MaLop = DAY.MaLop and MaGiaoVien = MaGV and MON_HOC.MaMon = DAY.MaMon" + mon + " " + lop + " " + TenGiaoVien + " " + MaGiaoVien + "";
                SqlParameter[] pr =
                {
        
                    new SqlParameter("@tengiaovien", teacherName.Text),
                    new SqlParameter("@tenlop", teacherClass.Text),
                    new SqlParameter("@MaGiaoVien", teacherCodeAdvance.Text),
                    new SqlParameter("@tenmonhoc",subjectSpecialize.Text),
                };
                dataGridView1.DataSource = da.select(query, pr);
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
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không có giáo viên !!!");
            }
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            // Startup load Supject
            string query = "select TenMon from MON_HOC";
            SqlParameter[] pr = { };
            DataTable data = da.select(query, pr);
            data.Rows.Add("Không");
            subjectSpecialize.DataSource = data;
            subjectSpecialize.DisplayMember = "TenMon";
            subjectSpecialize.Text = "Không";
            // Startup load class
            query = "select TenLop from LOP";
            data = da.select(query, pr);
            data.Rows.Add("Không");
            teacherClass.DataSource = data;
            teacherClass.DisplayMember = "TenLop";
            teacherClass.Text = "Không";
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
            teacherCodeAdvance.Value = 0;
            teacherCodeBasic.Value = 0;
            subjectSpecialize.Text = "Không";
        }
    }
}
