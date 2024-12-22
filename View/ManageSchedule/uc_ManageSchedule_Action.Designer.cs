namespace UniversitySchedule.View.ManageSchedule
{
    partial class uc_ManageSchedule_Action
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
            pnBackground = new Panel();
            pnMain = new Panel();
            gbCalendar = new Sunny.UI.UIGroupBox();
            pnCalendar = new Panel();
            dgvSchedule = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            meeting_time = new DataGridViewTextBoxColumn();
            room = new DataGridViewTextBoxColumn();
            instructor = new DataGridViewTextBoxColumn();
            max_student = new DataGridViewTextBoxColumn();
            pnButton = new Panel();
            pnHeaderButton = new Panel();
            pnBackButtonSchedule = new Panel();
            btnSchedule = new Button();
            pnSchedule = new Panel();
            pnBottomButton = new Panel();
            uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            btnTerms = new Sunny.UI.UISymbolButton();
            uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            btnAccountInformation = new Button();
            cmsCalendar = new ContextMenuStrip(components);
            refreshToolStripMenuItem = new ToolStripMenuItem();
            showAllCalendar = new ToolStripMenuItem();
            showTeach = new ToolStripMenuItem();
            pnBackground.SuspendLayout();
            pnMain.SuspendLayout();
            gbCalendar.SuspendLayout();
            pnCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            pnButton.SuspendLayout();
            pnHeaderButton.SuspendLayout();
            pnBackButtonSchedule.SuspendLayout();
            pnBottomButton.SuspendLayout();
            cmsCalendar.SuspendLayout();
            SuspendLayout();
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(pnMain);
            pnBackground.Controls.Add(pnButton);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(1364, 591);
            pnBackground.TabIndex = 0;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(gbCalendar);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(285, 0);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(5);
            pnMain.Size = new Size(1079, 591);
            pnMain.TabIndex = 2;
            // 
            // gbCalendar
            // 
            gbCalendar.Controls.Add(pnCalendar);
            gbCalendar.Dock = DockStyle.Fill;
            gbCalendar.FillColor = Color.Transparent;
            gbCalendar.FillColor2 = Color.Transparent;
            gbCalendar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCalendar.Location = new Point(5, 5);
            gbCalendar.Margin = new Padding(4, 5, 4, 5);
            gbCalendar.MinimumSize = new Size(1, 1);
            gbCalendar.Name = "gbCalendar";
            gbCalendar.Padding = new Padding(5, 32, 5, 5);
            gbCalendar.Radius = 10;
            gbCalendar.RectColor = Color.FromArgb(250, 82, 82);
            gbCalendar.Size = new Size(1069, 581);
            gbCalendar.TabIndex = 2;
            gbCalendar.Text = "THỜI KHÓA BIỂU";
            gbCalendar.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // pnCalendar
            // 
            pnCalendar.Controls.Add(dgvSchedule);
            pnCalendar.Dock = DockStyle.Fill;
            pnCalendar.Location = new Point(5, 32);
            pnCalendar.Name = "pnCalendar";
            pnCalendar.Padding = new Padding(5);
            pnCalendar.Size = new Size(1059, 544);
            pnCalendar.TabIndex = 1;
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle1.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvSchedule.BackgroundColor = Color.White;
            dgvSchedule.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSchedule.ColumnHeadersHeight = 40;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { stt, department, course, day, meeting_time, room, instructor, max_student });
            dgvSchedule.ContextMenuStrip = cmsCalendar;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSchedule.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.ImeMode = ImeMode.NoControl;
            dgvSchedule.Location = new Point(5, 5);
            dgvSchedule.MultiSelect = false;
            dgvSchedule.Name = "dgvSchedule";
            dgvSchedule.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.RowHeadersWidth = 45;
            dgvSchedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle5.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvSchedule.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvSchedule.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvSchedule.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 8.25F);
            dgvSchedule.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvSchedule.RowTemplate.DefaultCellStyle.Padding = new Padding(2, 10, 2, 10);
            dgvSchedule.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvSchedule.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSchedule.RowTemplate.DividerHeight = 1;
            dgvSchedule.RowTemplate.Height = 55;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Size = new Size(1049, 534);
            dgvSchedule.TabIndex = 1;
            // 
            // stt
            // 
            stt.FillWeight = 50F;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 50;
            stt.Name = "stt";
            stt.ReadOnly = true;
            stt.Width = 50;
            // 
            // department
            // 
            department.FillWeight = 200F;
            department.HeaderText = "Bộ môn";
            department.MinimumWidth = 200;
            department.Name = "department";
            department.ReadOnly = true;
            department.Width = 200;
            // 
            // course
            // 
            course.FillWeight = 300F;
            course.HeaderText = "Môn học";
            course.MinimumWidth = 300;
            course.Name = "course";
            course.ReadOnly = true;
            course.Width = 300;
            // 
            // day
            // 
            day.HeaderText = "Thứ";
            day.MinimumWidth = 100;
            day.Name = "day";
            day.ReadOnly = true;
            // 
            // meeting_time
            // 
            meeting_time.FillWeight = 200F;
            meeting_time.HeaderText = "Kíp học";
            meeting_time.MinimumWidth = 200;
            meeting_time.Name = "meeting_time";
            meeting_time.ReadOnly = true;
            meeting_time.Width = 200;
            // 
            // room
            // 
            room.FillWeight = 150F;
            room.HeaderText = "Phòng học";
            room.MinimumWidth = 150;
            room.Name = "room";
            room.ReadOnly = true;
            room.Width = 150;
            // 
            // instructor
            // 
            instructor.FillWeight = 200F;
            instructor.HeaderText = "Giảng viên";
            instructor.MinimumWidth = 200;
            instructor.Name = "instructor";
            instructor.ReadOnly = true;
            instructor.Width = 200;
            // 
            // max_student
            // 
            max_student.FillWeight = 200F;
            max_student.HeaderText = "Số lượng sinh viên";
            max_student.MinimumWidth = 200;
            max_student.Name = "max_student";
            max_student.ReadOnly = true;
            max_student.Width = 200;
            // 
            // pnButton
            // 
            pnButton.Controls.Add(pnHeaderButton);
            pnButton.Controls.Add(pnBottomButton);
            pnButton.Dock = DockStyle.Left;
            pnButton.Location = new Point(0, 0);
            pnButton.MaximumSize = new Size(285, 591);
            pnButton.Name = "pnButton";
            pnButton.Size = new Size(285, 591);
            pnButton.TabIndex = 0;
            // 
            // pnHeaderButton
            // 
            pnHeaderButton.Controls.Add(pnBackButtonSchedule);
            pnHeaderButton.Dock = DockStyle.Fill;
            pnHeaderButton.Location = new Point(0, 0);
            pnHeaderButton.Name = "pnHeaderButton";
            pnHeaderButton.Padding = new Padding(0, 10, 0, 0);
            pnHeaderButton.Size = new Size(285, 488);
            pnHeaderButton.TabIndex = 1;
            // 
            // pnBackButtonSchedule
            // 
            pnBackButtonSchedule.Controls.Add(btnSchedule);
            pnBackButtonSchedule.Controls.Add(pnSchedule);
            pnBackButtonSchedule.Dock = DockStyle.Top;
            pnBackButtonSchedule.Location = new Point(0, 10);
            pnBackButtonSchedule.Name = "pnBackButtonSchedule";
            pnBackButtonSchedule.Size = new Size(285, 40);
            pnBackButtonSchedule.TabIndex = 164;
            // 
            // btnSchedule
            // 
            btnSchedule.Cursor = Cursors.Hand;
            btnSchedule.Dock = DockStyle.Fill;
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 12F);
            btnSchedule.ForeColor = Color.FromArgb(28, 28, 28);
            btnSchedule.ImageAlign = ContentAlignment.MiddleLeft;
            btnSchedule.ImeMode = ImeMode.NoControl;
            btnSchedule.Location = new Point(12, 0);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Padding = new Padding(20, 0, 0, 0);
            btnSchedule.Size = new Size(273, 40);
            btnSchedule.TabIndex = 162;
            btnSchedule.Text = "    Thời Khóa Biểu";
            btnSchedule.TextAlign = ContentAlignment.MiddleLeft;
            btnSchedule.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSchedule.UseVisualStyleBackColor = true;
            // 
            // pnSchedule
            // 
            pnSchedule.Dock = DockStyle.Left;
            pnSchedule.Location = new Point(0, 0);
            pnSchedule.Name = "pnSchedule";
            pnSchedule.Size = new Size(12, 40);
            pnSchedule.TabIndex = 160;
            // 
            // pnBottomButton
            // 
            pnBottomButton.Controls.Add(uiSymbolButton5);
            pnBottomButton.Controls.Add(btnTerms);
            pnBottomButton.Controls.Add(uiSymbolButton6);
            pnBottomButton.Controls.Add(btnAccountInformation);
            pnBottomButton.Dock = DockStyle.Bottom;
            pnBottomButton.Location = new Point(0, 488);
            pnBottomButton.Name = "pnBottomButton";
            pnBottomButton.Size = new Size(285, 103);
            pnBottomButton.TabIndex = 1;
            // 
            // uiSymbolButton5
            // 
            uiSymbolButton5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            uiSymbolButton5.Cursor = Cursors.Hand;
            uiSymbolButton5.FillColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton5.FillColor2 = SystemColors.Control;
            uiSymbolButton5.FillColorGradientDirection = FlowDirection.LeftToRight;
            uiSymbolButton5.FillHoverColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton5.FillPressColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton5.FillSelectedColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton5.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            uiSymbolButton5.Location = new Point(114, 75);
            uiSymbolButton5.Margin = new Padding(2);
            uiSymbolButton5.MinimumSize = new Size(1, 1);
            uiSymbolButton5.Name = "uiSymbolButton5";
            uiSymbolButton5.Radius = 10;
            uiSymbolButton5.RectColor = Color.Transparent;
            uiSymbolButton5.RectHoverColor = Color.Transparent;
            uiSymbolButton5.RectPressColor = Color.Transparent;
            uiSymbolButton5.RectSelectedColor = Color.Transparent;
            uiSymbolButton5.Size = new Size(55, 22);
            uiSymbolButton5.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton5.Symbol = 0;
            uiSymbolButton5.SymbolColor = Color.Silver;
            uiSymbolButton5.TabIndex = 292;
            uiSymbolButton5.Text = "PRIVACY";
            uiSymbolButton5.TipsColor = Color.RoyalBlue;
            uiSymbolButton5.TipsFont = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            // 
            // btnTerms
            // 
            btnTerms.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnTerms.Cursor = Cursors.Hand;
            btnTerms.FillColor = Color.FromArgb(250, 82, 82);
            btnTerms.FillColor2 = SystemColors.Control;
            btnTerms.FillColorGradientDirection = FlowDirection.LeftToRight;
            btnTerms.FillHoverColor = Color.FromArgb(250, 82, 82);
            btnTerms.FillPressColor = Color.FromArgb(250, 82, 82);
            btnTerms.FillSelectedColor = Color.FromArgb(250, 82, 82);
            btnTerms.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            btnTerms.Location = new Point(173, 75);
            btnTerms.Margin = new Padding(2);
            btnTerms.MinimumSize = new Size(1, 1);
            btnTerms.Name = "btnTerms";
            btnTerms.Radius = 10;
            btnTerms.RectColor = Color.Transparent;
            btnTerms.RectHoverColor = Color.Transparent;
            btnTerms.RectPressColor = Color.Transparent;
            btnTerms.RectSelectedColor = Color.Transparent;
            btnTerms.Size = new Size(59, 22);
            btnTerms.Style = Sunny.UI.UIStyle.Custom;
            btnTerms.Symbol = 0;
            btnTerms.SymbolColor = Color.Silver;
            btnTerms.TabIndex = 291;
            btnTerms.Text = "TERMS";
            btnTerms.TipsColor = Color.RoyalBlue;
            btnTerms.TipsFont = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            // 
            // uiSymbolButton6
            // 
            uiSymbolButton6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            uiSymbolButton6.Cursor = Cursors.Hand;
            uiSymbolButton6.FillColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.FillColor2 = SystemColors.Control;
            uiSymbolButton6.FillColorGradientDirection = FlowDirection.LeftToRight;
            uiSymbolButton6.FillHoverColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.FillPressColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.FillSelectedColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            uiSymbolButton6.Location = new Point(53, 75);
            uiSymbolButton6.Margin = new Padding(2);
            uiSymbolButton6.MinimumSize = new Size(1, 1);
            uiSymbolButton6.Name = "uiSymbolButton6";
            uiSymbolButton6.Radius = 10;
            uiSymbolButton6.RectColor = Color.Transparent;
            uiSymbolButton6.RectHoverColor = Color.Transparent;
            uiSymbolButton6.RectPressColor = Color.Transparent;
            uiSymbolButton6.RectSelectedColor = Color.Transparent;
            uiSymbolButton6.Size = new Size(57, 22);
            uiSymbolButton6.Style = Sunny.UI.UIStyle.Custom;
            uiSymbolButton6.Symbol = 0;
            uiSymbolButton6.SymbolColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.SymbolHoverColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.SymbolPressColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.SymbolSelectedColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.TabIndex = 290;
            uiSymbolButton6.Text = "STATUS";
            uiSymbolButton6.TipsColor = Color.FromArgb(250, 82, 82);
            uiSymbolButton6.TipsFont = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            // 
            // btnAccountInformation
            // 
            btnAccountInformation.BackgroundImageLayout = ImageLayout.None;
            btnAccountInformation.Cursor = Cursors.Hand;
            btnAccountInformation.FlatAppearance.BorderSize = 0;
            btnAccountInformation.FlatStyle = FlatStyle.Flat;
            btnAccountInformation.Font = new Font("Segoe UI", 9F);
            btnAccountInformation.ForeColor = Color.FromArgb(28, 28, 28);
            btnAccountInformation.Image = Properties.Resources.settings_16;
            btnAccountInformation.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccountInformation.ImeMode = ImeMode.NoControl;
            btnAccountInformation.Location = new Point(55, 35);
            btnAccountInformation.Name = "btnAccountInformation";
            btnAccountInformation.Size = new Size(166, 24);
            btnAccountInformation.TabIndex = 280;
            btnAccountInformation.Text = "   Thông tin tài khoản";
            btnAccountInformation.TextAlign = ContentAlignment.MiddleLeft;
            btnAccountInformation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccountInformation.UseVisualStyleBackColor = true;
            // 
            // cmsCalendar
            // 
            cmsCalendar.Items.AddRange(new ToolStripItem[] { refreshToolStripMenuItem, showAllCalendar, showTeach });
            cmsCalendar.Name = "cmsCalendar";
            cmsCalendar.Size = new Size(240, 70);
            // 
            // refreshToolStripMenuItem
            // 
            refreshToolStripMenuItem.Image = Properties.Resources.refresh_24_red;
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(239, 22);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            // 
            // showAllCalendar
            // 
            showAllCalendar.Image = Properties.Resources.calendar_24_red;
            showAllCalendar.Name = "showAllCalendar";
            showAllCalendar.Size = new Size(239, 22);
            showAllCalendar.Text = "Hiển thị toàn bộ thời khóa biểu";
            showAllCalendar.Click += showAllCalendar_Click;
            // 
            // showTeach
            // 
            showTeach.Image = Properties.Resources.lecture_hall_24_red;
            showTeach.Name = "showTeach";
            showTeach.Size = new Size(239, 22);
            showTeach.Text = "Chỉ hiển thị lịch dạy";
            showTeach.Click += showTeach_Click;
            // 
            // uc_ManageSchedule_Action
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoScroll = true;
            BackColor = Color.White;
            Controls.Add(pnBackground);
            Name = "uc_ManageSchedule_Action";
            Size = new Size(1364, 591);
            Load += uc_ManageSchedule_Action_Load;
            pnBackground.ResumeLayout(false);
            pnMain.ResumeLayout(false);
            gbCalendar.ResumeLayout(false);
            pnCalendar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            pnButton.ResumeLayout(false);
            pnHeaderButton.ResumeLayout(false);
            pnBackButtonSchedule.ResumeLayout(false);
            pnBottomButton.ResumeLayout(false);
            cmsCalendar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnBackground;
        private Panel pnButton;
        private Panel pnHeaderButton;
        private Panel pnBackButtonSchedule;
        private Button btnSchedule;
        private Panel pnSchedule;
        private Panel pnBottomButton;
        private Button btnAccountInformation;
        private Panel pnCalendar;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UISymbolButton btnTerms;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Panel pnMain;
        private Sunny.UI.UIGroupBox gbCalendar;
        private ContextMenuStrip cmsCalendar;
        private ToolStripMenuItem showAllCalendar;
        private ToolStripMenuItem showTeach;
        private DataGridView dgvSchedule;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn meeting_time;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn instructor;
        private DataGridViewTextBoxColumn max_student;
        private ToolStripMenuItem refreshToolStripMenuItem;
    }
}
