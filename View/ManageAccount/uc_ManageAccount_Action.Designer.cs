namespace UniversitySchedule.View.ManageAccount
{
    partial class uc_ManageAccount_Action
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
            dgvUser = new DataGridView();
            stt = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            dob = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            cmsAccount = new ContextMenuStrip(components);
            editInformation = new ToolStripMenuItem();
            deleteUser = new ToolStripMenuItem();
            panel3 = new Panel();
            btnLoad = new Sunny.UI.UIButton();
            pnBackground = new Panel();
            pnButton = new Panel();
            pnHeaderButton = new Panel();
            pnBackButtonAddInstructor = new Panel();
            btnAddInstructor = new Button();
            pnAddInstructor = new Panel();
            pnBottomButton = new Panel();
            btnLogout = new Sunny.UI.UIButton();
            pnMain.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            cmsAccount.SuspendLayout();
            panel3.SuspendLayout();
            pnBackground.SuspendLayout();
            pnButton.SuspendLayout();
            pnHeaderButton.SuspendLayout();
            pnBackButtonAddInstructor.SuspendLayout();
            pnBottomButton.SuspendLayout();
            SuspendLayout();
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
            uiGroupBox1.Text = "DANH SÁCH TÀI KHOẢN";
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
            panel7.Controls.Add(dgvUser);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 68);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(1065, 478);
            panel7.TabIndex = 6;
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToAddRows = false;
            dgvUser.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle1.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvUser.BackgroundColor = Color.White;
            dgvUser.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvUser.ColumnHeadersHeight = 40;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvUser.Columns.AddRange(new DataGridViewColumn[] { stt, username, name, phone, email, dob, role });
            dgvUser.ContextMenuStrip = cmsAccount;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvUser.DefaultCellStyle = dataGridViewCellStyle3;
            dgvUser.Dock = DockStyle.Fill;
            dgvUser.ImeMode = ImeMode.NoControl;
            dgvUser.Location = new Point(5, 5);
            dgvUser.MultiSelect = false;
            dgvUser.Name = "dgvUser";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvUser.RowHeadersVisible = false;
            dgvUser.RowHeadersWidth = 45;
            dgvUser.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle5.Padding = new Padding(2, 10, 2, 10);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvUser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvUser.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dgvUser.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 8.25F);
            dgvUser.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvUser.RowTemplate.DefaultCellStyle.Padding = new Padding(2, 10, 2, 10);
            dgvUser.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvUser.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvUser.RowTemplate.DividerHeight = 1;
            dgvUser.RowTemplate.Height = 55;
            dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUser.Size = new Size(1055, 468);
            dgvUser.TabIndex = 0;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 50;
            stt.Name = "stt";
            stt.Width = 70;
            // 
            // username
            // 
            username.FillWeight = 200F;
            username.HeaderText = "Username";
            username.MinimumWidth = 200;
            username.Name = "username";
            username.Width = 200;
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
            role.HeaderText = "Chức vụ";
            role.Name = "role";
            // 
            // cmsAccount
            // 
            cmsAccount.Items.AddRange(new ToolStripItem[] { editInformation, deleteUser });
            cmsAccount.Name = "cmsCalendar";
            cmsAccount.Size = new Size(179, 48);
            // 
            // editInformation
            // 
            editInformation.Image = Properties.Resources.edit_24_red;
            editInformation.Name = "editInformation";
            editInformation.Size = new Size(178, 22);
            editInformation.Text = "Thông tin tài khoản";
            editInformation.Click += editInformation_Click;
            // 
            // deleteUser
            // 
            deleteUser.Image = Properties.Resources.remove_24_red;
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(178, 22);
            deleteUser.Text = "Xóa tài khoản";
            deleteUser.Click += deleteUser_Click;
            // 
            // panel3
            // 
            panel3.AutoScroll = true;
            panel3.AutoScrollMinSize = new Size(1065, 68);
            panel3.Controls.Add(btnLoad);
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
            btnLoad.Location = new Point(14, 17);
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
            // pnBackground
            // 
            pnBackground.Controls.Add(pnMain);
            pnBackground.Controls.Add(pnButton);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(1364, 591);
            pnBackground.TabIndex = 2;
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
            pnHeaderButton.Controls.Add(pnBackButtonAddInstructor);
            pnHeaderButton.Dock = DockStyle.Fill;
            pnHeaderButton.Location = new Point(0, 0);
            pnHeaderButton.Name = "pnHeaderButton";
            pnHeaderButton.Padding = new Padding(0, 10, 0, 0);
            pnHeaderButton.Size = new Size(285, 488);
            pnHeaderButton.TabIndex = 1;
            // 
            // pnBackButtonAddInstructor
            // 
            pnBackButtonAddInstructor.Controls.Add(btnAddInstructor);
            pnBackButtonAddInstructor.Controls.Add(pnAddInstructor);
            pnBackButtonAddInstructor.Dock = DockStyle.Top;
            pnBackButtonAddInstructor.Location = new Point(0, 10);
            pnBackButtonAddInstructor.Name = "pnBackButtonAddInstructor";
            pnBackButtonAddInstructor.Size = new Size(285, 40);
            pnBackButtonAddInstructor.TabIndex = 164;
            // 
            // btnAddInstructor
            // 
            btnAddInstructor.Cursor = Cursors.Hand;
            btnAddInstructor.Dock = DockStyle.Fill;
            btnAddInstructor.FlatAppearance.BorderSize = 0;
            btnAddInstructor.FlatStyle = FlatStyle.Flat;
            btnAddInstructor.Font = new Font("Segoe UI", 12F);
            btnAddInstructor.ForeColor = Color.FromArgb(28, 28, 28);
            btnAddInstructor.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddInstructor.ImeMode = ImeMode.NoControl;
            btnAddInstructor.Location = new Point(12, 0);
            btnAddInstructor.Name = "btnAddInstructor";
            btnAddInstructor.Padding = new Padding(20, 0, 0, 0);
            btnAddInstructor.Size = new Size(273, 40);
            btnAddInstructor.TabIndex = 162;
            btnAddInstructor.Text = "    Thêm Giảng Viên";
            btnAddInstructor.TextAlign = ContentAlignment.MiddleLeft;
            btnAddInstructor.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddInstructor.UseVisualStyleBackColor = true;
            btnAddInstructor.Click += btnAddInstructor_Click;
            // 
            // pnAddInstructor
            // 
            pnAddInstructor.Dock = DockStyle.Left;
            pnAddInstructor.Location = new Point(0, 0);
            pnAddInstructor.Name = "pnAddInstructor";
            pnAddInstructor.Size = new Size(12, 40);
            pnAddInstructor.TabIndex = 160;
            // 
            // pnBottomButton
            // 
            pnBottomButton.Controls.Add(btnLogout);
            pnBottomButton.Dock = DockStyle.Bottom;
            pnBottomButton.Location = new Point(0, 488);
            pnBottomButton.Name = "pnBottomButton";
            pnBottomButton.Size = new Size(285, 103);
            pnBottomButton.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.FillColor = Color.FromArgb(250, 82, 82);
            btnLogout.FillColor2 = Color.FromArgb(250, 82, 82);
            btnLogout.FillDisableColor = Color.White;
            btnLogout.FillHoverColor = Color.White;
            btnLogout.FillPressColor = Color.White;
            btnLogout.FillSelectedColor = Color.White;
            btnLogout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeDisableColor = Color.DarkGray;
            btnLogout.ForeHoverColor = Color.Black;
            btnLogout.ForePressColor = Color.Black;
            btnLogout.ForeSelectedColor = Color.Black;
            btnLogout.Location = new Point(89, 54);
            btnLogout.MinimumSize = new Size(1, 1);
            btnLogout.Name = "btnLogout";
            btnLogout.Radius = 10;
            btnLogout.RectColor = Color.FromArgb(250, 82, 82);
            btnLogout.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnLogout.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnLogout.RectPressColor = Color.FromArgb(250, 82, 82);
            btnLogout.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnLogout.Size = new Size(106, 33);
            btnLogout.TabIndex = 324;
            btnLogout.Text = "Đăng xuất";
            btnLogout.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogout.Click += btnLogout_Click;
            // 
            // uc_ManageAccount_Action
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            Controls.Add(pnBackground);
            Name = "uc_ManageAccount_Action";
            Size = new Size(1364, 591);
            Load += uc_ManageAccount_Action_Load;
            pnMain.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            cmsAccount.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnBackground.ResumeLayout(false);
            pnButton.ResumeLayout(false);
            pnHeaderButton.ResumeLayout(false);
            pnBackButtonAddInstructor.ResumeLayout(false);
            pnBottomButton.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnBackground;
        private Panel pnButton;
        private Panel pnHeaderButton;
        private Panel pnBackButtonAddInstructor;
        private Button btnAddInstructor;
        private Panel pnAddInstructor;
        private Panel pnBottomButton;
        private ContextMenuStrip cmsAccount;
        private ToolStripMenuItem editInformation;
        private ToolStripMenuItem deleteUser;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel2;
        private Panel panel7;
        private DataGridView dgvUser;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn dob;
        private DataGridViewTextBoxColumn role;
        private Panel panel3;
        private Sunny.UI.UIButton btnLoad;
        private Sunny.UI.UIButton btnLogout;
    }
}
