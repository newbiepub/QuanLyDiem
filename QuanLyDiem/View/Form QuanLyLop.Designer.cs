namespace QuanLyDiem.Presentation
{
    partial class Form_QuanLyLop
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
            this.gridviewClass = new System.Windows.Forms.DataGridView();
            this.gridviewStudent = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridviewTeacher = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.ComboBox();
            this.year = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dbDataSet = new QuanLyDiem.dbDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new QuanLyDiem.dbDataSetTableAdapters.LOPTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTeacher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridviewClass
            // 
            this.gridviewClass.AllowUserToOrderColumns = true;
            this.gridviewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewClass.Location = new System.Drawing.Point(12, 76);
            this.gridviewClass.Name = "gridviewClass";
            this.gridviewClass.Size = new System.Drawing.Size(210, 441);
            this.gridviewClass.TabIndex = 2;
            this.gridviewClass.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridviewClass_RowHeaderMouseDoubleClick);
            // 
            // gridviewStudent
            // 
            this.gridviewStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewStudent.Location = new System.Drawing.Point(228, 274);
            this.gridviewStudent.Name = "gridviewStudent";
            this.gridviewStudent.Size = new System.Drawing.Size(646, 243);
            this.gridviewStudent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Danh Sách Học Sinh";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Giáo Viên";
            // 
            // gridviewTeacher
            // 
            this.gridviewTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewTeacher.Location = new System.Drawing.Point(228, 22);
            this.gridviewTeacher.Name = "gridviewTeacher";
            this.gridviewTeacher.Size = new System.Drawing.Size(646, 233);
            this.gridviewTeacher.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Danh Sách Lớp";
            // 
            // grade
            // 
            this.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.grade.Location = new System.Drawing.Point(101, 27);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(121, 21);
            this.grade.TabIndex = 3;
            this.grade.SelectedIndexChanged += new System.EventHandler(this.grade_SelectedIndexChanged);
            // 
            // year
            // 
            this.year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year.FormattingEnabled = true;
            this.year.Items.AddRange(new object[] {
            "Tất Cả"});
            this.year.Location = new System.Drawing.Point(101, 52);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(121, 21);
            this.year.TabIndex = 3;
            this.year.SelectedIndexChanged += new System.EventHandler(this.year_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Khối";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Niên Khóa";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Cập Nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.dbDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // Form_QuanLyLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.year);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.gridviewTeacher);
            this.Controls.Add(this.gridviewStudent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridviewClass);
            this.Controls.Add(this.label3);
            this.Name = "Form_QuanLyLop";
            this.Text = "Quản Lý Lớp";
            this.Load += new System.EventHandler(this.Form_QuanLyLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewTeacher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridviewClass;
        private System.Windows.Forms.DataGridView gridviewStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridviewTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.ComboBox year;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private dbDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;

    }
}