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

namespace QuanLyDiem.Presentation
{
    public partial class QuanLyGiaoVien : Form
    {
        DataTable da = new DataTable();
        DataTable lop = new DataTable();
        Int64 ma = 0;
        public QuanLyGiaoVien()
        {
            InitializeComponent();
        }

        private void QuanLyGiaoVien_Load(object sender, EventArgs e)
        {
            // Load Lop
            Business_Logic.LopBL lopBl = new Business_Logic.LopBL();
            lop = lopBl.getLop();
            // load nien khoa
            year.DataSource = lopBl.getNienKhoa();
            year.DisplayMember = "NienKhoa";
            year.Text = "";
            // Load mon hoc
            Business_Logic.MonHocBL monBl = new Business_Logic.MonHocBL();
            subject.DataSource = monBl.getAllMonHoc();
            subject.DisplayMember = "TenMon";
            subject.ValueMember = "MaMon";

            // Load Giao Vien

            da = GiaoVien.getgiaovien();
            dataGridView1.DataSource = da;
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
            dataGridView1.Columns["TenGiaoVien"].HeaderText = "Tên Giáo Viên";
            dataGridView1.Columns["MaGiaoVien"].HeaderText = "Mã Giáo Viên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["MaLop"].HeaderText = "Mã Lớp";
            dataGridView1.Columns["NienKhoa"].HeaderText = "Niên Khóa";
            dataGridView1.Columns["TenLop"].HeaderText = "Tên Lớp";
            dataGridView1.Columns["TenMon"].HeaderText = "Chuyên Môn";
            dataGridView1.Columns["Khoi"].HeaderText = "Khối";
            dataGridView1.Columns["GhiChu1"].HeaderText = "Ghi Chú Lớp";
            dataGridView1.Columns["GioiTinh"].Visible = false;
            dataGridView1.Columns["MaLop1"].Visible = false;
            dataGridView1.Columns["MaMon"].Visible = false;
            dataGridView1.Columns["MaMon1"].Visible = false;
            dataGridView1.Columns["MaGV"].Visible = false;
            dataGridView1.Columns["GhiChu"].HeaderText = "Ghi Chú Giáo Viên";
        }

    

        private void NhapLai(object sender, EventArgs e)
        {
            ma = 0;
            Class.Text = "";
            name.Text = "";
            address.Text = "";
            phone.Text = "";
            subject.Text = "";
            grade.Text = "";
            sexMale.Checked = false;
            sexFemale.Checked = false;
        }

        private void Phone_Press(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
             (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            name.Text = dataGridView1.Rows[rowIndex].Cells["TenGiaoVien"].Value.ToString();
            grade.Text = dataGridView1.Rows[rowIndex].Cells["Khoi"].Value.ToString();
            year.Text = dataGridView1.Rows[rowIndex].Cells["NienKhoa"].Value.ToString();
            grade_SelectedIndexChanged(null, null);
            Class.SelectedText = dataGridView1.Rows[rowIndex].Cells["TenLop"].Value.ToString();
           
            address.Text = dataGridView1.Rows[rowIndex].Cells["DiaChi"].Value.ToString();
            date.Text = dataGridView1.Rows[rowIndex].Cells["NgaySinh"].Value.ToString();
            phone.Text = dataGridView1.Rows[rowIndex].Cells["SoDienThoai"].Value.ToString();
            subject.Text = dataGridView1.Rows[rowIndex].Cells["TenMon"].Value.ToString();
          

            if (dataGridView1.Rows[rowIndex].Cells["GioiTinh"].Value.ToString() == "1")
            {
                sexMale.Checked = true;
            }
            if (dataGridView1.Rows[rowIndex].Cells["GioiTinh"].Value.ToString() == "0")
            {
                sexFemale.Checked = true;
            }
            ma = (Int64)dataGridView1.Rows[rowIndex].Cells["MaGiaoVien"].Value;
        }

        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class();

        }
        private void YearChange(object sender, EventArgs e)
        {
            Load_Class();
        }
        public void Load_Class()
        {
            if (year.Text != "" && grade.Text != "")
            {
                Class.Text = "";
                DataView dv = new DataView(lop);
                dv.RowFilter = "Khoi = " + grade.Text + " and NienKhoa = '" + year.Text + "'";
                Class.DataSource = dv;
                Class.DisplayMember = "TenLop";
                Class.ValueMember = "MaLop";
            }
        }
        private void Them(object sender, EventArgs e)
        {

            if (name.Text == "" || (sexMale.Checked == false && sexFemale.Checked == false) || Class.Text == "" || subject.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ thông tin !!");
            }
            else
            {
                int sex = 0;
                if (sexMale.Checked)
                    sex = 1;
                if (GiaoVien.insertgiaovien(name.Text, date.Value.Date.ToString("yyyy-MM-dd"), sex, Convert.ToInt32(Class.SelectedValue), address.Text, phone.Text, Convert.ToInt32(subject.SelectedValue)) == true)
                {
                    MessageBox.Show("Thêm hoc sinh thành công !!");
                    QuanLyGiaoVien_Load(null, null);
                    NhapLai(null, null);
                }
                else
                    MessageBox.Show("Thêm hoc sinh thất bại!!");

            }
        }
        private void sua(object sender, EventArgs e)
        {
            if (ma != 0)
            {
                int sex = 0;
                if (sexMale.Checked)
                    sex = 1;
                if (GiaoVien.updategiaovien(Convert.ToInt32(ma), name.Text, date.Value.Date.ToString("yyyy-MM-dd"), sex, Convert.ToInt32(Class.SelectedValue), address.Text, phone.Text, Convert.ToInt32(subject.SelectedValue)) == true)
                {
                    MessageBox.Show("Sửa thành công !!");
                }
                else
                    MessageBox.Show("Sửa thất bại !!");
                QuanLyGiaoVien_Load(null, null);
                NhapLai(null, null);

            }
            else
                MessageBox.Show("Bạn phải chọn học sinh cần sửa");
        }
        private void Xoa(object sender, EventArgs e)
        {

            if (ma != 0)
            {
                if (GiaoVien.deletegiaovien(Convert.ToInt32(ma)) == true)
                {
                    MessageBox.Show("Xóa thành công !!");
                }
                else
                    MessageBox.Show("Xóa thất bại !!");
                QuanLyGiaoVien_Load(null, null);
                NhapLai(null, null);

            }
            else
                MessageBox.Show("Bạn phải chọn giáo viên cần xóa");
        }
        private void Thoat(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
