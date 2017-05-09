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
           
        }  
        Data_Layer.DataAccess da = new Data_Layer.DataAccess();

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
                    ResetValue_Click(null, null);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string theDate = date.Value.ToString("dd/MM/yyyy");
        // Check textbox is null
            // TenHocSinh
            string tenHocSinh = "";
           
           if(studentName.Text !="")
           {
               tenHocSinh = "and TenHocSinh ='" + studentName.Text + "'";
           }
           // MaHocSinh
           string maHocSinh = "";

           if (studentCodeAdvance.Text != "0")
           {
               maHocSinh = "and MaHocSinh ='" + studentCodeAdvance.Text + "'";
           }
           // NgaySinh
           string ngaySinh = "";

           if (dateSwitch.IsOn == true)
           {
               ngaySinh = "and NgaySinh ='" + theDate + "'";
           }
           // TenLop
           string tenLop = "";

           if (studentClass.Text != "Không")
           {
               tenLop = "and LOP.TenLop ='" + studentClass.Text + "'";
           }
           // Khoi
           string khoi = "";

           if (studentGrade.Text != "Không")
           {
               khoi = "and LOP.khoi = '" + studentGrade.Text + "'";
           }
           string query = "";
            if(radioButton1.Checked)
            {

                query = "SELECT MaHocSinh,TenHocSinh,TenLop,NgaySinh,DiaChi, GioiTinh,Khoi,GhiChu,NamHoc, HOC_SINH.MaLop FROM HOC_SINH,LOP WHERE HOC_SINH.MaLop = LOP.Malop and MaHocSinh = '"+txtStudentCodeBasic.Value+"'";
            }
            else
            {

                query = "SELECT MaHocSinh,TenHocSinh,TenLop,NgaySinh,DiaChi, GioiTinh,Khoi,GhiChu,NamHoc, HOC_SINH.MaLop FROM HOC_SINH,LOP WHERE HOC_SINH.MaLop = LOP.Malop " + ngaySinh + " " + khoi + " " + maHocSinh + " " + tenHocSinh + " " + tenLop + ";";

            }
            dataGridView1.DataSource = da.select(query);
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

   

        private void dateSwitch_Toggled(object sender, EventArgs e)
        {
            if (dateSwitch.IsOn == true)
            {
                date.Enabled = true;
            }
            else
            {
                date.Enabled = false;
            }
        }

        private void ResetValue_Click(object sender, EventArgs e)
        {
            studentClass.Text = "Không";
            studentGrade.Text = "Không";
            studentName.Text = "";
            txtStudentCodeBasic.Value = 0;
            studentCodeAdvance.Value = 0;
            dateSwitch.IsOn = false;
        }

        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {
           
            // TODO: This line of code loads data into the 'lop.LOP' table. You can move, or remove it, as needed.
           
           // this.lOPTableAdapter.Fill(this.lop.LOP);
            string query = "select TenLop from LOP";
            DataTable _dt = da.select(query);
            _dt.Rows.Add("Không");
            studentClass.DataSource = _dt;
            studentClass.DisplayMember = "TenLop";
           
           
            
            
        }

      
      

     
    }
}
