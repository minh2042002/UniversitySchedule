namespace UniversitySchedule.View.ManageDepartment
{
    partial class frm_ChooseCourse
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ChooseCourse));
            pnBackground = new Panel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            panel2 = new Panel();
            panel7 = new Panel();
            dgvCourse = new DataGridView();
            check = new DataGridViewCheckBoxColumn();
            stt = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            credit = new DataGridViewTextBoxColumn();
            max_student = new DataGridViewTextBoxColumn();
            number_class = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            panel3 = new Panel();
            btnSave = new Sunny.UI.UIButton();
            cmsCourse = new ContextMenuStrip(components);
            select = new ToolStripMenuItem();
            unselect = new ToolStripMenuItem();
            selectAll = new ToolStripMenuItem();
            unselectAll = new ToolStripMenuItem();
            getAllCourse = new ToolStripMenuItem();
            pnBackground.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            panel3.SuspendLayout();
            cmsCourse.SuspendLayout();
            SuspendLayout();
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(uiGroupBox1);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(1185, 496);
            pnBackground.TabIndex = 0;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(panel2);
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            uiGroupBox1.ForeColor = Color.FromArgb(250, 82, 82);
            uiGroupBox1.Location = new Point(0, 0);
            uiGroupBox1.Margin = new Padding(8);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(2, 32, 2, 3);
            uiGroupBox1.Radius = 10;
            uiGroupBox1.RectColor = Color.FromArgb(250, 82, 82);
            uiGroupBox1.Size = new Size(1185, 496);
            uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox1.TabIndex = 164;
            uiGroupBox1.Text = "DANH SÁCH MÔN HỌC";
            uiGroupBox1.TextAlignment = ContentAlignment.TopLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(1181, 461);
            panel2.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvCourse);
            panel7.Controls.Add(panel1);
            panel7.Controls.Add(panel3);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(1181, 461);
            panel7.TabIndex = 6;
            // 
            // dgvCourse
            // 
            dgvCourse.AllowUserToAddRows = false;
            dgvCourse.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle1.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvCourse.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvCourse.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvCourse.BackgroundColor = Color.White;
            dgvCourse.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCourse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCourse.ColumnHeadersHeight = 40;
            dgvCourse.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCourse.Columns.AddRange(new DataGridViewColumn[] { check, stt, name, credit, max_student, number_class, department });
            dgvCourse.ContextMenuStrip = cmsCourse;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCourse.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCourse.Dock = DockStyle.Fill;
            dgvCourse.ImeMode = ImeMode.NoControl;
            dgvCourse.Location = new Point(5, 5);
            dgvCourse.Name = "dgvCourse";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCourse.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCourse.RowHeadersVisible = false;
            dgvCourse.RowHeadersWidth = 45;
            dgvCourse.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle5.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCourse.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvCourse.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvCourse.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 8.25F);
            dgvCourse.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvCourse.RowTemplate.DefaultCellStyle.Padding = new Padding(2, 10, 2, 10);
            dgvCourse.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvCourse.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvCourse.RowTemplate.DividerHeight = 1;
            dgvCourse.RowTemplate.Height = 55;
            dgvCourse.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCourse.Size = new Size(1171, 393);
            dgvCourse.TabIndex = 0;
            // 
            // check
            // 
            check.FillWeight = 50F;
            check.HeaderText = "";
            check.Name = "check";
            check.Resizable = DataGridViewTriState.True;
            check.SortMode = DataGridViewColumnSortMode.Automatic;
            check.Width = 50;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 50;
            stt.Name = "stt";
            stt.Width = 70;
            // 
            // name
            // 
            name.FillWeight = 300F;
            name.HeaderText = "Tên môn học";
            name.MinimumWidth = 300;
            name.Name = "name";
            name.Width = 300;
            // 
            // credit
            // 
            credit.FillWeight = 150F;
            credit.HeaderText = "Số tín chỉ";
            credit.MinimumWidth = 150;
            credit.Name = "credit";
            credit.Width = 150;
            // 
            // max_student
            // 
            max_student.FillWeight = 200F;
            max_student.HeaderText = "Số lượng sinh viên";
            max_student.MinimumWidth = 200;
            max_student.Name = "max_student";
            max_student.Width = 200;
            // 
            // number_class
            // 
            number_class.FillWeight = 200F;
            number_class.HeaderText = "Số lớp trong một kỳ";
            number_class.MinimumWidth = 200;
            number_class.Name = "number_class";
            number_class.Width = 200;
            // 
            // department
            // 
            department.FillWeight = 200F;
            department.HeaderText = "Bộ môn";
            department.MinimumWidth = 200;
            department.Name = "department";
            department.Width = 200;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(250, 82, 82);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(5, 398);
            panel1.Name = "panel1";
            panel1.Size = new Size(1171, 5);
            panel1.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(5, 403);
            panel3.Name = "panel3";
            panel3.Size = new Size(1171, 53);
            panel3.TabIndex = 4;
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
            btnSave.Location = new Point(539, 10);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.RectColor = Color.FromArgb(250, 82, 82);
            btnSave.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnSave.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnSave.RectPressColor = Color.FromArgb(250, 82, 82);
            btnSave.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnSave.Size = new Size(92, 33);
            btnSave.TabIndex = 321;
            btnSave.Text = "Lưu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // cmsCourse
            // 
            cmsCourse.Items.AddRange(new ToolStripItem[] { select, unselect, selectAll, unselectAll, getAllCourse });
            cmsCourse.Name = "cmsCalendar";
            cmsCourse.Size = new Size(265, 114);
            // 
            // select
            // 
            select.Image = Properties.Resources.checked_checkbox_24_red;
            select.Name = "select";
            select.Size = new Size(264, 22);
            select.Text = "Chọn";
            select.Click += select_Click;
            // 
            // unselect
            // 
            unselect.Image = Properties.Resources.un_checked_checkbox_24_red;
            unselect.Name = "unselect";
            unselect.Size = new Size(264, 22);
            unselect.Text = "Bỏ chọn";
            unselect.Click += unselect_Click;
            // 
            // selectAll
            // 
            selectAll.Image = Properties.Resources.select_all_24_red;
            selectAll.Name = "selectAll";
            selectAll.Size = new Size(264, 22);
            selectAll.Text = "Chọn tất cả";
            selectAll.Click += selectAll_Click;
            // 
            // unselectAll
            // 
            unselectAll.Image = Properties.Resources.un_check_all_24_red;
            unselectAll.Name = "unselectAll";
            unselectAll.Size = new Size(264, 22);
            unselectAll.Text = "Bỏ chọn tất cả";
            unselectAll.Click += unselectAll_Click;
            // 
            // getAllCourse
            // 
            getAllCourse.Image = Properties.Resources.note_24_red;
            getAllCourse.Name = "getAllCourse";
            getAllCourse.Size = new Size(264, 22);
            getAllCourse.Text = "Lấy toàn bộ môn học trong bộ môn";
            getAllCourse.Click += getAllCourse_Click;
            // 
            // frm_ChooseCourse
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(1185, 496);
            Controls.Add(pnBackground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_ChooseCourse";
            Load += frm_ChooseCourse_Load;
            pnBackground.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            panel3.ResumeLayout(false);
            cmsCourse.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackground;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvCourse;
        private Panel panel3;
        private Sunny.UI.UIButton btnSave;
        private DataGridViewCheckBoxColumn check;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn credit;
        private DataGridViewTextBoxColumn max_student;
        private DataGridViewTextBoxColumn number_class;
        private DataGridViewTextBoxColumn department;
        private ContextMenuStrip cmsCourse;
        private ToolStripMenuItem select;
        private ToolStripMenuItem unselect;
        private ToolStripMenuItem unselectAll;
        private ToolStripMenuItem selectAll;
        private ToolStripMenuItem getAllCourse;
        private Panel panel1;
    }
}