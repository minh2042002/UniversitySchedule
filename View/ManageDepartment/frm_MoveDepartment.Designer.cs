namespace UniversitySchedule.View.ManageDepartment
{
    partial class frm_MoveDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MoveDepartment));
            uiLabel6 = new Sunny.UI.UILabel();
            cmbDepartment = new Sunny.UI.UIComboBox();
            btnMove = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            uiLabel6.ForeColor = Color.Black;
            uiLabel6.Location = new Point(20, 20);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(89, 23);
            uiLabel6.TabIndex = 330;
            uiLabel6.Text = "Bộ môn";
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
            cmbDepartment.Location = new Point(116, 14);
            cmbDepartment.Margin = new Padding(4, 5, 4, 5);
            cmbDepartment.MinimumSize = new Size(63, 0);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Padding = new Padding(0, 0, 30, 2);
            cmbDepartment.Radius = 10;
            cmbDepartment.RectColor = Color.FromArgb(250, 82, 82);
            cmbDepartment.Size = new Size(234, 35);
            cmbDepartment.SymbolSize = 24;
            cmbDepartment.TabIndex = 329;
            cmbDepartment.TextAlignment = ContentAlignment.MiddleLeft;
            cmbDepartment.Watermark = "";
            // 
            // btnMove
            // 
            btnMove.FillColor = Color.FromArgb(250, 82, 82);
            btnMove.FillColor2 = Color.FromArgb(250, 82, 82);
            btnMove.FillDisableColor = Color.White;
            btnMove.FillHoverColor = Color.White;
            btnMove.FillPressColor = Color.White;
            btnMove.FillSelectedColor = Color.White;
            btnMove.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnMove.ForeHoverColor = Color.Black;
            btnMove.ForePressColor = Color.Black;
            btnMove.ForeSelectedColor = Color.Black;
            btnMove.Location = new Point(116, 57);
            btnMove.MinimumSize = new Size(1, 1);
            btnMove.Name = "btnMove";
            btnMove.Radius = 10;
            btnMove.RectColor = Color.FromArgb(250, 82, 82);
            btnMove.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnMove.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnMove.RectPressColor = Color.FromArgb(250, 82, 82);
            btnMove.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnMove.Size = new Size(103, 35);
            btnMove.TabIndex = 331;
            btnMove.Text = "Chuyển";
            btnMove.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnMove.Click += btnMove_Click;
            // 
            // frm_MoveDepartment
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.White;
            ClientSize = new Size(364, 106);
            Controls.Add(btnMove);
            Controls.Add(uiLabel6);
            Controls.Add(cmbDepartment);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_MoveDepartment";
            Load += frm_MoveDepartment_Load;
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UIComboBox cmbDepartment;
        private Sunny.UI.UIButton btnMove;
    }
}