namespace UniversitySchedule.View.ManageDepartment
{
    partial class uc_ManageCourse
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

        #region Component Designer generated code

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
            PresentationControls.CheckBoxProperties checkBoxProperties1 = new PresentationControls.CheckBoxProperties();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            panel2 = new Panel();
            panel7 = new Panel();
            dgvCourse = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            credit = new DataGridViewTextBoxColumn();
            max_student = new DataGridViewTextBoxColumn();
            number_class = new DataGridViewTextBoxColumn();
            instructor = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            cmsCourse = new ContextMenuStrip(components);
            editCourse = new ToolStripMenuItem();
            deleteCourse = new ToolStripMenuItem();
            panel3 = new Panel();
            txtFindByName = new Sunny.UI.UITextBox();
            btnSearch = new Sunny.UI.UISymbolButton();
            btnLoad = new Sunny.UI.UIButton();
            pnCombobox = new Sunny.UI.UIPanel();
            cmbDepartment = new PresentationControls.CheckBoxComboBox();
            btnReload = new Sunny.UI.UISymbolButton();
            pnBackground = new Panel();
            uiGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCourse).BeginInit();
            cmsCourse.SuspendLayout();
            panel3.SuspendLayout();
            pnCombobox.SuspendLayout();
            pnBackground.SuspendLayout();
            SuspendLayout();
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(panel2);
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            uiGroupBox1.ForeColor = Color.FromArgb(250, 82, 82);
            uiGroupBox1.Location = new Point(5, 5);
            uiGroupBox1.Margin = new Padding(8);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(2, 32, 2, 3);
            uiGroupBox1.Radius = 10;
            uiGroupBox1.RectColor = Color.FromArgb(250, 82, 82);
            uiGroupBox1.Size = new Size(1069, 581);
            uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox1.TabIndex = 163;
            uiGroupBox1.Text = "DANH SÁCH MÔN HỌC";
            uiGroupBox1.TextAlignment = ContentAlignment.TopLeft;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(2, 32);
            panel2.Name = "panel2";
            panel2.Size = new Size(1065, 546);
            panel2.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvCourse);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 68);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(1065, 478);
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
            dgvCourse.Columns.AddRange(new DataGridViewColumn[] { stt, name, credit, max_student, number_class, instructor, department });
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
            dgvCourse.MultiSelect = false;
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
            dgvCourse.Size = new Size(1055, 468);
            dgvCourse.TabIndex = 0;
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
            // instructor
            // 
            instructor.FillWeight = 250F;
            instructor.HeaderText = "Số giảng viên đảm nhiệm";
            instructor.MinimumWidth = 250;
            instructor.Name = "instructor";
            instructor.Width = 250;
            // 
            // department
            // 
            department.FillWeight = 200F;
            department.HeaderText = "Bộ môn";
            department.MinimumWidth = 200;
            department.Name = "department";
            department.Width = 200;
            // 
            // cmsCourse
            // 
            cmsCourse.Items.AddRange(new ToolStripItem[] { editCourse, deleteCourse });
            cmsCourse.Name = "cmsCalendar";
            cmsCourse.Size = new Size(179, 48);
            // 
            // editCourse
            // 
            editCourse.Image = Properties.Resources.edit_24_red;
            editCourse.Name = "editCourse";
            editCourse.Size = new Size(178, 22);
            editCourse.Text = "Chỉnh sửa môn học";
            editCourse.Click += editCourse_Click;
            // 
            // deleteCourse
            // 
            deleteCourse.Image = Properties.Resources.remove_24_red;
            deleteCourse.Name = "deleteCourse";
            deleteCourse.Size = new Size(178, 22);
            deleteCourse.Text = "Xóa môn học";
            deleteCourse.Click += deleteCourse_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoScrollMinSize = new Size(1065, 68);
            panel3.Controls.Add(txtFindByName);
            panel3.Controls.Add(btnSearch);
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(pnCombobox);
            panel3.Controls.Add(btnReload);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 68);
            panel3.TabIndex = 4;
            // 
            // txtFindByName
            // 
            txtFindByName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFindByName.ButtonFillColor = Color.FromArgb(0, 104, 196);
            txtFindByName.ButtonFillHoverColor = Color.FromArgb(0, 104, 196);
            txtFindByName.ButtonFillPressColor = Color.FromArgb(0, 104, 196);
            txtFindByName.ButtonRectColor = Color.FromArgb(0, 104, 196);
            txtFindByName.ButtonRectHoverColor = Color.FromArgb(0, 104, 196);
            txtFindByName.ButtonRectPressColor = Color.FromArgb(0, 104, 196);
            txtFindByName.ButtonStyleInherited = false;
            txtFindByName.ButtonSymbolOffset = new Point(0, 0);
            txtFindByName.Font = new Font("Segoe UI", 9.75F);
            txtFindByName.Location = new Point(724, 17);
            txtFindByName.Margin = new Padding(3, 4, 3, 4);
            txtFindByName.MinimumSize = new Size(1, 13);
            txtFindByName.Name = "txtFindByName";
            txtFindByName.Padding = new Padding(8);
            txtFindByName.Radius = 10;
            txtFindByName.RectColor = SystemColors.ControlDark;
            txtFindByName.ScrollBarColor = Color.Gray;
            txtFindByName.ScrollBarStyleInherited = false;
            txtFindByName.ShowText = false;
            txtFindByName.Size = new Size(245, 33);
            txtFindByName.Style = Sunny.UI.UIStyle.Custom;
            txtFindByName.StyleCustomMode = true;
            txtFindByName.TabIndex = 278;
            txtFindByName.TextAlignment = ContentAlignment.MiddleLeft;
            txtFindByName.Watermark = "Nhập tên môn học ...";
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FillColor = Color.White;
            btnSearch.FillColor2 = Color.White;
            btnSearch.FillHoverColor = Color.White;
            btnSearch.FillPressColor = Color.White;
            btnSearch.FillSelectedColor = Color.White;
            btnSearch.Font = new Font("Microsoft YaHei", 12F);
            btnSearch.ForeDisableColor = Color.White;
            btnSearch.Image = Properties.Resources.search_24_red;
            btnSearch.IsCircle = true;
            btnSearch.Location = new Point(976, 13);
            btnSearch.Margin = new Padding(2);
            btnSearch.MinimumSize = new Size(1, 1);
            btnSearch.Name = "btnSearch";
            btnSearch.RectColor = Color.White;
            btnSearch.RectHoverColor = Color.White;
            btnSearch.RectPressColor = Color.White;
            btnSearch.RectSelectedColor = Color.White;
            btnSearch.Size = new Size(40, 40);
            btnSearch.Style = Sunny.UI.UIStyle.Custom;
            btnSearch.StyleCustomMode = true;
            btnSearch.TabIndex = 277;
            btnSearch.TipsColor = Color.FromArgb(0, 104, 196);
            btnSearch.TipsFont = new Font("Microsoft Sans Serif", 9F);
            // 
            // btnLoad
            // 
            btnLoad.FillColor = Color.FromArgb(250, 82, 82);
            btnLoad.FillColor2 = Color.FromArgb(250, 82, 82);
            btnLoad.FillDisableColor = Color.White;
            btnLoad.FillHoverColor = Color.White;
            btnLoad.FillPressColor = Color.White;
            btnLoad.FillSelectedColor = Color.White;
            btnLoad.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoad.ForeHoverColor = Color.Black;
            btnLoad.ForePressColor = Color.Black;
            btnLoad.ForeSelectedColor = Color.Black;
            btnLoad.Location = new Point(324, 17);
            btnLoad.MinimumSize = new Size(1, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Radius = 10;
            btnLoad.RectColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectPressColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnLoad.Size = new Size(92, 33);
            btnLoad.TabIndex = 321;
            btnLoad.Text = "LOAD";
            btnLoad.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLoad.Click += btnLoad_Click;
            // 
            // pnCombobox
            // 
            pnCombobox.Controls.Add(cmbDepartment);
            pnCombobox.FillColor = Color.White;
            pnCombobox.FillColor2 = Color.White;
            pnCombobox.Font = new Font("Microsoft Sans Serif", 12F);
            pnCombobox.Location = new Point(66, 17);
            pnCombobox.Margin = new Padding(4, 5, 4, 5);
            pnCombobox.MinimumSize = new Size(1, 1);
            pnCombobox.Name = "pnCombobox";
            pnCombobox.Padding = new Padding(3);
            pnCombobox.Radius = 10;
            pnCombobox.RectColor = SystemColors.ControlDark;
            pnCombobox.Size = new Size(242, 33);
            pnCombobox.Style = Sunny.UI.UIStyle.Custom;
            pnCombobox.StyleCustomMode = true;
            pnCombobox.TabIndex = 320;
            pnCombobox.Text = null;
            pnCombobox.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // cmbDepartment
            // 
            checkBoxProperties1.ForeColor = SystemColors.ControlText;
            cmbDepartment.CheckBoxProperties = checkBoxProperties1;
            cmbDepartment.DisplayMemberSingleItem = "";
            cmbDepartment.Dock = DockStyle.Fill;
            cmbDepartment.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            cmbDepartment.Location = new Point(3, 3);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(236, 28);
            cmbDepartment.TabIndex = 0;
            // 
            // btnReload
            // 
            btnReload.Cursor = Cursors.Hand;
            btnReload.FillColor = Color.White;
            btnReload.FillColor2 = Color.White;
            btnReload.FillHoverColor = Color.White;
            btnReload.FillPressColor = Color.White;
            btnReload.FillSelectedColor = Color.White;
            btnReload.Font = new Font("Microsoft YaHei", 12F);
            btnReload.ForeDisableColor = Color.White;
            btnReload.Image = Properties.Resources.refresh_24_red;
            btnReload.IsCircle = true;
            btnReload.Location = new Point(20, 13);
            btnReload.Margin = new Padding(2);
            btnReload.MinimumSize = new Size(1, 1);
            btnReload.Name = "btnReload";
            btnReload.RectColor = Color.White;
            btnReload.RectHoverColor = Color.White;
            btnReload.RectPressColor = Color.White;
            btnReload.RectSelectedColor = Color.White;
            btnReload.Size = new Size(40, 40);
            btnReload.Style = Sunny.UI.UIStyle.Custom;
            btnReload.StyleCustomMode = true;
            btnReload.TabIndex = 276;
            btnReload.TipsColor = Color.FromArgb(0, 104, 196);
            btnReload.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReload.Click += btnReload_Click;
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(uiGroupBox1);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Padding = new Padding(5);
            pnBackground.Size = new Size(1079, 591);
            pnBackground.TabIndex = 164;
            // 
            // uc_ManageCourse
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(pnBackground);
            Name = "uc_ManageCourse";
            Size = new Size(1079, 591);
            Load += uc_ManageCourse_Load;
            uiGroupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCourse).EndInit();
            cmsCourse.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnCombobox.ResumeLayout(false);
            pnBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvCourse;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn credit;
        private DataGridViewTextBoxColumn max_student;
        private DataGridViewTextBoxColumn number_class;
        private DataGridViewTextBoxColumn department;
        private Panel panel3;
        private Sunny.UI.UITextBox txtFindByName;
        private Sunny.UI.UISymbolButton btnSearch;
        private Sunny.UI.UIButton btnLoad;
        private Sunny.UI.UIPanel pnCombobox;
        private PresentationControls.CheckBoxComboBox cmbDepartment;
        private Sunny.UI.UISymbolButton btnReload;
        private Panel pnBackground;
        private ContextMenuStrip cmsCourse;
        private ToolStripMenuItem editCourse;
        private ToolStripMenuItem deleteCourse;
        private DataGridViewTextBoxColumn instructor;
    }
}
