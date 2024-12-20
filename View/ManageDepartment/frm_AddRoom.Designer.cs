namespace UniversitySchedule.View.ManageDepartment
{
    partial class frm_AddRoom
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddRoom));
            bindingSource1 = new BindingSource(components);
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            dgvRoom = new Sunny.UI.UIDataGridView();
            stt = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            name = new DataGridViewTextBoxColumn();
            capacity = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            label3 = new Label();
            numCapacity = new NumericUpDown();
            btnDelete = new PictureBox();
            btnEdit = new PictureBox();
            btnAdd = new PictureBox();
            label2 = new Label();
            txtNameRoom = new Sunny.UI.UITextBox();
            label1 = new Label();
            pnBackground = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoom).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            pnBackground.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 42);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 408);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(panel3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(1, 0, 5, 5);
            panel4.Size = new Size(800, 408);
            panel4.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(uiGroupBox1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(382, 0);
            panel5.Margin = new Padding(2);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(0, 5, 0, 0);
            panel5.Size = new Size(413, 403);
            panel5.TabIndex = 3;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(dgvRoom);
            uiGroupBox1.Dock = DockStyle.Fill;
            uiGroupBox1.FillColor = Color.White;
            uiGroupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            uiGroupBox1.ForeColor = Color.FromArgb(250, 82, 82);
            uiGroupBox1.Location = new Point(0, 5);
            uiGroupBox1.Margin = new Padding(8);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(1, 32, 5, 5);
            uiGroupBox1.Radius = 10;
            uiGroupBox1.RectColor = Color.FromArgb(250, 82, 82);
            uiGroupBox1.Size = new Size(413, 398);
            uiGroupBox1.Style = Sunny.UI.UIStyle.Custom;
            uiGroupBox1.TabIndex = 161;
            uiGroupBox1.Text = "DANH SÁCH PHÒNG HỌC";
            uiGroupBox1.TextAlignment = ContentAlignment.TopLeft;
            // 
            // dgvRoom
            // 
            dgvRoom.AllowUserToAddRows = false;
            dgvRoom.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle1.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dgvRoom.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgvRoom.BackgroundColor = Color.White;
            dgvRoom.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle2.SelectionBackColor = Color.White;
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(28, 28, 28);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvRoom.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRoom.ColumnHeadersHeight = 40;
            dgvRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvRoom.Columns.AddRange(new DataGridViewColumn[] { stt, id, name, capacity });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 104, 196);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvRoom.DefaultCellStyle = dataGridViewCellStyle3;
            dgvRoom.Dock = DockStyle.Fill;
            dgvRoom.EnableHeadersVisualStyles = false;
            dgvRoom.Font = new Font("Microsoft YaHei", 12F);
            dgvRoom.GridColor = Color.DarkGray;
            dgvRoom.Location = new Point(1, 32);
            dgvRoom.Margin = new Padding(2);
            dgvRoom.MultiSelect = false;
            dgvRoom.Name = "dgvRoom";
            dgvRoom.ReadOnly = true;
            dgvRoom.RectColor = Color.White;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 104, 196);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvRoom.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvRoom.RowHeadersVisible = false;
            dgvRoom.RowHeadersWidth = 55;
            dgvRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle5.Padding = new Padding(2, 5, 2, 5);
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dgvRoom.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgvRoom.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 11.25F);
            dgvRoom.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dgvRoom.RowTemplate.DefaultCellStyle.Padding = new Padding(2, 5, 2, 5);
            dgvRoom.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgvRoom.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.White;
            dgvRoom.RowTemplate.DividerHeight = 1;
            dgvRoom.RowTemplate.Height = 70;
            dgvRoom.ScrollBarBackColor = Color.White;
            dgvRoom.ScrollBarColor = SystemColors.ControlDark;
            dgvRoom.ScrollBarRectColor = SystemColors.ControlDark;
            dgvRoom.ScrollBarStyleInherited = false;
            dgvRoom.SelectedIndex = -1;
            dgvRoom.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoom.Size = new Size(407, 361);
            dgvRoom.StripeOddColor = Color.White;
            dgvRoom.Style = Sunny.UI.UIStyle.Custom;
            dgvRoom.StyleCustomMode = true;
            dgvRoom.TabIndex = 3;
            dgvRoom.CellClick += dgvRoom_CellClick;
            // 
            // stt
            // 
            stt.HeaderText = "STT";
            stt.MinimumWidth = 100;
            stt.Name = "stt";
            stt.ReadOnly = true;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 6;
            id.Name = "id";
            id.ReadOnly = true;
            id.Visible = false;
            id.Width = 125;
            // 
            // name
            // 
            name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            name.HeaderText = "Tên Phòng Học";
            name.MinimumWidth = 6;
            name.Name = "name";
            name.ReadOnly = true;
            // 
            // capacity
            // 
            capacity.HeaderText = "Chỗ Ngồi";
            capacity.Name = "capacity";
            capacity.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(numCapacity);
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnEdit);
            panel3.Controls.Add(btnAdd);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtNameRoom);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(1, 0);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(381, 403);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ImeMode = ImeMode.NoControl;
            label3.Location = new Point(84, 120);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 19;
            label3.Text = "Số chỗ ngồi";
            // 
            // numCapacity
            // 
            numCapacity.Font = new Font("Segoe UI", 10F);
            numCapacity.Location = new Point(233, 118);
            numCapacity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(82, 25);
            numCapacity.TabIndex = 18;
            numCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDelete
            // 
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Image = Properties.Resources.remove_24_red;
            btnDelete.ImeMode = ImeMode.NoControl;
            btnDelete.Location = new Point(17, 123);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(40, 40);
            btnDelete.SizeMode = PictureBoxSizeMode.CenterImage;
            btnDelete.TabIndex = 17;
            btnDelete.TabStop = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Image = Properties.Resources.edit_24_red;
            btnEdit.ImeMode = ImeMode.NoControl;
            btnEdit.Location = new Point(17, 71);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(40, 40);
            btnEdit.SizeMode = PictureBoxSizeMode.CenterImage;
            btnEdit.TabIndex = 16;
            btnEdit.TabStop = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.Image = Properties.Resources.add_24_red;
            btnAdd.ImeMode = ImeMode.NoControl;
            btnAdd.Location = new Point(17, 20);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(40, 40);
            btnAdd.SizeMode = PictureBoxSizeMode.CenterImage;
            btnAdd.TabIndex = 15;
            btnAdd.TabStop = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ImeMode = ImeMode.NoControl;
            label2.Location = new Point(84, 25);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 21);
            label2.TabIndex = 14;
            label2.Text = "Tên phòng học";
            // 
            // txtNameRoom
            // 
            txtNameRoom.ButtonSymbolOffset = new Point(0, 0);
            txtNameRoom.Font = new Font("Segoe UI", 9.75F);
            txtNameRoom.Location = new Point(84, 60);
            txtNameRoom.Margin = new Padding(3, 4, 3, 4);
            txtNameRoom.MinimumSize = new Size(1, 13);
            txtNameRoom.Name = "txtNameRoom";
            txtNameRoom.Padding = new Padding(10, 0, 0, 0);
            txtNameRoom.Radius = 10;
            txtNameRoom.RectColor = Color.FromArgb(250, 82, 82);
            txtNameRoom.RectDisableColor = Color.FromArgb(250, 82, 82);
            txtNameRoom.RectReadOnlyColor = Color.FromArgb(250, 82, 82);
            txtNameRoom.ScrollBarColor = Color.FromArgb(250, 82, 82);
            txtNameRoom.ScrollBarStyleInherited = false;
            txtNameRoom.ShowText = false;
            txtNameRoom.Size = new Size(274, 36);
            txtNameRoom.Style = Sunny.UI.UIStyle.Custom;
            txtNameRoom.TabIndex = 0;
            txtNameRoom.TextAlignment = ContentAlignment.MiddleLeft;
            txtNameRoom.Watermark = "Nhập tên phòng học ...";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.ImeMode = ImeMode.NoControl;
            label1.Location = new Point(323, 11);
            label1.Name = "label1";
            label1.Size = new Size(155, 21);
            label1.TabIndex = 0;
            label1.Text = "THÊM PHÒNG HỌC";
            // 
            // pnBackground
            // 
            pnBackground.Controls.Add(panel2);
            pnBackground.Controls.Add(panel6);
            pnBackground.Dock = DockStyle.Fill;
            pnBackground.Location = new Point(0, 0);
            pnBackground.Name = "pnBackground";
            pnBackground.Size = new Size(800, 450);
            pnBackground.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(250, 82, 82);
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(800, 42);
            panel6.TabIndex = 13;
            // 
            // frm_AddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(pnBackground);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frm_AddRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Load += frm_AddRoom_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRoom).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnEdit).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            pnBackground.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private BindingSource bindingSource1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Panel panel3;
        private PictureBox btnDelete;
        private PictureBox btnEdit;
        private PictureBox btnAdd;
        private Label label2;
        private Sunny.UI.UITextBox txtNameRoom;
        private Label label1;
        private Panel pnBackground;
        private Panel panel6;
        private Sunny.UI.UIDataGridView dgvRoom;
        private DataGridViewTextBoxColumn stt;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn capacity;
        private Label label3;
        private NumericUpDown numCapacity;
    }
}