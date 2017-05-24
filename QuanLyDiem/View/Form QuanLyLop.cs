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
    public partial class Form_QuanLyLop : Form
    {
        public Form_QuanLyLop()
        {
            InitializeComponent();
        }
         DataTable lop = new DataTable();
       
        private void Form_QuanLyLop_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbDataSet.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dbDataSet.LOP);
            // Load Lop
            Business_Logic.LopBL lopBl = new Business_Logic.LopBL();
            lop = lopBl.getLop();
            // load nien khoa
            year.DataSource = lopBl.getNienKhoa();
            year.DisplayMember = "NienKhoa";
            
            
            //config grid Class
            gridviewClass.Columns["MaLop"].HeaderText = "Mã Lớp";
            gridviewClass.Columns["MaLop"].DefaultCellStyle.BackColor = Color.Silver;
            gridviewClass.Columns["MaLop"].Width = 40;
            gridviewClass.Columns["GhiChu"].HeaderText = "Ghi Chú";
            gridviewClass.Columns["Khoi"].HeaderText = "Khối";
            gridviewClass.Columns["Khoi"].Width = 40;
            gridviewClass.Columns["TenLop"].HeaderText = "Tên Lớp";
            gridviewClass.Columns["TenLop"].Width = 40;
            gridviewClass.Columns["NienKhoa"].HeaderText = "Niên Khóa";
            gridviewClass.Columns["NienKhoa"].Width = 40;
            gridviewClass.Columns["MaLop"].ReadOnly = true;
            //gridviewClass.Columns["MaLop"].CellType= ;
        }
        public void Load_Class()
        {
            if (year.Text != "" && grade.Text != "")
            {
                try
                {
                    DataView dv = new DataView(lop);
                    dv.RowFilter = "Khoi = " + grade.Text + " and NienKhoa = '" + year.Text + "'";
                    gridviewClass.DataSource = dv;
                }
                catch (ArgumentNullException e)
                {
                    MessageBox.Show("Không có Lớp");
                }
                           
            }
            else gridviewClass.DataSource = lop;
        }
        private void gridviewClass_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            gridviewTeacher.DataSource = GiaoVien.getgiaovienwithlop(Convert.ToInt32(gridviewClass.Rows[rowIndex].Cells["MaLop"].Value));
            gridviewStudent.DataSource = HocSinh.gethocsinhwithlop(Convert.ToInt32( gridviewClass.Rows[rowIndex].Cells["MaLop"].Value));
            //config grid Teacher
            gridviewTeacher.AutoResizeColumns();
            gridviewTeacher.Columns["MaGiaoVien"].HeaderText = "Mã Giáo Viên";
            gridviewTeacher.Columns["TenGiaoVien"].HeaderText = "Tên Giáo Viên";
            gridviewTeacher.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            gridviewTeacher.Columns["TenLop"].HeaderText = "Tên Lớp";
            gridviewTeacher.Columns["GioiTinh"].HeaderText = "Giới Tính";
            gridviewTeacher.Columns["MaLop"].Visible = false;
            gridviewTeacher.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            gridviewTeacher.Columns["SoDienThoai"].HeaderText = "Số Điện Thoại";
            gridviewTeacher.Columns["TenMon"].HeaderText = "Tên Môn";
            gridviewTeacher.Columns["Khoi"].HeaderText = "Khối";
            gridviewTeacher.Columns["NienKhoa"].HeaderText = "Niên Khóa";
            gridviewTeacher.Columns["GhiChu"].HeaderText = "Ghi Chú";
            gridviewTeacher.Columns["GioiTinh"].Visible = false;
            gridviewTeacher.Columns["MaLop"].Visible = false;
            gridviewTeacher.Columns["MaMon"].Visible = false;
            gridviewTeacher.Columns["MaMon1"].Visible = false;
            gridviewTeacher.Columns["MaLop1"].Visible = false;
            gridviewTeacher.Columns["GhiChu1"].Visible = false;
            gridviewTeacher.Columns["MaGV"].Visible = false;

            //config grid Student
            gridviewStudent.AutoResizeColumns();
            gridviewStudent.Columns["MaHocSinh"].HeaderText = "Mã Hoc Sinh";
            gridviewStudent.Columns["TenHocSinh"].HeaderText = "Tên Học Sinh";
            gridviewStudent.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            gridviewStudent.Columns["TenLop"].HeaderText = "Tên Lớp";
            gridviewStudent.Columns["NienKhoa"].HeaderText = "Niên Khóa";
            gridviewStudent.Columns["GioiTinh"].HeaderText = "Giới Tính";
            gridviewStudent.Columns["MaLop"].Visible= false;
            gridviewStudent.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            gridviewStudent.Columns["Khoi"].HeaderText = "Khối";
            gridviewStudent.Columns["GhiChu"].HeaderText = "Ghi Chú";
            gridviewStudent.Columns["DiemTrungBinh"].HeaderText = "Điểm Trung Bình";
            gridviewStudent.Columns["XepLoai"].HeaderText = "Xếp Loại";
            gridviewStudent.Columns["GioiTinh"].Visible = false;
            gridviewStudent.Columns["MaLop1"].Visible = false;
        }

        private void grade_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class();
        }

        private void year_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load_Class();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Data_Layer.DataAccess da = new Data_Layer.DataAccess();
            
            if(da.dataTableExecute("select * from LOP", lop.GetChanges()) == true)
            {
                Form_QuanLyLop_Load(null,null);
                MessageBox.Show("Cập Nhật Thành Công");

            }else
            MessageBox.Show("Cập Nhật Thất Bại");
        }

    
    }
}
