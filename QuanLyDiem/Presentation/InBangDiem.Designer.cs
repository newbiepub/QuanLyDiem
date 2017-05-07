namespace QuanLyDiem.Presentation
{
    partial class InBangDiem
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
            DevExpress.Utils.Animation.PushTransition pushTransition1 = new DevExpress.Utils.Animation.PushTransition();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.workspaceManager1 = new DevExpress.Utils.WorkspaceManager();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_grade = new System.Windows.Forms.RadioButton();
            this.rb_class = new System.Windows.Forms.RadioButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cb_lop = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lb_lop = new DevExpress.XtraEditors.LabelControl();
            this.cb_khoi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lb_khoi = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_lop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_khoi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // workspaceManager1
            // 
            this.workspaceManager1.TargetControl = this;
            this.workspaceManager1.TransitionType = pushTransition1;
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Owner = this;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 113);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(517, 58);
            this.panelControl1.TabIndex = 0;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(294, 23);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 0;
            this.simpleButton2.Text = "Hủy";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(150, 23);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "In Bảng Điểm";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(150, 113);
            this.panelControl2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_grade);
            this.groupBox1.Controls.Add(this.rb_class);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tùy Chọn";
            // 
            // rb_grade
            // 
            this.rb_grade.AutoSize = true;
            this.rb_grade.Location = new System.Drawing.Point(10, 81);
            this.rb_grade.Name = "rb_grade";
            this.rb_grade.Size = new System.Drawing.Size(85, 17);
            this.rb_grade.TabIndex = 0;
            this.rb_grade.TabStop = true;
            this.rb_grade.Tag = "grade";
            this.rb_grade.Text = "In Theo Khối";
            this.rb_grade.UseVisualStyleBackColor = true;
            this.rb_grade.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rb_class
            // 
            this.rb_class.AutoSize = true;
            this.rb_class.Location = new System.Drawing.Point(10, 47);
            this.rb_class.Name = "rb_class";
            this.rb_class.Size = new System.Drawing.Size(82, 17);
            this.rb_class.TabIndex = 0;
            this.rb_class.TabStop = true;
            this.rb_class.Tag = "class";
            this.rb_class.Text = "In Theo Lớp";
            this.rb_class.UseVisualStyleBackColor = true;
            this.rb_class.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupBox2);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(150, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(367, 113);
            this.panelControl3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cb_lop);
            this.groupBox2.Controls.Add(this.lb_lop);
            this.groupBox2.Controls.Add(this.cb_khoi);
            this.groupBox2.Controls.Add(this.lb_khoi);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 109);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin";
            // 
            // cb_lop
            // 
            this.cb_lop.Location = new System.Drawing.Point(107, 78);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_lop.Size = new System.Drawing.Size(239, 20);
            this.cb_lop.TabIndex = 1;
            // 
            // lb_lop
            // 
            this.lb_lop.Location = new System.Drawing.Point(26, 81);
            this.lb_lop.Name = "lb_lop";
            this.lb_lop.Size = new System.Drawing.Size(17, 13);
            this.lb_lop.TabIndex = 0;
            this.lb_lop.Text = "Lớp";
            // 
            // cb_khoi
            // 
            this.cb_khoi.Location = new System.Drawing.Point(107, 44);
            this.cb_khoi.Name = "cb_khoi";
            this.cb_khoi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_khoi.Size = new System.Drawing.Size(239, 20);
            this.cb_khoi.TabIndex = 1;
            // 
            // lb_khoi
            // 
            this.lb_khoi.Location = new System.Drawing.Point(26, 47);
            this.lb_khoi.Name = "lb_khoi";
            this.lb_khoi.Size = new System.Drawing.Size(20, 13);
            this.lb_khoi.TabIndex = 0;
            this.lb_khoi.Text = "Khối";
            // 
            // InBangDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 171);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "InBangDiem";
            this.Text = "In Bảng Điểm";
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_lop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_khoi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.Utils.WorkspaceManager workspaceManager1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.ComboBoxEdit cb_lop;
        private DevExpress.XtraEditors.LabelControl lb_lop;
        private DevExpress.XtraEditors.ComboBoxEdit cb_khoi;
        private DevExpress.XtraEditors.LabelControl lb_khoi;
        private System.Windows.Forms.RadioButton rb_grade;
        private System.Windows.Forms.RadioButton rb_class;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}