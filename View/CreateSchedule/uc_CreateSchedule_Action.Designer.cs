namespace UniversitySchedule.View.CreateSchedule
{
    partial class uc_CreateSchedule_Action
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            pnBackground = new Panel();
            pnMain = new Panel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            panel2 = new Panel();
            panel7 = new Panel();
            dgvSchedule = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            department = new DataGridViewTextBoxColumn();
            course = new DataGridViewTextBoxColumn();
            day = new DataGridViewTextBoxColumn();
            meeting_time = new DataGridViewTextBoxColumn();
            room = new DataGridViewTextBoxColumn();
            instructor = new DataGridViewTextBoxColumn();
            max_student = new DataGridViewTextBoxColumn();
            cmsSchedule = new ContextMenuStrip(components);
            showConsole = new ToolStripMenuItem();
            panel3 = new Panel();
            btnExportExcel = new Sunny.UI.UIButton();
            btnCreateSchedule = new Sunny.UI.UIButton();
            btnSave = new Sunny.UI.UIButton();
            pnButton = new Panel();
            pnHeaderButton = new Panel();
            panel4 = new Panel();
            pnBackButtonSchedule = new Panel();
            btnSchedule = new Button();
            pnSchedule = new Panel();
            pnBottomButton = new Panel();
            uiSymbolButton5 = new Sunny.UI.UISymbolButton();
            btnTerms = new Sunny.UI.UISymbolButton();
            uiSymbolButton6 = new Sunny.UI.UISymbolButton();
            btnAccountInformation = new Button();
            pnBackground.SuspendLayout();
            pnMain.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            cmsSchedule.SuspendLayout();
            panel3.SuspendLayout();
            pnButton.SuspendLayout();
            pnHeaderButton.SuspendLayout();
            pnBackButtonSchedule.SuspendLayout();
            pnBottomButton.SuspendLayout();
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
            pnBackground.TabIndex = 3;
            // 
            // pnMain
            // 
            pnMain.Controls.Add(uiGroupBox1);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(285, 0);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(5);
            pnMain.Size = new Size(1079, 591);
            pnMain.TabIndex = 2;
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
            uiGroupBox1.TabIndex = 165;
            uiGroupBox1.Text = "THỜI KHÓA BIỂU";
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
            panel7.Controls.Add(dgvSchedule);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 77);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(1065, 469);
            panel7.TabIndex = 6;
            // 
            // dgvSchedule
            // 
            dgvSchedule.AllowUserToAddRows = false;
            dgvSchedule.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle6.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvSchedule.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvSchedule.BackgroundColor = Color.White;
            dgvSchedule.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvSchedule.ColumnHeadersHeight = 40;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { stt, department, course, day, meeting_time, room, instructor, max_student });
            dgvSchedule.ContextMenuStrip = cmsSchedule;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvSchedule.DefaultCellStyle = dataGridViewCellStyle8;
            dgvSchedule.Dock = DockStyle.Fill;
            dgvSchedule.ImeMode = ImeMode.NoControl;
            dgvSchedule.Location = new Point(5, 5);
            dgvSchedule.MultiSelect = false;
            dgvSchedule.Name = "dgvSchedule";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvSchedule.RowHeadersVisible = false;
            dgvSchedule.RowHeadersWidth = 45;
            dgvSchedule.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle10.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dgvSchedule.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvSchedule.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvSchedule.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 8.25F);
            dgvSchedule.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvSchedule.RowTemplate.DefaultCellStyle.Padding = new Padding(2, 10, 2, 10);
            dgvSchedule.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvSchedule.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvSchedule.RowTemplate.DividerHeight = 1;
            dgvSchedule.RowTemplate.Height = 55;
            dgvSchedule.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSchedule.Size = new Size(1055, 459);
            dgvSchedule.TabIndex = 0;
            // 
            // stt
            // 
            stt.FillWeight = 50F;
            stt.HeaderText = "STT";
            stt.MinimumWidth = 50;
            stt.Name = "stt";
            stt.Width = 50;
            // 
            // department
            // 
            department.FillWeight = 200F;
            department.HeaderText = "Bộ môn";
            department.MinimumWidth = 200;
            department.Name = "department";
            department.Width = 200;
            // 
            // course
            // 
            course.FillWeight = 200F;
            course.HeaderText = "Môn học";
            course.MinimumWidth = 200;
            course.Name = "course";
            course.Width = 200;
            // 
            // day
            // 
            day.FillWeight = 70F;
            day.HeaderText = "Thứ";
            day.MinimumWidth = 70;
            day.Name = "day";
            day.Width = 70;
            // 
            // meeting_time
            // 
            meeting_time.FillWeight = 200F;
            meeting_time.HeaderText = "Kíp học";
            meeting_time.MinimumWidth = 200;
            meeting_time.Name = "meeting_time";
            meeting_time.Width = 200;
            // 
            // room
            // 
            room.FillWeight = 150F;
            room.HeaderText = "Phòng học";
            room.MinimumWidth = 150;
            room.Name = "room";
            room.Width = 150;
            // 
            // instructor
            // 
            instructor.FillWeight = 200F;
            instructor.HeaderText = "Giảng viên";
            instructor.MinimumWidth = 200;
            instructor.Name = "instructor";
            instructor.Width = 200;
            // 
            // max_student
            // 
            max_student.FillWeight = 200F;
            max_student.HeaderText = "Số lượng sinh viên";
            max_student.MinimumWidth = 200;
            max_student.Name = "max_student";
            max_student.Width = 200;
            // 
            // cmsSchedule
            // 
            cmsSchedule.Items.AddRange(new ToolStripItem[] { showConsole });
            cmsSchedule.Name = "cmsCalendar";
            cmsSchedule.Size = new Size(242, 48);
            // 
            // showConsole
            // 
            showConsole.Image = Properties.Resources.schedule_24_red;
            showConsole.Name = "showConsole";
            showConsole.Size = new Size(241, 22);
            showConsole.Text = "Xem console tạo thời khóa biểu";
            showConsole.Click += showConsole_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoScrollMinSize = new Size(1065, 68);
            panel3.Controls.Add(btnExportExcel);
            panel3.Controls.Add(btnCreateSchedule);
            panel3.Controls.Add(btnSave);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 77);
            panel3.TabIndex = 4;
            // 
            // btnExportExcel
            // 
            btnExportExcel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExportExcel.FillColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.FillColor2 = Color.FromArgb(250, 82, 82);
            btnExportExcel.FillDisableColor = Color.White;
            btnExportExcel.FillHoverColor = Color.White;
            btnExportExcel.FillPressColor = Color.White;
            btnExportExcel.FillSelectedColor = Color.White;
            btnExportExcel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportExcel.ForeHoverColor = Color.Black;
            btnExportExcel.ForePressColor = Color.Black;
            btnExportExcel.ForeSelectedColor = Color.Black;
            btnExportExcel.Location = new Point(887, 18);
            btnExportExcel.MinimumSize = new Size(1, 1);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Radius = 10;
            btnExportExcel.RectColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectPressColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.Size = new Size(149, 33);
            btnExportExcel.TabIndex = 323;
            btnExportExcel.Text = "Xuất File Excel";
            btnExportExcel.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // btnCreateSchedule
            // 
            btnCreateSchedule.FillColor = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.FillColor2 = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.FillDisableColor = Color.White;
            btnCreateSchedule.FillHoverColor = Color.White;
            btnCreateSchedule.FillPressColor = Color.White;
            btnCreateSchedule.FillSelectedColor = Color.White;
            btnCreateSchedule.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateSchedule.ForeHoverColor = Color.Black;
            btnCreateSchedule.ForePressColor = Color.Black;
            btnCreateSchedule.ForeSelectedColor = Color.Black;
            btnCreateSchedule.Location = new Point(14, 18);
            btnCreateSchedule.MinimumSize = new Size(1, 1);
            btnCreateSchedule.Name = "btnCreateSchedule";
            btnCreateSchedule.Radius = 10;
            btnCreateSchedule.RectColor = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.RectPressColor = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnCreateSchedule.Size = new Size(192, 33);
            btnCreateSchedule.TabIndex = 322;
            btnCreateSchedule.Text = "Tạo Thời Khóa Biểu";
            btnCreateSchedule.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnCreateSchedule.Click += btnCreateSchedule_Click;
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
            btnSave.Location = new Point(236, 18);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.RectColor = Color.FromArgb(250, 82, 82);
            btnSave.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnSave.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnSave.RectPressColor = Color.FromArgb(250, 82, 82);
            btnSave.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnSave.Size = new Size(192, 33);
            btnSave.TabIndex = 321;
            btnSave.Text = "Lưu Thời Khóa Biểu";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
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
            pnHeaderButton.Controls.Add(panel4);
            pnHeaderButton.Controls.Add(pnBackButtonSchedule);
            pnHeaderButton.Dock = DockStyle.Fill;
            pnHeaderButton.Location = new Point(0, 0);
            pnHeaderButton.Name = "pnHeaderButton";
            pnHeaderButton.Padding = new Padding(0, 10, 0, 0);
            pnHeaderButton.Size = new Size(285, 488);
            pnHeaderButton.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(285, 15);
            panel4.TabIndex = 167;
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
            btnSchedule.Text = "    Tạo Thời Khóa Biểu";
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
            uiSymbolButton5.Location = new Point(114, 84);
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
            btnTerms.Location = new Point(173, 84);
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
            uiSymbolButton6.Location = new Point(53, 84);
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
            // uc_CreateSchedule_Action
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(pnBackground);
            Name = "uc_CreateSchedule_Action";
            Size = new Size(1364, 591);
            Load += uc_CreateSchedule_Action_Load;
            pnBackground.ResumeLayout(false);
            pnMain.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            cmsSchedule.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnHeaderButton.ResumeLayout(false);
            pnBackButtonSchedule.ResumeLayout(false);
            pnBottomButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnBackground;
        private Panel pnMain;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvSchedule;
        private ContextMenuStrip cmsSchedule;
        private ToolStripMenuItem showConsole;
        private Panel panel3;
        private Sunny.UI.UIButton btnSave;
        private Panel pnButton;
        private Panel pnHeaderButton;
        private Panel pnBackButtonSchedule;
        private Button btnSchedule;
        private Panel pnSchedule;
        private Panel pnBottomButton;
        private Sunny.UI.UISymbolButton uiSymbolButton5;
        private Sunny.UI.UISymbolButton btnTerms;
        private Sunny.UI.UISymbolButton uiSymbolButton6;
        private Button btnAccountInformation;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn meeting_time;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn instructor;
        private DataGridViewTextBoxColumn max_student;
        private Sunny.UI.UIButton btnCreateSchedule;
        private Panel panel4;
        private Sunny.UI.UIButton btnExportExcel;
    }
}
