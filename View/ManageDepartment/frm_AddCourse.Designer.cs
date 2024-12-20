namespace UniversitySchedule.View.ManageDepartment
{
    partial class frm_AddCourse
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddCourse));
            pnBackground = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            cmbDepartment = new Sunny.UI.UIComboBox();
            btnSave = new Sunny.UI.UIButton();
            label6 = new Label();
            label5 = new Label();
            numMaxStudent = new NumericUpDown();
            label4 = new Label();
            numClass = new NumericUpDown();
            label3 = new Label();
            numCredit = new NumericUpDown();
            label2 = new Label();
            txtNameCourse = new Sunny.UI.UITextBox();
            panel6 = new Panel();
            label1 = new Label();
            bindingSource1 = new BindingSource(components);
            pnBackground.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numClass).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCredit).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(panel1);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(514, 369);
            pnBackground.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 369);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(514, 327);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(cmbDepartment);
            panel4.Controls.Add(btnSave);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(numMaxStudent);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(numClass);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(numCredit);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtNameCourse);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(1, 0, 5, 5);
            panel4.Size = new Size(514, 327);
            panel4.TabIndex = 12;
            // 
            // cmbDepartment
            // 
            cmbDepartment.DataSource = null;
            cmbDepartment.FillColor = Color.White;
            cmbDepartment.Font = new Font("Segoe UI", 9.75F);
            cmbDepartment.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cmbDepartment.ItemRectColor = Color.FromArgb(250, 82, 82);
            cmbDepartment.ItemSelectBackColor = Color.FromArgb(250, 82, 82);
            cmbDepartment.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cmbDepartment.Location = new Point(213, 223);
            cmbDepartment.Margin = new Padding(4, 5, 4, 5);
            cmbDepartment.MinimumSize = new Size(63, 0);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Padding = new Padding(0, 0, 30, 2);
            cmbDepartment.Radius = 10;
            cmbDepartment.RectColor = Color.FromArgb(250, 82, 82);
            cmbDepartment.Size = new Size(274, 36);
            cmbDepartment.SymbolSize = 24;
            cmbDepartment.TabIndex = 325;
            cmbDepartment.TextAlignment = ContentAlignment.MiddleLeft;
            cmbDepartment.Watermark = "";
            // 
            // btnSave
            // 
            btnSave.FillColor = Color.FromArgb(250, 82, 82);
            btnSave.FillColor2 = Color.FromArgb(250, 82, 82);
            btnSave.FillDisableColor = Color.White;
            btnSave.FillHoverColor = Color.White;
            btnSave.FillPressColor = Color.White;
            btnSave.FillSelectedColor = Color.White;
            btnSave.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.ForeHoverColor = Color.Black;
            btnSave.ForePressColor = Color.Black;
            btnSave.ForeSelectedColor = Color.Black;
            btnSave.Location = new Point(212, 277);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.RectColor = Color.FromArgb(250, 82, 82);
            btnSave.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnSave.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnSave.RectPressColor = Color.FromArgb(250, 82, 82);
            btnSave.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnSave.Size = new Size(92, 37);
            btnSave.TabIndex = 324;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ImeMode = ImeMode.NoControl;
            label6.Location = new Point(25, 227);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 21);
            label6.TabIndex = 323;
            label6.Text = "Bộ môn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ImeMode = ImeMode.NoControl;
            label5.Location = new Point(25, 129);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 21);
            label5.TabIndex = 23;
            label5.Text = "Số lượng sinh viên";
            // 
            // numMaxStudent
            // 
            numMaxStudent.Font = new Font("Segoe UI", 10F);
            numMaxStudent.Location = new Point(213, 127);
            numMaxStudent.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numMaxStudent.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numMaxStudent.Name = "numMaxStudent";
            numMaxStudent.Size = new Size(82, 25);
            numMaxStudent.TabIndex = 22;
            numMaxStudent.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ImeMode = ImeMode.NoControl;
            label4.Location = new Point(25, 176);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(149, 21);
            label4.TabIndex = 21;
            label4.Text = "Số lớp trong một kỳ";
            // 
            // numClass
            // 
            numClass.Font = new Font("Segoe UI", 10F);
            numClass.Location = new Point(213, 174);
            numClass.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numClass.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numClass.Name = "numClass";
            numClass.Size = new Size(82, 25);
            numClass.TabIndex = 20;
            numClass.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(25, 82);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(74, 21);
            label3.TabIndex = 19;
            label3.Text = "Số tín chỉ";
            // 
            // numCredit
            // 
            numCredit.Font = new Font("Segoe UI", 10F);
            numCredit.Location = new Point(213, 80);
            numCredit.Maximum = new decimal(new int[] { 3, 0, 0, 0 });
            numCredit.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numCredit.Name = "numCredit";
            numCredit.Size = new Size(82, 25);
            numCredit.TabIndex = 18;
            numCredit.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(25, 37);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 14;
            label2.Text = "Tên môn học";
            // 
            // txtNameCourse
            // 
            txtNameCourse.ButtonSymbolOffset = new Point(0, 0);
            txtNameCourse.Font = new Font("Segoe UI", 9.75F);
            txtNameCourse.Location = new Point(213, 29);
            txtNameCourse.Margin = new Padding(3, 4, 3, 4);
            txtNameCourse.MinimumSize = new Size(1, 13);
            txtNameCourse.Name = "txtNameCourse";
            txtNameCourse.Padding = new Padding(10, 0, 0, 0);
            txtNameCourse.Radius = 10;
            txtNameCourse.RectColor = Color.FromArgb(250, 82, 82);
            txtNameCourse.RectDisableColor = Color.FromArgb(250, 82, 82);
            txtNameCourse.RectReadOnlyColor = Color.FromArgb(250, 82, 82);
            txtNameCourse.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtNameCourse.ScrollBarStyleInherited = false;
            txtNameCourse.ShowText = false;
            txtNameCourse.Size = new Size(274, 36);
            txtNameCourse.Style = Sunny.UI.UIStyle.Custom;
            txtNameCourse.TabIndex = 0;
            txtNameCourse.TextAlignment = ContentAlignment.MiddleLeft;
            txtNameCourse.Watermark = "Nhập tên môn học ...";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(250, 82, 82);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(514, 42);
            panel6.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(212, 11);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 0;
            label1.Text = "MÔN HỌC";
            // 
            // frm_AddCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(514, 369);
            Controls.Add(pnBackground);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_AddCourse";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm môn học";
            Load += frm_AddCourse_Load;
            pnBackground.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMaxStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)numClass).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCredit).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackground;
        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label label3;
        private NumericUpDown numCredit;
        private Label label2;
        private Sunny.UI.UITextBox txtNameCourse;
        private Panel panel6;
        private Label label1;
        private BindingSource bindingSource1;
        private Label label5;
        private NumericUpDown numMaxStudent;
        private Label label4;
        private NumericUpDown numClass;
        private Sunny.UI.UIPanel pnCombobox;
        private Label label6;
        private Sunny.UI.UIButton btnSave;
        private Sunny.UI.UIComboBox cmbDepartment;
    }
}