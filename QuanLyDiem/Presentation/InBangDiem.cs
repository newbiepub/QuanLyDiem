using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace QuanLyDiem.Presentation
{
    public partial class InBangDiem : DevExpress.XtraEditors.XtraForm
    {
        public InBangDiem()
        {
            InitializeComponent();
            this.rb_grade.Checked = true;this.lb_lop.Hide();
            this.cb_lop.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var rbButton = (RadioButton) sender;
            if (rbButton.Checked)
            {
                if (rbButton.Tag == "class")
                {
                    this.lb_lop.Show();
                    this.cb_lop.Show();
                }
                else if (rbButton.Tag == "grade")
                {this.lb_lop.Hide();
                    this.cb_lop.Hide();
                }
            }
        }
    }
}