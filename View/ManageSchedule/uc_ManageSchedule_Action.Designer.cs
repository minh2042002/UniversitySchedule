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
            pnBackground = new Panel();
            pnMain = new Panel();
            gbCalendar = new Sunny.UI.UIGroupBox();
            pnCalendar = new Panel();
            dgvCalendar = new DataGridView();
            timeSlot = new DataGridViewTextBoxColumn();
            monday = new DataGridViewTextBoxColumn();
            tuesday = new DataGridViewTextBoxColumn();
            wednesday = new DataGridViewTextBoxColumn();
            thursday = new DataGridViewTextBoxColumn();
            friday = new DataGridViewTextBoxColumn();
            saturday = new DataGridViewTextBoxColumn();
            sunday = new DataGridViewTextBoxColumn();
            cmsCalendar = new ContextMenuStrip(components);
            showAllCalendar = new ToolStripMenuItem();
            showTeach = new ToolStripMenuItem();
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
            pnBackground.SuspendLayout();
            pnMain.SuspendLayout();
            gbCalendar.SuspendLayout();
            pnCalendar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCalendar).BeginInit();
            cmsCalendar.SuspendLayout();
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
            pnCalendar.Controls.Add(dgvCalendar);
            pnCalendar.Dock = DockStyle.Fill;
            pnCalendar.Location = new Point(5, 32);
            pnCalendar.Name = "pnCalendar";
            pnCalendar.Padding = new Padding(5);
            pnCalendar.Size = new Size(1059, 544);
            pnCalendar.TabIndex = 1;
            pnCalendar.SizeChanged += pnCalendar_SizeChanged;
            // 
            // dgvCalendar
            // 
            dgvCalendar.AllowUserToAddRows = false;
            dgvCalendar.AllowUserToDeleteRows = false;
            dgvCalendar.AllowUserToResizeColumns = false;
            dgvCalendar.AllowUserToResizeRows = false;
            dgvCalendar.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCalendar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCalendar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalendar.Columns.AddRange(new DataGridViewColumn[] { timeSlot, monday, tuesday, wednesday, thursday, friday, saturday, sunday });
            dgvCalendar.ContextMenuStrip = cmsCalendar;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCalendar.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCalendar.Dock = DockStyle.Fill;
            dgvCalendar.Location = new Point(5, 5);
            dgvCalendar.MultiSelect = false;
            dgvCalendar.Name = "dgvCalendar";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCalendar.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCalendar.RowHeadersVisible = false;
            dgvCalendar.Size = new Size(1049, 534);
            dgvCalendar.TabIndex = 0;
            // 
            // timeSlot
            // 
            timeSlot.HeaderText = "";
            timeSlot.MinimumWidth = 100;
            timeSlot.Name = "timeSlot";
            // 
            // monday
            // 
            monday.FillWeight = 140F;
            monday.HeaderText = "Monday";
            monday.MinimumWidth = 140;
            monday.Name = "monday";
            monday.Width = 140;
            // 
            // tuesday
            // 
            tuesday.FillWeight = 140F;
            tuesday.HeaderText = "Tuesday";
            tuesday.MinimumWidth = 140;
            tuesday.Name = "tuesday";
            tuesday.Width = 140;
            // 
            // wednesday
            // 
            wednesday.FillWeight = 140F;
            wednesday.HeaderText = "Wednesday";
            wednesday.MinimumWidth = 140;
            wednesday.Name = "wednesday";
            wednesday.Width = 140;
            // 
            // thursday
            // 
            thursday.FillWeight = 140F;
            thursday.HeaderText = "Thursday";
            thursday.MinimumWidth = 140;
            thursday.Name = "thursday";
            thursday.Width = 140;
            // 
            // friday
            // 
            friday.FillWeight = 140F;
            friday.HeaderText = "Friday";
            friday.MinimumWidth = 140;
            friday.Name = "friday";
            friday.Width = 140;
            // 
            // saturday
            // 
            saturday.FillWeight = 140F;
            saturday.HeaderText = "Saturday";
            saturday.MinimumWidth = 140;
            saturday.Name = "saturday";
            saturday.Width = 140;
            // 
            // sunday
            // 
            sunday.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            sunday.FillWeight = 140F;
            sunday.HeaderText = "Sunday";
            sunday.MinimumWidth = 140;
            sunday.Name = "sunday";
            // 
            // cmsCalendar
            // 
            cmsCalendar.Items.AddRange(new ToolStripItem[] { showAllCalendar, showTeach });
            cmsCalendar.Name = "cmsCalendar";
            cmsCalendar.Size = new Size(240, 48);
            // 
            // showAllCalendar
            // 
            showAllCalendar.Name = "showAllCalendar";
            showAllCalendar.Size = new Size(239, 22);
            showAllCalendar.Text = "Hiển thị toàn bộ thời khóa biểu";
            // 
            // showTeach
            // 
            showTeach.Name = "showTeach";
            showTeach.Size = new Size(239, 22);
            showTeach.Text = "Chỉ hiển thị lịch dạy";
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
            ((System.ComponentModel.ISupportInitialize)dgvCalendar).EndInit();
            cmsCalendar.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnHeaderButton.ResumeLayout(false);
            pnBackButtonSchedule.ResumeLayout(false);
            pnBottomButton.ResumeLayout(false);
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
        private DataGridView dgvCalendar;
        private DataGridViewTextBoxColumn timeSlot;
        private DataGridViewTextBoxColumn monday;
        private DataGridViewTextBoxColumn tuesday;
        private DataGridViewTextBoxColumn wednesday;
        private DataGridViewTextBoxColumn thursday;
        private DataGridViewTextBoxColumn friday;
        private DataGridViewTextBoxColumn saturday;
        private DataGridViewTextBoxColumn sunday;
        private ContextMenuStrip cmsCalendar;
        private ToolStripMenuItem showAllCalendar;
        private ToolStripMenuItem showTeach;
    }
}
