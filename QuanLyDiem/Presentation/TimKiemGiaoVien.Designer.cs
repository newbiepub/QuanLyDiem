namespace QuanLyDiem.Presentation
{
    partial class TimKiemGiaoVien
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
            this.groupBoxAdvance = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.teacherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBoxBasic = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.teacherCodeAdvance = new System.Windows.Forms.NumericUpDown();
            this.subjectSpecialize = new System.Windows.Forms.ComboBox();
            this.teacherClass = new System.Windows.Forms.ComboBox();
            this.Reset = new System.Windows.Forms.Button();
            this.teacherCodeBasic = new System.Windows.Forms.NumericUpDown();
            this.groupBoxAdvance.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBoxBasic.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCodeAdvance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCodeBasic)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAdvance
            // 
            this.groupBoxAdvance.Controls.Add(this.teacherClass);
            this.groupBoxAdvance.Controls.Add(this.subjectSpecialize);
            this.groupBoxAdvance.Controls.Add(this.teacherCodeAdvance);
            this.groupBoxAdvance.Controls.Add(this.label4);
            this.groupBoxAdvance.Controls.Add(this.label3);
            this.groupBoxAdvance.Controls.Add(this.teacherName);
            this.groupBoxAdvance.Controls.Add(this.label2);
            this.groupBoxAdvance.Controls.Add(this.label1);
            this.groupBoxAdvance.Location = new System.Drawing.Point(38, 38);
            this.groupBoxAdvance.Name = "groupBoxAdvance";
            this.groupBoxAdvance.Size = new System.Drawing.Size(390, 195);
            this.groupBoxAdvance.TabIndex = 0;
            this.groupBoxAdvance.TabStop = false;
            this.groupBoxAdvance.Text = "Nhập Thông Tin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Chuyên Môn";
            // 
            // teacherName
            // 
            this.teacherName.Location = new System.Drawing.Point(127, 80);
            this.teacherName.Name = "teacherName";
            this.teacherName.Size = new System.Drawing.Size(179, 20);
            this.teacherName.TabIndex = 1;
            this.teacherName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Giáo Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giáo Viên";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(681, 61);
            this.Find.Name = "Find";
            this.Find.Padding = new System.Windows.Forms.Padding(20);
            this.Find.Size = new System.Drawing.Size(132, 85);
            this.Find.TabIndex = 1;
            this.Find.Text = "Tìm Kiếm";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(434, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 195);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy Chọn";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(30, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(73, 17);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "advance";
            this.radioButton2.Text = "Nâng Cao";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(30, 52);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "basic";
            this.radioButton1.Text = "Cơ Bản";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // groupBoxBasic
            // 
            this.groupBoxBasic.Controls.Add(this.label8);
            this.groupBoxBasic.Controls.Add(this.teacherCodeBasic);
            this.groupBoxBasic.Location = new System.Drawing.Point(38, 223);
            this.groupBoxBasic.Name = "groupBoxBasic";
            this.groupBoxBasic.Size = new System.Drawing.Size(390, 10);
            this.groupBoxBasic.TabIndex = 0;
            this.groupBoxBasic.TabStop = false;
            this.groupBoxBasic.Text = "Nhập Thông Tin";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã Giáo Viên";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(38, 279);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 196);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả Tìm Kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // teacherCodeAdvance
            // 
            this.teacherCodeAdvance.Location = new System.Drawing.Point(127, 55);
            this.teacherCodeAdvance.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.teacherCodeAdvance.Name = "teacherCodeAdvance";
            this.teacherCodeAdvance.Size = new System.Drawing.Size(179, 20);
            this.teacherCodeAdvance.TabIndex = 2;
            this.teacherCodeAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // subjectSpecialize
            // 
            this.subjectSpecialize.FormattingEnabled = true;
            this.subjectSpecialize.Location = new System.Drawing.Point(127, 106);
            this.subjectSpecialize.Name = "subjectSpecialize";
            this.subjectSpecialize.Size = new System.Drawing.Size(179, 21);
            this.subjectSpecialize.TabIndex = 3;
            this.subjectSpecialize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // teacherClass
            // 
            this.teacherClass.FormattingEnabled = true;
            this.teacherClass.Location = new System.Drawing.Point(127, 132);
            this.teacherClass.Name = "teacherClass";
            this.teacherClass.Size = new System.Drawing.Size(179, 21);
            this.teacherClass.TabIndex = 3;
            this.teacherClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(681, 167);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(132, 37);
            this.Reset.TabIndex = 4;
            this.Reset.Text = "Nhập Lại";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // teacherCodeBasic
            // 
            this.teacherCodeBasic.Location = new System.Drawing.Point(121, 55);
            this.teacherCodeBasic.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.teacherCodeBasic.Name = "teacherCodeBasic";
            this.teacherCodeBasic.Size = new System.Drawing.Size(179, 20);
            this.teacherCodeBasic.TabIndex = 2;
            this.teacherCodeBasic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // TimKiemGiaoVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 487);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.groupBoxBasic);
            this.Controls.Add(this.groupBoxAdvance);
            this.Name = "TimKiemGiaoVien";
            this.Text = "TimKiemGiaoVien";
            this.Load += new System.EventHandler(this.TimKiemGiaoVien_Load);
            this.groupBoxAdvance.ResumeLayout(false);
            this.groupBoxAdvance.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBoxBasic.ResumeLayout(false);
            this.groupBoxBasic.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCodeAdvance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherCodeBasic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAdvance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox teacherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBoxBasic;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox teacherClass;
        private System.Windows.Forms.ComboBox subjectSpecialize;
        private System.Windows.Forms.NumericUpDown teacherCodeAdvance;
        private System.Windows.Forms.NumericUpDown teacherCodeBasic;
        private System.Windows.Forms.Button Reset;
    }
}