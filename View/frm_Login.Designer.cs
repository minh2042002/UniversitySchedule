namespace UniversitySchedule.View
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            pnMain = new Panel();
            pnLogin = new Panel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiCheckBox1 = new Sunny.UI.UICheckBox();
            btnLogin = new Sunny.UI.UIButton();
            lblUsername = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            txtUsername = new Sunny.UI.UITextBox();
            txtPassword = new Sunny.UI.UITextBox();
            panel2 = new Panel();
            btnHideForm = new Sunny.UI.UIImageButton();
            btnCloseForm = new Sunny.UI.UIImageButton();
            panel1 = new Panel();
            pnBackground = new Panel();
            pnMain.SuspendLayout();
            pnLogin.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHideForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseForm).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.White;
            pnMain.Controls.Add(pnLogin);
            pnMain.Controls.Add(panel2);
            pnMain.Controls.Add(panel1);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(737, 500);
            pnMain.TabIndex = 0;
            // 
            // pnLogin
            // 
            pnLogin.Controls.Add(uiLabel2);
            pnLogin.Controls.Add(uiCheckBox1);
            pnLogin.Controls.Add(btnLogin);
            pnLogin.Controls.Add(lblUsername);
            pnLogin.Controls.Add(uiLabel1);
            pnLogin.Controls.Add(txtUsername);
            pnLogin.Controls.Add(txtPassword);
            pnLogin.Dock = DockStyle.Fill;
            pnLogin.Location = new Point(334, 30);
            pnLogin.Name = "pnLogin";
            pnLogin.Size = new Size(403, 470);
            pnLogin.TabIndex = 8;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel2.ForeColor = Color.FromArgb(206, 22, 40);
            uiLabel2.Location = new Point(61, 67);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(262, 53);
            uiLabel2.TabIndex = 10;
            uiLabel2.Text = "Class Schedule";
            // 
            // uiCheckBox1
            // 
            uiCheckBox1.CheckBoxColor = Color.FromArgb(250, 82, 82);
            uiCheckBox1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            uiCheckBox1.ForeColor = Color.FromArgb(48, 48, 48);
            uiCheckBox1.Location = new Point(126, 271);
            uiCheckBox1.MinimumSize = new Size(1, 1);
            uiCheckBox1.Name = "uiCheckBox1";
            uiCheckBox1.Size = new Size(240, 29);
            uiCheckBox1.TabIndex = 9;
            uiCheckBox1.Text = "Nhớ tôi";
            // 
            // btnLogin
            // 
            btnLogin.FillColor = Color.FromArgb(250, 82, 82);
            btnLogin.FillColor2 = Color.FromArgb(250, 82, 82);
            btnLogin.FillDisableColor = Color.White;
            btnLogin.FillHoverColor = Color.White;
            btnLogin.FillPressColor = Color.White;
            btnLogin.FillSelectedColor = Color.White;
            btnLogin.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnLogin.ForeHoverColor = Color.Black;
            btnLogin.ForePressColor = Color.Black;
            btnLogin.ForeSelectedColor = Color.Black;
            btnLogin.Location = new Point(126, 329);
            btnLogin.MinimumSize = new Size(1, 1);
            btnLogin.Name = "btnLogin";
            btnLogin.Radius = 10;
            btnLogin.RectColor = Color.FromArgb(250, 82, 82);
            btnLogin.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnLogin.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnLogin.RectPressColor = Color.FromArgb(250, 82, 82);
            btnLogin.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnLogin.Size = new Size(122, 35);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "ĐĂNG NHẬP";
            btnLogin.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUsername
            // 
            lblUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(27, 184);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(89, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel1.ForeColor = Color.Black;
            uiLabel1.Location = new Point(27, 231);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(89, 23);
            uiLabel1.TabIndex = 7;
            uiLabel1.Text = "Password";
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtUsername.Location = new Point(126, 178);
            txtUsername.Margin = new Padding(4, 5, 4, 5);
            txtUsername.MinimumSize = new Size(1, 16);
            txtUsername.Name = "txtUsername";
            txtUsername.Padding = new Padding(15, 5, 5, 5);
            txtUsername.Radius = 10;
            txtUsername.RectColor = Color.FromArgb(250, 82, 82);
            txtUsername.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtUsername.ScrollBarStyleInherited = false;
            txtUsername.ShowText = false;
            txtUsername.Size = new Size(240, 35);
            txtUsername.TabIndex = 4;
            txtUsername.TextAlignment = ContentAlignment.MiddleLeft;
            txtUsername.Watermark = "";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            txtPassword.Location = new Point(126, 225);
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
            txtPassword.Size = new Size(240, 35);
            txtPassword.TabIndex = 6;
            txtPassword.TextAlignment = ContentAlignment.MiddleLeft;
            txtPassword.Watermark = "";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHideForm);
            panel2.Controls.Add(btnCloseForm);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(334, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 0, 2, 0);
            panel2.Size = new Size(403, 30);
            panel2.TabIndex = 3;
            // 
            // btnHideForm
            // 
            btnHideForm.BackColor = Color.Transparent;
            btnHideForm.BackgroundImage = Properties.Resources.hide_form_50;
            btnHideForm.BackgroundImageLayout = ImageLayout.Zoom;
            btnHideForm.Dock = DockStyle.Right;
            btnHideForm.Font = new Font("Microsoft Sans Serif", 12F);
            btnHideForm.Location = new Point(341, 0);
            btnHideForm.Name = "btnHideForm";
            btnHideForm.Size = new Size(30, 30);
            btnHideForm.TabIndex = 2;
            btnHideForm.TabStop = false;
            btnHideForm.Text = null;
            btnHideForm.Click += btnHideForm_Click;
            // 
            // btnCloseForm
            // 
            btnCloseForm.BackColor = Color.Transparent;
            btnCloseForm.BackgroundImage = Properties.Resources.close_50;
            btnCloseForm.BackgroundImageLayout = ImageLayout.Zoom;
            btnCloseForm.Dock = DockStyle.Right;
            btnCloseForm.Font = new Font("Microsoft Sans Serif", 12F);
            btnCloseForm.Location = new Point(371, 0);
            btnCloseForm.Name = "btnCloseForm";
            btnCloseForm.Size = new Size(30, 30);
            btnCloseForm.TabIndex = 1;
            btnCloseForm.TabStop = false;
            btnCloseForm.Text = null;
            btnCloseForm.Click += btnCloseForm_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnBackground);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 500);
            panel1.TabIndex = 0;
            // 
            // pnBackground
            // 
            pnBackground.BackgroundImage = Properties.Resources.logo_hust;
            pnBackground.BackgroundImageLayout = ImageLayout.Zoom;
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(334, 500);
            pnBackground.TabIndex = 0;
            // 
            // frm_Login
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(737, 500);
            Controls.Add(pnMain);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(737, 500);
            MinimumSize = new Size(737, 500);
            Name = "frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            pnMain.ResumeLayout(false);
            pnLogin.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHideForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCloseForm).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Sunny.UI.UIImageButton btnCloseForm;
        private Panel panel1;
        private Panel panel2;
        private Sunny.UI.UIImageButton btnHideForm;
        private Panel pnBackground;
        private Sunny.UI.UILabel lblUsername;
        private Sunny.UI.UITextBox txtUsername;
        private Panel pnLogin;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UITextBox txtPassword;
        private Sunny.UI.UICheckBox uiCheckBox1;
        private Sunny.UI.UIButton btnLogin;
        private Sunny.UI.UILabel uiLabel2;
    }
}