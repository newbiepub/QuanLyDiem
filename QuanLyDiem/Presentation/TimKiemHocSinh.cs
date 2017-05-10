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
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "";
            if(radioButton1.Checked)
            {

                query = "select * from HOC_SINH where MaHocSinh=@mahocsinh;";
                SqlParameter [] pr =
                {
                    new SqlParameter("@mahocsinh", txtStudentCodeBasic.Value), 
                };
                dataGridView1.DataSource = da.select(query, pr);
            }
            else
            {
               
                //querry ten
                string tenHocSinh = "";
                if( studentName.Text != "")
                {
                    tenHocSinh = "and TenHocSinh=@tenhocsinh";
                }
                //querry ma
                string maHocSinh = "";
                if (studentCodeAdvance.Value != 0)
                {
                    maHocSinh = "and MaHocSinh=@mahocsinh";
                }
                //querry khoi
                string khoi = "";
                if (studentGrade.Text != "Không")
                {
                    khoi = "and LOP.khoi=@khoi";
                }
                //querry Lop
                string lop = "";
                if (studentClass.Text != "Không")
                {
                    lop = "and LOP.TenLop=@tenlop";
                }
                //querry namsinh
                string namSinh = "";
                if (date.Value != 0)
                {
                    namSinh = "and year(NgaySinh)=@namsinh";
                }
                query =
                    "select * from HOC_SINH,LOP where HOC_SINH.MaLop=LOP.MaLop " + khoi + " " + lop + " " + tenHocSinh + " " + maHocSinh + " " + namSinh + "";
                SqlParameter[] pr =
                {
                    new SqlParameter("@namsinh", date.Value),
                    new SqlParameter("@tenhocsinh", studentName.Text),
                    new SqlParameter("@tenlop", studentClass.Text),
                    new SqlParameter("@mahocsinh", studentCodeAdvance.Text),
                    new SqlParameter("@khoi", studentGrade.Text),
                };
                dataGridView1.DataSource = da.select(query, pr);
            }
            if(dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không có hoc sinh !!!");
            }
        }

        private void EnterPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                button1_Click(null,null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            date.Value = 0;
            studentName.Text = "";
            studentGrade.Text = "Không";
            studentCodeAdvance.Value = 0;
            studentClass.Text = "Không";

        }

        private void TimKiemHocSinh_Load(object sender, EventArgs e)
        {
            string query = "select TenLop from LOP";
            SqlParameter[] pr = { };
            DataTable dataClass = da.select(query, pr);
            dataClass.Rows.Add("Không");
            studentClass.DataSource = dataClass;
            studentClass.DisplayMember = "TenLop";
            studentClass.Text = "Không";
            
        }


     
    }
}
