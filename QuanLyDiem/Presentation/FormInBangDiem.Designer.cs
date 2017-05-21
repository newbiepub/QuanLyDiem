using System.Windows.Forms;
using DevExpress.ExpressApp.Editors;

namespace QuanLyDiem.Presentation
{
    partial class FormInBangDiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenMonHocId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemMiengId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemGiuaKyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.diemHocKyId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tbMonId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_namhoc = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_tenhocsinh = new System.Windows.Forms.ComboBox();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.cb_hocki = new System.Windows.Forms.ComboBox();
            this.cb_khoi = new System.Windows.Forms.ComboBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(665, 432);
            this.panelControl1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(2, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 378);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(661, 278);
            this.panel3.TabIndex = 1;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(661, 278);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenMonHocId,
            this.diemMiengId,
            this.diemGiuaKyId,
            this.diemHocKyId,
            this.tbMonId});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // tenMonHocId
            // 
            this.tenMonHocId.Caption = "Tên Môn Học";
            this.tenMonHocId.FieldName = "TenMon";
            this.tenMonHocId.Name = "tenMonHocId";
            this.tenMonHocId.Visible = true;
            this.tenMonHocId.VisibleIndex = 0;
            // 
            // diemMiengId
            // 
            this.diemMiengId.Caption = "Điểm Miệng";
            this.diemMiengId.FieldName = "DiemMieng";
            this.diemMiengId.Name = "diemMiengId";
            this.diemMiengId.Visible = true;
            this.diemMiengId.VisibleIndex = 1;
            // 
            // diemGiuaKyId
            // 
            this.diemGiuaKyId.Caption = "Điểm Giữa Kỳ";
            this.diemGiuaKyId.FieldName = "DiemGiuaKy";
            this.diemGiuaKyId.Name = "diemGiuaKyId";
            this.diemGiuaKyId.Visible = true;
            this.diemGiuaKyId.VisibleIndex = 2;
            // 
            // diemHocKyId
            // 
            this.diemHocKyId.Caption = "Điểm Cuối Kỳ";
            this.diemHocKyId.FieldName = "DiemHocKy";
            this.diemHocKyId.Name = "diemHocKyId";
            this.diemHocKyId.Visible = true;
            this.diemHocKyId.VisibleIndex = 3;
            // 
            // tbMonId
            // 
            this.tbMonId.Caption = "Trung Bình Môn";
            this.tbMonId.FieldName = "TBMon";
            this.tbMonId.Name = "tbMonId";
            this.tbMonId.Visible = true;
            this.tbMonId.VisibleIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(661, 100);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_namhoc);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_tenhocsinh);
            this.groupBox1.Controls.Add(this.cb_lop);
            this.groupBox1.Controls.Add(this.cb_hocki);
            this.groupBox1.Controls.Add(this.cb_khoi);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin";
            // 
            // dtp_namhoc
            // 
            this.dtp_namhoc.CustomFormat = "yyyy";
            this.dtp_namhoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_namhoc.Location = new System.Drawing.Point(437, 37);
            this.dtp_namhoc.Name = "dtp_namhoc";
            this.dtp_namhoc.ShowUpDown = true;
            this.dtp_namhoc.Size = new System.Drawing.Size(200, 21);
            this.dtp_namhoc.TabIndex = 4;
            this.dtp_namhoc.ValueChanged += new System.EventHandler(this.dtp_namhoc_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(382, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Năm Học";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(382, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Học Kỳ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên Học Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khối";
            // 
            // cb_tenhocsinh
            // 
            this.cb_tenhocsinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_tenhocsinh.FormattingEnabled = true;
            this.cb_tenhocsinh.Location = new System.Drawing.Point(153, 62);
            this.cb_tenhocsinh.Name = "cb_tenhocsinh";
            this.cb_tenhocsinh.Size = new System.Drawing.Size(200, 21);
            this.cb_tenhocsinh.TabIndex = 0;
            this.cb_tenhocsinh.SelectedIndexChanged += new System.EventHandler(this.cb_tenhocsinh_SelectedIndexChanged);
            // 
            // cb_lop
            // 
            this.cb_lop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(153, 36);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(200, 21);
            this.cb_lop.TabIndex = 0;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // cb_hocki
            // 
            this.cb_hocki.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_hocki.FormattingEnabled = true;
            this.cb_hocki.Location = new System.Drawing.Point(437, 9);
            this.cb_hocki.Name = "cb_hocki";
            this.cb_hocki.Size = new System.Drawing.Size(200, 21);
            this.cb_hocki.TabIndex = 0;
            this.cb_hocki.SelectedIndexChanged += new System.EventHandler(this.cb_hocki_SelectedIndexChanged);
            // 
            // cb_khoi
            // 
            this.cb_khoi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_khoi.FormattingEnabled = true;
            this.cb_khoi.Location = new System.Drawing.Point(153, 9);
            this.cb_khoi.Name = "cb_khoi";
            this.cb_khoi.Size = new System.Drawing.Size(200, 21);
            this.cb_khoi.TabIndex = 0;
            this.cb_khoi.SelectedIndexChanged += new System.EventHandler(this.cb_khoi_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelControl2.Size = new System.Drawing.Size(665, 55);
            this.panelControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(216, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN BẢNG ĐIỂM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormInBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 432);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "FormInBangDiem";
            this.Text = "Bảng Điểm";
            this.Load += new System.EventHandler(this.FormInBangDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_namhoc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_tenhocsinh;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.ComboBox cb_hocki;
        private System.Windows.Forms.ComboBox cb_khoi;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn tenMonHocId;
        private DevExpress.XtraGrid.Columns.GridColumn diemMiengId;
        private DevExpress.XtraGrid.Columns.GridColumn diemGiuaKyId;
        private DevExpress.XtraGrid.Columns.GridColumn diemHocKyId;
        private DevExpress.XtraGrid.Columns.GridColumn tbMonId;


    }
}