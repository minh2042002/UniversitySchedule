namespace UniversitySchedule.View.ManageDepartment
{
    partial class uc_ManageInstructor
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
            pnBackground = new Panel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            panel2 = new Panel();
            panel7 = new Panel();
            dgvInstructor = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            cmsInstructor = new ContextMenuStrip(components);
            moveDepartment = new ToolStripMenuItem();
            manageCourse = new ToolStripMenuItem();
            setHead = new ToolStripMenuItem();
            panel3 = new Panel();
            btnLoad = new Sunny.UI.UIButton();
            pnCombobox = new Sunny.UI.UIPanel();
            cmbDepartment = new PresentationControls.CheckBoxComboBox();
            btnReload = new Sunny.UI.UISymbolButton();
            pnBackground.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInstructor).BeginInit();
            cmsInstructor.SuspendLayout();
            panel3.SuspendLayout();
            pnCombobox.SuspendLayout();
            SuspendLayout();
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(uiGroupBox1);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Padding = new Padding(5);
            pnBackground.Size = new Size(1079, 591);
            pnBackground.TabIndex = 165;
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
            uiGroupBox1.Text = "DANH SÁCH GIẢNG VIÊN";
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
            panel7.Controls.Add(dgvInstructor);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 68);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(1065, 478);
            panel7.TabIndex = 6;
            // 
            // dgvInstructor
            // 
            dgvInstructor.AllowUserToAddRows = false;
            dgvInstructor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle1.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvInstructor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvInstructor.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvInstructor.BackgroundColor = Color.White;
            dgvInstructor.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInstructor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInstructor.ColumnHeadersHeight = 40;
            dgvInstructor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInstructor.Columns.AddRange(new DataGridViewColumn[] { stt, name, phone, email, dob, role, department });
            dgvInstructor.ContextMenuStrip = cmsInstructor;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInstructor.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInstructor.Dock = DockStyle.Fill;
            dgvInstructor.ImeMode = ImeMode.NoControl;
            dgvInstructor.Location = new Point(5, 5);
            dgvInstructor.MultiSelect = false;
            dgvInstructor.Name = "dgvInstructor";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvInstructor.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvInstructor.RowHeadersVisible = false;
            dgvInstructor.RowHeadersWidth = 45;
            dgvInstructor.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle5.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvInstructor.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvInstructor.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvInstructor.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 8.25F);
            dgvInstructor.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvInstructor.RowTemplate.DefaultCellStyle.Padding = new Padding(2, 10, 2, 10);
            dgvInstructor.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvInstructor.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvInstructor.RowTemplate.DividerHeight = 1;
            dgvInstructor.RowTemplate.Height = 55;
            dgvInstructor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInstructor.Size = new Size(1055, 468);
            dgvInstructor.TabIndex = 1;
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
            name.FillWeight = 200F;
            name.HeaderText = "Họ và tên";
            name.MinimumWidth = 200;
            name.Name = "name";
            name.Width = 200;
            // 
            // phone
            // 
            phone.FillWeight = 200F;
            phone.HeaderText = "Số điện thoại";
            phone.MinimumWidth = 200;
            phone.Name = "phone";
            phone.Width = 200;
            // 
            // email
            // 
            email.FillWeight = 300F;
            email.HeaderText = "Email";
            email.MinimumWidth = 300;
            email.Name = "email";
            email.Width = 300;
            // 
            // dob
            // 
            dob.FillWeight = 200F;
            dob.HeaderText = "Ngày sinh";
            dob.MinimumWidth = 200;
            dob.Name = "dob";
            dob.Width = 200;
            // 
            // role
            // 
            role.FillWeight = 150F;
            role.HeaderText = "Chức vụ";
            role.MinimumWidth = 150;
            role.Name = "role";
            role.Width = 150;
            // 
            // department
            // 
            department.FillWeight = 200F;
            department.HeaderText = "Bộ môn";
            department.MinimumWidth = 200;
            department.Name = "department";
            department.Width = 200;
            // 
            // cmsInstructor
            // 
            cmsInstructor.Items.AddRange(new ToolStripItem[] { moveDepartment, manageCourse, setHead });
            cmsInstructor.Name = "cmsCalendar";
            cmsInstructor.Size = new Size(213, 70);
            // 
            // moveDepartment
            // 
            moveDepartment.Image = Properties.Resources.edit_24_red;
            moveDepartment.Name = "moveDepartment";
            moveDepartment.Size = new Size(212, 22);
            moveDepartment.Text = "Chuyển bộ môn";
            moveDepartment.Click += moveDepartment_Click;
            // 
            // manageCourse
            // 
            manageCourse.Image = Properties.Resources.add_24_red;
            manageCourse.Name = "manageCourse";
            manageCourse.Size = new Size(212, 22);
            manageCourse.Text = "Danh sách môn giảng dạy";
            manageCourse.Click += manageCourse_Click;
            // 
            // setHead
            // 
            setHead.Image = Properties.Resources.leader_24_red;
            setHead.Name = "setHead";
            setHead.Size = new Size(212, 22);
            setHead.Text = "Đặt làm trưởng bộ môn";
            setHead.Click += setHead_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoScrollMinSize = new Size(1065, 68);
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(pnCombobox);
            panel3.Controls.Add(btnReload);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 68);
            panel3.TabIndex = 4;
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
            // uc_ManageInstructor
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(pnBackground);
            Name = "uc_ManageInstructor";
            Size = new Size(1079, 591);
            Load += uc_ManageInstructor_Load;
            pnBackground.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInstructor).EndInit();
            cmsInstructor.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnCombobox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackground;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel2;
        private Panel panel7;
        private ContextMenuStrip cmsInstructor;
        private ToolStripMenuItem moveDepartment;
        private Panel panel3;
        private Sunny.UI.UIButton btnLoad;
        private Sunny.UI.UIPanel pnCombobox;
        private PresentationControls.CheckBoxComboBox cmbDepartment;
        private Sunny.UI.UISymbolButton btnReload;
        private DataGridView dgvInstructor;
        private ToolStripMenuItem manageCourse;
        private ToolStripMenuItem setHead;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn department;
    }
}
