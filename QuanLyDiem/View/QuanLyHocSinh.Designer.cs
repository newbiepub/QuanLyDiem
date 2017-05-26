namespace QuanLyDiem.Presentation
{
    partial class QuanLyHocSinh
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentDate = new System.Windows.Forms.DateTimePicker();
            this.studentClass = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.studentGrade = new System.Windows.Forms.ComboBox();
            this.sexFemale = new System.Windows.Forms.RadioButton();
            this.sexMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.studentAddress = new System.Windows.Forms.TextBox();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton5);
            this.panel1.Controls.Add(this.studentDate);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.studentClass);
            this.panel1.Controls.Add(this.simpleButton3);
            this.panel1.Controls.Add(this.year);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.studentGrade);
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.sexFemale);
            this.panel1.Controls.Add(this.sexMale);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.studentAddress);
            this.panel1.Controls.Add(this.studentName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 276);
            this.panel1.TabIndex = 0;
            // 
            // studentDate
            // 
            this.studentDate.Location = new System.Drawing.Point(272, 54);
            this.studentDate.Name = "studentDate";
            this.studentDate.Size = new System.Drawing.Size(307, 20);
            this.studentDate.TabIndex = 2;
            // 
            // studentClass
            // 
            this.studentClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentClass.FormattingEnabled = true;
            this.studentClass.Location = new System.Drawing.Point(272, 168);
            this.studentClass.Name = "studentClass";
            this.studentClass.Size = new System.Drawing.Size(307, 21);
            this.studentClass.TabIndex = 5;
            // 
            // year
            // 
            this.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year.FormattingEnabled = true;
            this.year.Location = new System.Drawing.Point(272, 137);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(307, 21);
            this.year.TabIndex = 5;
            this.year.SelectedIndexChanged += new System.EventHandler(this.year_change);
            // 
            // studentGrade
            // 
            this.studentGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentGrade.FormattingEnabled = true;
            this.studentGrade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.studentGrade.Location = new System.Drawing.Point(272, 106);
            this.studentGrade.Name = "studentGrade";
            this.studentGrade.Size = new System.Drawing.Size(307, 21);
            this.studentGrade.TabIndex = 5;
            this.studentGrade.SelectedIndexChanged += new System.EventHandler(this.studentGrade_SelectedIndexChanged);
            // 
            // sexFemale
            // 
            this.sexFemale.AutoSize = true;
            this.sexFemale.Location = new System.Drawing.Point(325, 81);
            this.sexFemale.Name = "sexFemale";
            this.sexFemale.Size = new System.Drawing.Size(39, 17);
            this.sexFemale.TabIndex = 3;
            this.sexFemale.TabStop = true;
            this.sexFemale.Text = "Nữ";
            this.sexFemale.UseVisualStyleBackColor = true;
            // 
            // sexMale
            // 
            this.sexMale.AutoSize = true;
            this.sexMale.Location = new System.Drawing.Point(272, 81);
            this.sexMale.Name = "sexMale";
            this.sexMale.Size = new System.Drawing.Size(47, 17);
            this.sexMale.TabIndex = 2;
            this.sexMale.TabStop = true;
            this.sexMale.Text = "Nam";
            this.sexMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Địa Chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(187, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Niên Khóa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khối";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(187, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // studentAddress
            // 
            this.studentAddress.Location = new System.Drawing.Point(272, 198);
            this.studentAddress.Name = "studentAddress";
            this.studentAddress.Size = new System.Drawing.Size(307, 20);
            this.studentAddress.TabIndex = 1;
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(272, 28);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(307, 20);
            this.studentName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Học Sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 203);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Học Sinh";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(772, 178);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(514, 236);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(75, 23);
            this.simpleButton5.TabIndex = 9;
            this.simpleButton5.Text = "Thoát";
            this.simpleButton5.Click += new System.EventHandler(this.Thoat);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(433, 236);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(75, 23);
            this.simpleButton4.TabIndex = 10;
            this.simpleButton4.Text = "Nhập Lại";
            this.simpleButton4.Click += new System.EventHandler(this.NhapLai);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(352, 236);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(75, 23);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "Sửa";
            this.simpleButton3.Click += new System.EventHandler(this.Sua);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(271, 235);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 12;
            this.simpleButton2.Text = "Xóa";
            this.simpleButton2.Click += new System.EventHandler(this.Xoa);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(190, 235);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 13;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // QuanLyHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "QuanLyHocSinh";
            this.Text = "Quản Lý Học Sinh";
            this.Load += new System.EventHandler(this.QuanLyHocSinh_Load);
            this.Click += new System.EventHandler(this.btnThem_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton sexFemale;
        private System.Windows.Forms.RadioButton sexMale;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox studentClass;
        private System.Windows.Forms.ComboBox studentGrade;
        private System.Windows.Forms.DateTimePicker studentDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentAddress;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}