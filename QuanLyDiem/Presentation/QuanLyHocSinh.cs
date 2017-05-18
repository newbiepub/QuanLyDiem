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
    public partial class QuanLyHocSinh : Form
    {

        Business_Logic.HocSinhBL hocSinhBl = new Business_Logic.HocSinhBL();
        DataTable da = new DataTable();
        DataTable lop = new DataTable();
        Int64 maHocSinh = 0;
       
        public QuanLyHocSinh()
        {
            InitializeComponent();
            
        }
        
        private void QuanLyHocSinh_Load(object sender, EventArgs e)
        {
            
            // Load Hoc sinh 
            da = hocSinhBl.gethocsinh();
            dataGridView1.DataSource = da;
            // Load Lop
            Business_Logic.LopBL lopBl = new Business_Logic.LopBL();
            lop = lopBl.getLop();
            // load nien khoa
            year.DataSource = lopBl.getNienKhoa();
            year.DisplayMember = "NienKhoa";
            year.Text = "";
            // edit column datagridview
            if (dataGridView1.Columns.Contains("newGioiTinh"))
            { }
            else 
            {
                var column = new DataGridViewTextBoxColumn();
                column.ValueType = typeof(string);
                column.HeaderText = "Giới Tính";
                column.Name = "newGioiTinh";
                dataGridView1.Columns.Insert(2, column);
            }
           

            for (int row = 0; row < dataGridView1.RowCount - 1; row++)
                {
                    if (dataGridView1.Rows[row].Cells["GioiTinh"].Value.ToString() == "1")
                        dataGridView1.Rows[row].Cells["newGioiTinh"].Value = "Nam";
                    if (dataGridView1.Rows[row].Cells["GioiTinh"].Value.ToString() == "0")
                        dataGridView1.Rows[row].Cells["newGioiTinh"].Value = "Nữ";

                }
            dataGridView1.Columns["TenHocSinh"].HeaderText = "Tên Hoc Sinh";
            dataGridView1.Columns["MaHocSinh"].HeaderText = "Mã Học Sinh";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView1.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridView1.Columns["Khoi"].HeaderText = "Khối";
            dataGridView1.Columns["NienKhoa"].HeaderText = "Niên Khóa";
            dataGridView1.Columns["GhiChu"].HeaderText = "Ghi Chú";
            dataGridView1.Columns["DiemTrungBinh"].HeaderText = "Điểm Trung Bình";
            dataGridView1.Columns["XepLoai"].HeaderText = "Xếp Loại";
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["MaLop1"].Visible = false;
            
        }
    
        
        public void Load_Class()
        {
            if (year.Text != "" && studentGrade.Text != "")
            {
                studentClass.Text = "";
                DataView dv = new DataView(lop);
                dv.RowFilter = "Khoi = " + studentGrade.Text + " and NienKhoa = '" + year.Text + "'";
                studentClass.DataSource = dv;
                studentClass.DisplayMember = "TenLop";
                studentClass.ValueMember = "MaLop";
            }
        }
        private void studentGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class();
        }
        private void year_change(object sender, EventArgs e)
        {
            Load_Class();
        }
        private void NhapLai(object sender, EventArgs e)
        {
            maHocSinh = 0;
            studentClass.Text = "";
            studentGrade.Text = "";
            studentAddress.Text = "";
            studentName.Text = "";
            sexMale.Checked = false;
            sexFemale.Checked = false;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            int rowIndex = e.RowIndex;
            studentName.Text = dataGridView1.Rows[rowIndex].Cells["TenHocSinh"].Value.ToString();
            studentGrade.Text = dataGridView1.Rows[rowIndex].Cells["Khoi"].Value.ToString();
            year.Text = dataGridView1.Rows[rowIndex].Cells["NienKhoa"].Value.ToString();
            Load_Class();
            studentClass.Text = dataGridView1.Rows[rowIndex].Cells["TenLop"].Value.ToString();
            
            studentAddress.Text = dataGridView1.Rows[rowIndex].Cells["DiaChi"].Value.ToString();
            studentDate.Text = dataGridView1.Rows[rowIndex].Cells["NgaySinh"].Value.ToString();
            if( dataGridView1.Rows[rowIndex].Cells["GioiTinh"].Value.ToString() == "1")
            {
                sexMale.Checked = true;
            }
            if (dataGridView1.Rows[rowIndex].Cells["GioiTinh"].Value.ToString() == "0")
            {
                sexFemale.Checked = true;
            }
            maHocSinh = (Int64)dataGridView1.Rows[rowIndex].Cells["MaHocSinh"].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (studentName.Text == "" || (sexMale.Checked == false && sexFemale.Checked == false) || studentClass.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !!");
            }
            else
            {
                int sex = 0;
                if (sexMale.Checked)
                    sex = 1;
                if (hocSinhBl.inserthocsinh(studentName.Text, studentDate.Value.Date.ToString("yyyy-MM-dd"), sex, Convert.ToInt32(studentClass.SelectedValue), studentAddress.Text) == true)
                {
                    MessageBox.Show("Thêm hoc sinh thành công !!");
                    QuanLyHocSinh_Load(null, null);
                    NhapLai(null, null);
                }
                else
                    MessageBox.Show("Thêm hoc sinh thất bại!!");

            }

        }
        private void Xoa(object sender, EventArgs e)
        {
            if(maHocSinh != 0)
            {
                if (hocSinhBl.deletehocsinh(maHocSinh) == true)
                {
                    MessageBox.Show("Xóa thành công !!");
                }
                else
                    MessageBox.Show("Xóa thất bại !!");
                QuanLyHocSinh_Load(null, null);
                NhapLai(null, null);
                
            }else
            MessageBox.Show("Bạn phải chọn học sinh cần xóa");
        }

        private void Sua(object sender, EventArgs e)
        {
            if (maHocSinh != 0)
            {
                int sex = 0;
                if (sexMale.Checked)
                    sex = 1;
                if (hocSinhBl.updatehocsinh(maHocSinh, studentName.Text, studentDate.Value.Date.ToString("yyyy-MM-dd"), sex, Convert.ToInt32(studentClass.SelectedValue), studentAddress.Text) == true)
                {
                    MessageBox.Show("Sửa thành công !!");
                }
                else
                    MessageBox.Show("Sửa thất bại !!");
                QuanLyHocSinh_Load(null, null);
                NhapLai(null, null);

            }
            else
                MessageBox.Show("Bạn phải chọn học sinh cần sửa");
        }

        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }

        

      
             
    }
}
