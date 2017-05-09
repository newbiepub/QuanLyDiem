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
    public partial class TimKiemGiaoVien : Form
    {
        public TimKiemGiaoVien()
        {
            InitializeComponent();
            this.radioButton1.Checked = true;
            this.groupBoxAdvance.Hide();
            this.groupBoxBasic.Show();
            subjectSpecialized.DropDownStyle = ComboBoxStyle.DropDownList;
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
                ResetValue_Click(null,null);
            }
        }

        private void TimKiemGiaoVien_Load(object sender, EventArgs e)
        {
            // Query Chuyên Môn
            string query = "select TenMon from MON_HOC";
            DataTable _dt = da.select(query);
            _dt.Rows.Add("Không");
            subjectSpecialized.DataSource = _dt;
            subjectSpecialized.DisplayMember = "TenMon";
           // Query Lớp
            query = "select TenLop from LOP";
            _dt = da.select(query);
            _dt.Rows.Add("Không");
            teacherClass.DataSource = _dt;
            teacherClass.DisplayMember = "TenLop";
           
        }

        private void ResetValue_Click(object sender, EventArgs e)
        {
            teacherClass.Text = "Không";
            teacherName.Text = "";
            teacherCodeBasic.Value = 0;
            teacherCodeAvanced.Value = 0;
            subjectSpecialized.Text = "Không";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            // Check textbox is null
            // TenGiaoVien
            string tenGiaoVien = "";

            if (teacherName.Text != "")
            {
                tenGiaoVien = "and TenGiaoVien ='" + teacherName.Text + "'";
            }
            // MaGiaoVien
            string maGiaoVien = "";

            if (teacherCodeAvanced.Text != "0")
            {
                maGiaoVien = "and MaGiaoVien ='" + teacherCodeAvanced.Text + "'";
            }
           
            // Lop
            string tenLop = "";

            if (teacherClass.Text != "Không")
            {
                tenLop = "and TenLop ='" + teacherClass.Text + "'";
            }
            // ChuyenMon
            string chuyenMon = "";

            if (subjectSpecialized.Text != "Không")
            {
                chuyenMon = "and TenMon = '" + subjectSpecialized.Text + "'";
            }
            string query = "";
            if (radioButton1.Checked)
            {

                query = "select MaGiaoVien,TenGiaoVien,MON_HOC.MaMon,TenMon,TenLop,NgaySinh,GioiTinh,SoDienThoai,DiaChi,LOP.GhiChu from MON_HOC,GIAO_VIEN,DAY, LOP where MON_HOC.MaMon = DAY.MaMon and GIAO_VIEN.MaGiaoVien = DAY.MaGV and LOP.MaLop = DAY.MaLop and MaGiaoVien ='" + teacherCodeBasic.Value + "';";
            }
            else
            {

                query = "select MaGiaoVien,TenGiaoVien,MON_HOC.MaMon,TenMon,TenLop,NgaySinh,GioiTinh,SoDienThoai,DiaChi,LOP.GhiChu from MON_HOC,GIAO_VIEN,DAY, LOP where MON_HOC.MaMon = DAY.MaMon and GIAO_VIEN.MaGiaoVien = DAY.MaGV and LOP.MaLop = DAY.MaLop " + tenGiaoVien + " " + chuyenMon + " " + maGiaoVien + " " + tenLop + " ;";

            }
            dataGridView1.DataSource = da.select(query);
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không có Giáo Viên !!");
            }
        }
    }
}
