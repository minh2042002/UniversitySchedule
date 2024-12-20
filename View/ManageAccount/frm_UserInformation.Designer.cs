namespace UniversitySchedule.View.ManageAccount
{
    partial class frm_UserInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserInformation));
            lblUsername = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            txtFullName = new Sunny.UI.UITextBox();
            txtPhone = new Sunny.UI.UITextBox();
            bindingSource1 = new BindingSource(components);
            label1 = new Label();
            panel2 = new Panel();
            pnInformation = new Panel();
            uiLabel3 = new Sunny.UI.UILabel();
            dpDayOfBirth = new Sunny.UI.UIDatePicker();
            uiLabel2 = new Sunny.UI.UILabel();
            txtEmail = new Sunny.UI.UITextBox();
            btnSave = new Sunny.UI.UIButton();
            pnHide = new Panel();
            pnAccount = new Panel();
            uiLabel4 = new Sunny.UI.UILabel();
            txtUsername = new Sunny.UI.UITextBox();
            uiLabel5 = new Sunny.UI.UILabel();
            txtPassword = new Sunny.UI.UITextBox();
            panel1 = new Panel();
            panel6 = new Panel();
            pnBackground = new Panel();
            pnDepartment = new Panel();
            cmbDepartment = new Sunny.UI.UIComboBox();
            uiLabel6 = new Sunny.UI.UILabel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            pnInformation.SuspendLayout();
            pnAccount.SuspendLayout();
            panel1.SuspendLayout();
            panel6.SuspendLayout();
            pnBackground.SuspendLayout();
            pnDepartment.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(23, 28);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(112, 23);
            lblUsername.TabIndex = 11;
            lblUsername.Text = "Họ và tên";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.Black;
            uiLabel1.Location = new Point(23, 84);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(112, 23);
            uiLabel1.TabIndex = 13;
            uiLabel1.Text = "Số điện thoại";
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtFullName.Location = new Point(149, 22);
            txtFullName.Margin = new Padding(4, 5, 4, 5);
            txtFullName.MinimumSize = new Size(1, 16);
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(15, 5, 5, 5);
            txtFullName.Radius = 10;
            txtFullName.RectColor = Color.FromArgb(250, 82, 82);
            txtFullName.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtFullName.ScrollBarStyleInherited = false;
            txtFullName.ShowText = false;
            txtFullName.Size = new Size(234, 35);
            txtFullName.TabIndex = 10;
            txtFullName.TextAlignment = ContentAlignment.MiddleLeft;
            txtFullName.Watermark = "";
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtPhone.Location = new Point(149, 79);
            txtPhone.Margin = new Padding(4, 5, 4, 5);
            txtPhone.MinimumSize = new Size(1, 16);
            txtPhone.Name = "txtPhone";
            txtPhone.Padding = new Padding(15, 5, 5, 5);
            txtPhone.Radius = 10;
            txtPhone.RectColor = Color.FromArgb(250, 82, 82);
            txtPhone.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtPhone.ScrollBarStyleInherited = false;
            txtPhone.ShowText = false;
            txtPhone.Size = new Size(234, 35);
            txtPhone.TabIndex = 12;
            txtPhone.TextAlignment = ContentAlignment.MiddleLeft;
            txtPhone.Watermark = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(107, 11);
            label1.Name = "label1";
            label1.Size = new Size(188, 21);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pnInformation);
            panel2.Controls.Add(pnDepartment);
            panel2.Controls.Add(pnHide);
            panel2.Controls.Add(pnAccount);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(404, 493);
            panel2.TabIndex = 2;
            // 
            // pnInformation
            // 
            pnInformation.BackColor = Color.White;
            pnInformation.Controls.Add(uiLabel3);
            pnInformation.Controls.Add(dpDayOfBirth);
            pnInformation.Controls.Add(uiLabel2);
            pnInformation.Controls.Add(txtEmail);
            pnInformation.Controls.Add(btnSave);
            pnInformation.Controls.Add(lblUsername);
            pnInformation.Controls.Add(uiLabel1);
            pnInformation.Controls.Add(txtFullName);
            pnInformation.Controls.Add(txtPhone);
            pnInformation.Dock = DockStyle.Fill;
            pnInformation.Location = new Point(0, 181);
            pnInformation.Margin = new Padding(2);
            pnInformation.Name = "pnInformation";
            pnInformation.Padding = new Padding(1, 0, 5, 5);
            pnInformation.Size = new Size(404, 312);
            pnInformation.TabIndex = 12;
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel3.ForeColor = Color.Black;
            uiLabel3.Location = new Point(23, 196);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(112, 23);
            uiLabel3.TabIndex = 18;
            uiLabel3.Text = "Ngày sinh";
            // 
            // dpDayOfBirth
            // 
            dpDayOfBirth.FillColor = Color.White;
            dpDayOfBirth.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            dpDayOfBirth.Location = new Point(149, 193);
            dpDayOfBirth.Margin = new Padding(4, 5, 4, 5);
            dpDayOfBirth.MaxLength = 10;
            dpDayOfBirth.MinimumSize = new Size(63, 0);
            dpDayOfBirth.Name = "dpDayOfBirth";
            dpDayOfBirth.Padding = new Padding(0, 0, 30, 2);
            dpDayOfBirth.RectColor = Color.FromArgb(250, 82, 82);
            dpDayOfBirth.Size = new Size(234, 35);
            dpDayOfBirth.SymbolDropDown = 61555;
            dpDayOfBirth.SymbolNormal = 61555;
            dpDayOfBirth.SymbolSize = 24;
            dpDayOfBirth.TabIndex = 17;
            dpDayOfBirth.Text = "2024-12-19";
            dpDayOfBirth.TextAlignment = ContentAlignment.MiddleLeft;
            dpDayOfBirth.Value = new DateTime(2024, 12, 19, 12, 36, 59, 159);
            dpDayOfBirth.Watermark = "";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.Black;
            uiLabel2.Location = new Point(23, 140);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(112, 23);
            uiLabel2.TabIndex = 16;
            uiLabel2.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtEmail.Location = new Point(149, 136);
            txtEmail.Margin = new Padding(4, 5, 4, 5);
            txtEmail.MinimumSize = new Size(1, 16);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(15, 5, 5, 5);
            txtEmail.Radius = 10;
            txtEmail.RectColor = Color.FromArgb(250, 82, 82);
            txtEmail.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtEmail.ScrollBarStyleInherited = false;
            txtEmail.ShowText = false;
            txtEmail.Size = new Size(234, 35);
            txtEmail.TabIndex = 15;
            txtEmail.TextAlignment = ContentAlignment.MiddleLeft;
            txtEmail.Watermark = "";
            // 
            // btnSave
            // 
            btnSave.FillColor = Color.FromArgb(250, 82, 82);
            btnSave.FillColor2 = Color.FromArgb(250, 82, 82);
            btnSave.FillDisableColor = Color.White;
            btnSave.FillHoverColor = Color.White;
            btnSave.FillPressColor = Color.White;
            btnSave.FillSelectedColor = Color.White;
            btnSave.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnSave.ForeHoverColor = Color.Black;
            btnSave.ForePressColor = Color.Black;
            btnSave.ForeSelectedColor = Color.Black;
            btnSave.Location = new Point(149, 246);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.RectColor = Color.FromArgb(250, 82, 82);
            btnSave.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnSave.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnSave.RectPressColor = Color.FromArgb(250, 82, 82);
            btnSave.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnSave.Size = new Size(103, 35);
            btnSave.TabIndex = 14;
            btnSave.Text = "LƯU";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // pnHide
            // 
            pnHide.BackColor = Color.FromArgb(250, 232, 234);
            pnHide.Dock = DockStyle.Top;
            pnHide.Location = new Point(0, 122);
            pnHide.Name = "pnHide";
            pnHide.Size = new Size(404, 5);
            pnHide.TabIndex = 14;
            // 
            // pnAccount
            // 
            pnAccount.Controls.Add(uiLabel4);
            pnAccount.Controls.Add(txtUsername);
            pnAccount.Controls.Add(uiLabel5);
            pnAccount.Controls.Add(txtPassword);
            pnAccount.Dock = DockStyle.Top;
            pnAccount.Location = new Point(0, 0);
            pnAccount.Name = "pnAccount";
            pnAccount.Size = new Size(404, 122);
            pnAccount.TabIndex = 13;
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel4.ForeColor = Color.Black;
            uiLabel4.Location = new Point(23, 27);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(89, 23);
            uiLabel4.TabIndex = 20;
            uiLabel4.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtUsername.Location = new Point(149, 21);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(15, 5, 5, 5);
            txtUsername.Radius = 10;
            txtUsername.RectColor = Color.FromArgb(250, 82, 82);
            txtUsername.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtUsername.ScrollBarStyleInherited = false;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(234, 35);
            txtUsername.TabIndex = 19;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel5.ForeColor = Color.Black;
            uiLabel5.Location = new Point(23, 74);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(89, 23);
            uiLabel5.TabIndex = 22;
            uiLabel5.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtPassword.Location = new Point(149, 68);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.MinimumSize = new Size(1, 16);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(15, 5, 5, 5);
            txtPassword.PasswordChar = '*';
            txtPassword.Radius = 10;
            txtPassword.RectColor = Color.FromArgb(250, 82, 82);
            txtPassword.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtPassword.ScrollBarStyleInherited = false;
            txtPassword.ShowText = false;
            txtPassword.Size = new Size(234, 35);
            txtPassword.TabIndex = 21;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel6);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(404, 535);
            panel1.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(250, 82, 82);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(404, 42);
            panel6.TabIndex = 13;
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(panel1);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(404, 535);
            pnBackground.TabIndex = 2;
            // 
            // pnDepartment
            // 
            pnDepartment.Controls.Add(uiLabel6);
            pnDepartment.Controls.Add(cmbDepartment);
            pnDepartment.Dock = DockStyle.Top;
            pnDepartment.Location = new Point(0, 127);
            pnDepartment.Name = "pnDepartment";
            pnDepartment.Size = new Size(404, 54);
            pnDepartment.TabIndex = 15;
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
            cmbDepartment.Location = new Point(149, 10);
            cmbDepartment.Margin = new Padding(4, 5, 4, 5);
            cmbDepartment.MinimumSize = new Size(63, 0);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Padding = new Padding(0, 0, 30, 2);
            cmbDepartment.Radius = 10;
            cmbDepartment.RectColor = Color.FromArgb(250, 82, 82);
            cmbDepartment.Size = new Size(234, 35);
            cmbDepartment.SymbolSize = 24;
            cmbDepartment.TabIndex = 327;
            cmbDepartment.TextAlignment = ContentAlignment.MiddleLeft;
            cmbDepartment.Watermark = "";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel6.ForeColor = Color.Black;
            uiLabel6.Location = new Point(23, 16);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(89, 23);
            uiLabel6.TabIndex = 328;
            uiLabel6.Text = "Bộ môn";
            // 
            // frm_UserInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 535);
            Controls.Add(pnBackground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_UserInformation";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frm_UserInformation_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            pnInformation.ResumeLayout(false);
            pnAccount.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            pnBackground.ResumeLayout(false);
            pnDepartment.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lblUsername;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtFullName;
        private Sunny.UI.UITextBox txtPhone;
        private BindingSource bindingSource1;
        private Label label1;
        private Panel panel2;
        private Panel pnInformation;
        private Sunny.UI.UIButton btnSave;
        private Panel panel1;
        private Panel panel6;
        private Panel pnBackground;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UIDatePicker dpDayOfBirth;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox txtEmail;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UITextBox txtUsername;
        private Sunny.UI.UITextBox txtPassword;
        private Panel pnHide;
        private Panel pnAccount;
        private Panel pnDepartment;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cmbDepartment;
    }
}