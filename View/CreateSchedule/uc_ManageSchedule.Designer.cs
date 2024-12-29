namespace UniversitySchedule.View.CreateSchedule
{
    partial class uc_ManageSchedule
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
            setActive = new ToolStripMenuItem();
            panel3 = new Panel();
            cmbSchedule = new Sunny.UI.UIComboBox();
            btnLoad = new Sunny.UI.UIButton();
            btnReload = new Sunny.UI.UISymbolButton();
            btnExportExcel = new Sunny.UI.UIButton();
            pnMain.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).BeginInit();
            cmsSchedule.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(uiGroupBox1);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(5);
            pnMain.Size = new Size(1079, 591);
            pnMain.TabIndex = 3;
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSchedule.ColumnHeadersHeight = 40;
            dgvSchedule.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvSchedule.Columns.AddRange(new DataGridViewColumn[] { stt, department, course, day, meeting_time, room, instructor, max_student });
            dgvSchedule.ContextMenuStrip = cmsSchedule;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(250, 82, 82);
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
            dgvSchedule.Size = new Size(1055, 459);
            dgvSchedule.TabIndex = 0;
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
            // cmsSchedule
            // 
            cmsSchedule.Items.AddRange(new ToolStripItem[] { setActive });
            cmsSchedule.Name = "cmsCalendar";
            cmsSchedule.Size = new Size(257, 26);
            // 
            // setActive
            // 
            setActive.Image = Properties.Resources.schedule_24_red;
            setActive.Name = "setActive";
            setActive.Size = new Size(256, 22);
            setActive.Text = "Lưu làm thời khóa biểu chính thức";
            setActive.Click += setActive_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoScrollMinSize = new Size(1065, 68);
            panel3.Controls.Add(cmbSchedule);
            panel3.Controls.Add(btnLoad);
            panel3.Controls.Add(btnReload);
            panel3.Controls.Add(btnExportExcel);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1065, 77);
            panel3.TabIndex = 4;
            // 
            // cmbSchedule
            // 
            cmbSchedule.DataSource = null;
            cmbSchedule.FillColor = Color.White;
            cmbSchedule.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cmbSchedule.ItemHoverColor = Color.FromArgb(250, 82, 82);
            cmbSchedule.ItemRectColor = Color.FromArgb(250, 82, 82);
            cmbSchedule.ItemSelectBackColor = Color.White;
            cmbSchedule.ItemSelectForeColor = Color.Black;
            cmbSchedule.Location = new Point(54, 22);
            cmbSchedule.Margin = new Padding(4, 5, 4, 5);
            cmbSchedule.MinimumSize = new Size(63, 0);
            cmbSchedule.Name = "cmbSchedule";
            cmbSchedule.Padding = new Padding(0, 0, 30, 2);
            cmbSchedule.Radius = 10;
            cmbSchedule.RectColor = Color.FromArgb(250, 82, 82);
            cmbSchedule.Size = new Size(220, 33);
            cmbSchedule.SymbolSize = 24;
            cmbSchedule.TabIndex = 326;
            cmbSchedule.TextAlignment = ContentAlignment.MiddleLeft;
            cmbSchedule.Watermark = "";
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
            btnLoad.Location = new Point(291, 22);
            btnLoad.MinimumSize = new Size(1, 1);
            btnLoad.Name = "btnLoad";
            btnLoad.Radius = 10;
            btnLoad.RectColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectPressColor = Color.FromArgb(250, 82, 82);
            btnLoad.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnLoad.Size = new Size(92, 33);
            btnLoad.TabIndex = 325;
            btnLoad.Text = "LOAD";
            btnLoad.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLoad.Click += btnLoad_Click;
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
            btnReload.Location = new Point(5, 18);
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
            btnReload.TabIndex = 324;
            btnReload.TipsColor = Color.FromArgb(0, 104, 196);
            btnReload.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnReload.Click += btnReload_Click;
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
            btnExportExcel.ForeDisableColor = Color.DarkGray;
            btnExportExcel.ForeHoverColor = Color.Black;
            btnExportExcel.ForePressColor = Color.Black;
            btnExportExcel.ForeSelectedColor = Color.Black;
            btnExportExcel.Location = new Point(877, 22);
            btnExportExcel.MinimumSize = new Size(1, 1);
            btnExportExcel.Name = "btnExportExcel";
            btnExportExcel.Radius = 10;
            btnExportExcel.RectColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectPressColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnExportExcel.Size = new Size(165, 33);
            btnExportExcel.TabIndex = 323;
            btnExportExcel.Text = "Xuất File Excel";
            btnExportExcel.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnExportExcel.Click += btnExportExcel_Click;
            // 
            // uc_ManageSchedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnMain);
            ForeColor = Color.Transparent;
            Name = "uc_ManageSchedule";
            Size = new Size(1079, 591);
            Load += uc_ManageSchedule_Load;
            pnMain.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSchedule).EndInit();
            cmsSchedule.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvSchedule;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn department;
        private DataGridViewTextBoxColumn course;
        private DataGridViewTextBoxColumn day;
        private DataGridViewTextBoxColumn meeting_time;
        private DataGridViewTextBoxColumn room;
        private DataGridViewTextBoxColumn instructor;
        private DataGridViewTextBoxColumn max_student;
        private Panel panel3;
        private Sunny.UI.UIComboBox cmbSchedule;
        private Sunny.UI.UIButton btnLoad;
        private Sunny.UI.UISymbolButton btnReload;
        private Sunny.UI.UIButton btnExportExcel;
        private ContextMenuStrip cmsSchedule;
        private ToolStripMenuItem setActive;
    }
}
