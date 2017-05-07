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
        }

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
    }
}
