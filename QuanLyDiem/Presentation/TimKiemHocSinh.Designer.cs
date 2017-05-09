namespace QuanLyDiem.Presentation
{
    partial class TimKiemHocSinh
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
            this.components = new System.ComponentModel.Container();
            this.groupAdvance = new System.Windows.Forms.GroupBox();
            this.studentClass = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lop = new QuanLyDiem.lop();
            this.dateSwitch = new DevExpress.XtraEditors.ToggleSwitch();
            this.studentCodeAdvance = new System.Windows.Forms.NumericUpDown();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.studentGrade = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBasic = new System.Windows.Forms.GroupBox();
            this.txtStudentCodeBasic = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResetValue = new System.Windows.Forms.Button();
            this.lOPTableAdapter = new QuanLyDiem.lopTableAdapters.LOPTableAdapter();
            this.groupAdvance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSwitch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCodeAdvance)).BeginInit();
            this.groupBasic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCodeBasic)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupAdvance
            // 
            this.groupAdvance.Controls.Add(this.studentClass);
            this.groupAdvance.Controls.Add(this.dateSwitch);
            this.groupAdvance.Controls.Add(this.studentCodeAdvance);
            this.groupAdvance.Controls.Add(this.date);
            this.groupAdvance.Controls.Add(this.studentGrade);
            this.groupAdvance.Controls.Add(this.label5);
            this.groupAdvance.Controls.Add(this.label4);
            this.groupAdvance.Controls.Add(this.label3);
            this.groupAdvance.Controls.Add(this.studentName);
            this.groupAdvance.Controls.Add(this.label2);
            this.groupAdvance.Controls.Add(this.label1);
            this.groupAdvance.Location = new System.Drawing.Point(23, 24);
            this.groupAdvance.Name = "groupAdvance";
            this.groupAdvance.Size = new System.Drawing.Size(428, 231);
            this.groupAdvance.TabIndex = 0;
            this.groupAdvance.TabStop = false;
            this.groupAdvance.Tag = "advance";
            this.groupAdvance.Text = "Nhập Thông Tin";
            // 
            // studentClass
            // 
            this.studentClass.FormattingEnabled = true;
            this.studentClass.Location = new System.Drawing.Point(117, 121);
            this.studentClass.Name = "studentClass";
            this.studentClass.Size = new System.Drawing.Size(203, 21);
            this.studentClass.TabIndex = 7;
            this.studentClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.lop;
            // 
            // lop
            // 
            this.lop.DataSetName = "lop";
            this.lop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateSwitch
            // 
            this.dateSwitch.Location = new System.Drawing.Point(251, 147);
            this.dateSwitch.Name = "dateSwitch";
            this.dateSwitch.Properties.OffText = "Off";
            this.dateSwitch.Properties.OnText = "On";
            this.dateSwitch.Size = new System.Drawing.Size(69, 24);
            this.dateSwitch.TabIndex = 6;
            this.dateSwitch.Toggled += new System.EventHandler(this.dateSwitch_Toggled);
            // 
            // studentCodeAdvance
            // 
            this.studentCodeAdvance.Location = new System.Drawing.Point(118, 44);
            this.studentCodeAdvance.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.studentCodeAdvance.Name = "studentCodeAdvance";
            this.studentCodeAdvance.Size = new System.Drawing.Size(202, 20);
            this.studentCodeAdvance.TabIndex = 4;
            this.studentCodeAdvance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date.Location = new System.Drawing.Point(117, 148);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(128, 20);
            this.date.TabIndex = 5;
            this.date.Value = new System.DateTime(2017, 5, 9, 0, 0, 0, 0);
            this.date.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
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
            "5",
            "Không"});
            this.studentGrade.Location = new System.Drawing.Point(117, 95);
            this.studentGrade.Name = "studentGrade";
            this.studentGrade.Size = new System.Drawing.Size(203, 21);
            this.studentGrade.Sorted = true;
            this.studentGrade.TabIndex = 3;
            this.studentGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Khối";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(117, 69);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(203, 20);
            this.studentName.TabIndex = 1;
            this.studentName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Học Sinh";
            // 
            // groupBasic
            // 
            this.groupBasic.Controls.Add(this.txtStudentCodeBasic);
            this.groupBasic.Controls.Add(this.label10);
            this.groupBasic.Location = new System.Drawing.Point(23, 24);
            this.groupBasic.Name = "groupBasic";
            this.groupBasic.Size = new System.Drawing.Size(428, 231);
            this.groupBasic.TabIndex = 1;
            this.groupBasic.TabStop = false;
            this.groupBasic.Tag = "basic";
            this.groupBasic.Text = "Nhập Thông Tin";
            // 
            // txtStudentCodeBasic
            // 
            this.txtStudentCodeBasic.Location = new System.Drawing.Point(118, 44);
            this.txtStudentCodeBasic.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.txtStudentCodeBasic.Name = "txtStudentCodeBasic";
            this.txtStudentCodeBasic.Size = new System.Drawing.Size(202, 20);
            this.txtStudentCodeBasic.TabIndex = 2;
            this.txtStudentCodeBasic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã Học Sinh";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(457, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 231);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tùy Chọn";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(50, 99);
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
            this.radioButton1.Location = new System.Drawing.Point(50, 69);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "basic";
            this.radioButton1.Text = "Cơ Bản";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 43);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(20);
            this.button1.Size = new System.Drawing.Size(125, 92);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(23, 291);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(862, 200);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết Quả Tìm Kiếm";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(850, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // ResetValue
            // 
            this.ResetValue.Location = new System.Drawing.Point(741, 172);
            this.ResetValue.Name = "ResetValue";
            this.ResetValue.Size = new System.Drawing.Size(125, 60);
            this.ResetValue.TabIndex = 4;
            this.ResetValue.Text = "Nhập Lại";
            this.ResetValue.UseVisualStyleBackColor = true;
            this.ResetValue.Click += new System.EventHandler(this.ResetValue_Click);
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // TimKiemHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 503);
            this.Controls.Add(this.ResetValue);
            this.Controls.Add(this.groupBasic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupAdvance);
            this.Name = "TimKiemHocSinh";
            this.Text = "TimKiemHocSinh";
            this.Load += new System.EventHandler(this.TimKiemHocSinh_Load);
            this.groupAdvance.ResumeLayout(false);
            this.groupAdvance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateSwitch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentCodeAdvance)).EndInit();
            this.groupBasic.ResumeLayout(false);
            this.groupBasic.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStudentCodeBasic)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupAdvance;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.ComboBox studentGrade;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBasic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown txtStudentCodeBasic;
        private System.Windows.Forms.NumericUpDown studentCodeAdvance;
        private DevExpress.XtraEditors.ToggleSwitch dateSwitch;
        private System.Windows.Forms.Button ResetValue;
        private System.Windows.Forms.ComboBox studentClass;
        private lop lop;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private lopTableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}