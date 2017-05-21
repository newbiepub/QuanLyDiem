using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDiem.Presentation;

namespace QuanLyDiem
{
    public partial class MDIQuanLyParentForm : Form
    {
        private int childFormNumber = 0;

        public MDIQuanLyParentForm()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap formDangNhap = new FormDangNhap();
            formDangNhap.Show(this);
        }

        private void đăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangKi formDangKi = new FormDangKi();
            formDangKi.Show(this);
        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyGiaoVien formGiaoVien = new QuanLyGiaoVien();
            formGiaoVien.Show(this);
        }

        private void quảnLýHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyHocSinh formQuanLyHocSinh = new QuanLyHocSinh();
            formQuanLyHocSinh.Show(this);
        }

        private void tìmKiếmGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemGiaoVien formTimKiemGiaoVien = new TimKiemGiaoVien();
            formTimKiemGiaoVien.Show(this);
        }

        private void tìmKiếmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimKiemHocSinh formTimKiemHocSinh = new TimKiemHocSinh();
            formTimKiemHocSinh.Show(this);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nhậpĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNhapDiem formNhapDiem = new FormNhapDiem();
            formNhapDiem.Show(this);
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormThongKe formThongKe = new FormThongKe();
            formThongKe.Show(this);
        }

        private void inBảngĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InBangDiem formInBangDiem = new InBangDiem();
            formInBangDiem.Show(this);
        }

        private void MDIQuanLyParentForm_Load(object sender, EventArgs e)
        {
            //FormDangNhap dn = new FormDangNhap();
            //if(dn.ShowDialog()!= DialogResult.OK)
            //{
            //    Application.Exit();
            //}
        }

        private void inBảngĐiểmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInBangDiem frmInBangDiem = new FormInBangDiem();
            frmInBangDiem.Show(this);
        }
    }
}
