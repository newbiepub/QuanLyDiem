﻿﻿using DevExpress.DashboardCommon.Native;
﻿using Microsoft.Win32;

namespace QuanLyDiem.Presentation
{
    partial class FormNhapDiem
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
            DevExpress.XtraGrid.Columns.GridColumn column_hocki;
            this.edt_cuoiki = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.column_mieng = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edit_mieng = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.column_giuaki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.edt_giuaki = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.tileView1 = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_namhoc = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_hocki = new System.Windows.Forms.ComboBox();
            this.cb_monhoc = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_khoi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tenhocsinh = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            column_hocki = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.edt_cuoiki)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_mieng)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_giuaki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // column_hocki
            // 
            column_hocki.Caption = "Học Kì";
            column_hocki.ColumnEdit = this.edt_cuoiki;
            column_hocki.FieldName = "DiemHocKy";
            column_hocki.Name = "column_hocki";
            column_hocki.Visible = true;
            column_hocki.VisibleIndex = 2;
            // 
            // edt_cuoiki
            // 
            this.edt_cuoiki.AutoHeight = false;
            this.edt_cuoiki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edt_cuoiki.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edt_cuoiki.Name = "edt_cuoiki";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 461);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 246);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(703, 215);
            this.panel3.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gridControl1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 212);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Điểm Học Sinh";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(3, 16);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.edit_mieng,
            this.edt_giuaki,
            this.edt_cuoiki});
            this.gridControl1.Size = new System.Drawing.Size(697, 193);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1,
            this.tileView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.column_mieng,
            this.column_giuaki,
            column_hocki});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.InvalidRowException += new DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventHandler(this.gridView1_InvalidRowException);
            this.gridView1.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.gridView1_ValidateRow);
            // 
            // column_mieng
            // 
            this.column_mieng.Caption = "Miệng";
            this.column_mieng.ColumnEdit = this.edit_mieng;
            this.column_mieng.FieldName = "DiemMieng";
            this.column_mieng.Name = "column_mieng";
            this.column_mieng.Visible = true;
            this.column_mieng.VisibleIndex = 0;
            // 
            // edit_mieng
            // 
            this.edit_mieng.AutoHeight = false;
            this.edit_mieng.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edit_mieng.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edit_mieng.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edit_mieng.Name = "edit_mieng";
            // 
            // column_giuaki
            // 
            this.column_giuaki.Caption = "Giữa Kì";
            this.column_giuaki.ColumnEdit = this.edt_giuaki;
            this.column_giuaki.FieldName = "DiemGiuaKy";
            this.column_giuaki.Name = "column_giuaki";
            this.column_giuaki.Visible = true;
            this.column_giuaki.VisibleIndex = 1;
            // 
            // edt_giuaki
            // 
            this.edt_giuaki.AutoHeight = false;
            this.edt_giuaki.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.edt_giuaki.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.edt_giuaki.Name = "edt_giuaki";
            // 
            // tileView1
            // 
            this.tileView1.GridControl = this.gridControl1;
            this.tileView1.Name = "tileView1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(703, 240);
            this.panel2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.simpleButton3);
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 228);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nhập Điểm";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_namhoc);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cb_hocki);
            this.groupBox4.Controls.Add(this.cb_monhoc);
            this.groupBox4.Location = new System.Drawing.Point(395, 44);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(296, 114);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lựa Chọn Môn Học";
            // 
            // cb_namhoc
            // 
            this.cb_namhoc.FormattingEnabled = true;
            this.cb_namhoc.Location = new System.Drawing.Point(70, 76);
            this.cb_namhoc.Name = "cb_namhoc";
            this.cb_namhoc.Size = new System.Drawing.Size(220, 21);
            this.cb_namhoc.TabIndex = 3;
            this.cb_namhoc.SelectedIndexChanged += new System.EventHandler(this.cb_namhoc_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Năm Học";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Học Kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Môn";
            // 
            // cb_hocki
            // 
            this.cb_hocki.FormattingEnabled = true;
            this.cb_hocki.Location = new System.Drawing.Point(70, 48);
            this.cb_hocki.Name = "cb_hocki";
            this.cb_hocki.Size = new System.Drawing.Size(220, 21);
            this.cb_hocki.TabIndex = 1;
            this.cb_hocki.SelectedIndexChanged += new System.EventHandler(this.cb_hocki_SelectedIndexChanged);
            // 
            // cb_monhoc
            // 
            this.cb_monhoc.FormattingEnabled = true;
            this.cb_monhoc.Location = new System.Drawing.Point(70, 21);
            this.cb_monhoc.Name = "cb_monhoc";
            this.cb_monhoc.Size = new System.Drawing.Size(220, 21);
            this.cb_monhoc.TabIndex = 1;
            this.cb_monhoc.SelectedIndexChanged += new System.EventHandler(this.cb_monhoc_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cb_khoi);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cb_tenhocsinh);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cb_lop);
            this.groupBox3.Location = new System.Drawing.Point(12, 44);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(341, 110);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Học Sinh";
            // 
            // cb_khoi
            // 
            this.cb_khoi.FormattingEnabled = true;
            this.cb_khoi.Location = new System.Drawing.Point(100, 19);
            this.cb_khoi.Name = "cb_khoi";
            this.cb_khoi.Size = new System.Drawing.Size(220, 21);
            this.cb_khoi.TabIndex = 1;
            this.cb_khoi.SelectedIndexChanged += new System.EventHandler(this.cb_khoi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khối";
            // 
            // cb_tenhocsinh
            // 
            this.cb_tenhocsinh.FormattingEnabled = true;
            this.cb_tenhocsinh.Location = new System.Drawing.Point(100, 73);
            this.cb_tenhocsinh.Name = "cb_tenhocsinh";
            this.cb_tenhocsinh.Size = new System.Drawing.Size(220, 21);
            this.cb_tenhocsinh.TabIndex = 1;
            this.cb_tenhocsinh.SelectedIndexChanged += new System.EventHandler(this.cb_tenhocsinh_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên Học Sinh";
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(100, 46);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(220, 21);
            this.cb_lop.TabIndex = 1;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(112, 185);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Nhập Điểm";
            this.simpleButton1.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(193, 185);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 7;
            this.simpleButton2.Text = "Nhập Lại";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(274, 185);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "Thoát";
            // 
            // FormNhapDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 461);
            this.Controls.Add(this.panel1);
            this.Name = "FormNhapDiem";
            this.Text = "Nhập Điểm";
            this.Load += new System.EventHandler(this.FormNhapDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edt_cuoiki)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edit_mieng)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edt_giuaki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tileView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_tenhocsinh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_khoi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_monhoc;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn column_mieng;
        private DevExpress.XtraGrid.Columns.GridColumn column_giuaki;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_hocki;
        private DevExpress.XtraGrid.Views.Tile.TileView tileView1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit edit_mieng;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit edt_giuaki;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit edt_cuoiki;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_namhoc;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}