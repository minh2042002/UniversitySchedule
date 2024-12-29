namespace UniversitySchedule.View.CreateSchedule
{
    partial class frm_Schedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Schedule));
            btnSave = new Sunny.UI.UIButton();
            label2 = new Label();
            txtNameSchedule = new Sunny.UI.UITextBox();
            SuspendLayout();
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
            btnSave.Location = new Point(176, 72);
            btnSave.MinimumSize = new Size(1, 1);
            btnSave.Name = "btnSave";
            btnSave.Radius = 10;
            btnSave.RectColor = Color.FromArgb(250, 82, 82);
            btnSave.RectDisableColor = Color.FromArgb(250, 82, 82);
            btnSave.RectHoverColor = Color.FromArgb(250, 82, 82);
            btnSave.RectPressColor = Color.FromArgb(250, 82, 82);
            btnSave.RectSelectedColor = Color.FromArgb(250, 82, 82);
            btnSave.Size = new Size(92, 37);
            btnSave.TabIndex = 327;
            btnSave.Text = "OK";
            btnSave.TipsFont = new Font("Microsoft Sans Serif", 9F);
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(11, 26);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 21);
            label2.TabIndex = 326;
            label2.Text = "Tên thời khóa biểu";
            // 
            // txtNameSchedule
            // 
            txtNameSchedule.ButtonSymbolOffset = new Point(0, 0);
            txtNameSchedule.Font = new Font("Segoe UI", 9.75F);
            txtNameSchedule.Location = new Point(176, 18);
            txtNameSchedule.Margin = new Padding(3, 4, 3, 4);
            txtNameSchedule.MinimumSize = new Size(1, 13);
            txtNameSchedule.Name = "txtNameSchedule";
            txtNameSchedule.Padding = new Padding(10, 0, 0, 0);
            txtNameSchedule.Radius = 10;
            txtNameSchedule.RectColor = Color.FromArgb(250, 82, 82);
            txtNameSchedule.RectDisableColor = Color.FromArgb(250, 82, 82);
            txtNameSchedule.RectReadOnlyColor = Color.FromArgb(250, 82, 82);
            txtNameSchedule.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtNameSchedule.ScrollBarStyleInherited = false;
            txtNameSchedule.ShowText = false;
            txtNameSchedule.Size = new Size(264, 36);
            txtNameSchedule.Style = Sunny.UI.UIStyle.Custom;
            txtNameSchedule.TabIndex = 325;
            txtNameSchedule.TextAlignment = ContentAlignment.MiddleLeft;
            txtNameSchedule.Watermark = "Nhập tên thời khóa biểu ...";
            // 
            // frm_Schedule
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(461, 124);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtNameSchedule);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_Schedule";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += frm_Schedule_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Sunny.UI.UIButton btnSave;
        private Label label2;
        private Sunny.UI.UITextBox txtNameSchedule;
    }
}