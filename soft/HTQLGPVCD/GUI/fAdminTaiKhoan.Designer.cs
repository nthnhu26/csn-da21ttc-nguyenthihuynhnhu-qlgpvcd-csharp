namespace GUI
{
    partial class fAdminTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fAdminTaiKhoan));
            tableLayoutPanel1 = new TableLayoutPanel();
            tabletextcombo = new TableLayoutPanel();
            panel1 = new Panel();
            txtuser = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            txtpass = new TextBox();
            label4 = new Label();
            panel3 = new Panel();
            txtid = new TextBox();
            label5 = new Label();
            panel4 = new Panel();
            cbqtc = new ComboBox();
            label3 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnclear = new Button();
            btnadd = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnsearch = new Button();
            btnload = new Button();
            btnprint = new Button();
            label1 = new Label();
            dgvtaikhoan = new DataGridView();
            Username = new DataGridViewTextBoxColumn();
            IDGV = new DataGridViewTextBoxColumn();
            IDQTC = new DataGridViewTextBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tabletextcombo.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtaikhoan).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tabletextcombo, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvtaikhoan, 0, 3);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 32.1705437F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 67.82946F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 77F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 308F));
            tableLayoutPanel1.Size = new Size(1258, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tabletextcombo
            // 
            tabletextcombo.ColumnCount = 4;
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.84211F));
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.1578941F));
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 438F));
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 150F));
            tabletextcombo.Controls.Add(panel1, 1, 0);
            tabletextcombo.Controls.Add(panel2, 1, 1);
            tabletextcombo.Controls.Add(panel3, 2, 0);
            tabletextcombo.Controls.Add(panel4, 2, 1);
            tabletextcombo.Dock = DockStyle.Fill;
            tabletextcombo.Location = new Point(3, 81);
            tabletextcombo.Name = "tabletextcombo";
            tabletextcombo.RowCount = 2;
            tabletextcombo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabletextcombo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabletextcombo.Size = new Size(1252, 159);
            tabletextcombo.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtuser);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(247, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(413, 73);
            panel1.TabIndex = 0;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(119, 11);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(280, 33);
            txtuser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(110, 26);
            label2.TabIndex = 0;
            label2.Text = "Username:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtpass);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(247, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(413, 74);
            panel2.TabIndex = 1;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(119, 9);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(280, 33);
            txtpass.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(5, 11);
            label4.Name = "label4";
            label4.Size = new Size(108, 26);
            label4.TabIndex = 0;
            label4.Text = "Password:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            panel3.Controls.Add(txtid);
            panel3.Controls.Add(label5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(666, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(432, 73);
            panel3.TabIndex = 2;
            // 
            // txtid
            // 
            txtid.Location = new Point(195, 11);
            txtid.Name = "txtid";
            txtid.Size = new Size(205, 33);
            txtid.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 14);
            label5.Name = "label5";
            label5.Size = new Size(144, 26);
            label5.TabIndex = 0;
            label5.Text = "ID giảng viên:";
            // 
            // panel4
            // 
            panel4.Controls.Add(cbqtc);
            panel4.Controls.Add(label3);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(666, 82);
            panel4.Name = "panel4";
            panel4.Size = new Size(432, 74);
            panel4.TabIndex = 3;
            // 
            // cbqtc
            // 
            cbqtc.FormattingEnabled = true;
            cbqtc.Location = new Point(195, 9);
            cbqtc.Name = "cbqtc";
            cbqtc.Size = new Size(205, 33);
            cbqtc.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 12);
            label3.Name = "label3";
            label3.Size = new Size(186, 26);
            label3.TabIndex = 0;
            label3.Text = "ID quyền truy cập:";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnclear);
            flowLayoutPanel2.Controls.Add(btnadd);
            flowLayoutPanel2.Controls.Add(btndelete);
            flowLayoutPanel2.Controls.Add(btnupdate);
            flowLayoutPanel2.Controls.Add(btnsearch);
            flowLayoutPanel2.Controls.Add(btnload);
            flowLayoutPanel2.Controls.Add(btnprint);
            flowLayoutPanel2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel2.Location = new Point(3, 246);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(6);
            flowLayoutPanel2.Size = new Size(1241, 71);
            flowLayoutPanel2.TabIndex = 6;
            // 
            // btnclear
            // 
            btnclear.Image = (Image)resources.GetObject("btnclear.Image");
            btnclear.Location = new Point(9, 9);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(166, 50);
            btnclear.TabIndex = 0;
            btnclear.Text = "Làm mới";
            btnclear.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // btnadd
            // 
            btnadd.Image = (Image)resources.GetObject("btnadd.Image");
            btnadd.ImageAlign = ContentAlignment.MiddleLeft;
            btnadd.Location = new Point(181, 9);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(140, 50);
            btnadd.TabIndex = 1;
            btnadd.Text = "Thêm";
            btnadd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btndelete
            // 
            btndelete.Image = (Image)resources.GetObject("btndelete.Image");
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(327, 9);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(133, 50);
            btndelete.TabIndex = 2;
            btndelete.Text = "Xóa";
            btndelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Image = (Image)resources.GetObject("btnupdate.Image");
            btnupdate.Location = new Point(466, 9);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(166, 50);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Cập nhật";
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsearch
            // 
            btnsearch.Image = (Image)resources.GetObject("btnsearch.Image");
            btnsearch.Location = new Point(638, 9);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(205, 50);
            btnsearch.TabIndex = 5;
            btnsearch.Text = "Tìm Username";
            btnsearch.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // btnload
            // 
            btnload.Image = (Image)resources.GetObject("btnload.Image");
            btnload.Location = new Point(849, 9);
            btnload.Name = "btnload";
            btnload.Size = new Size(185, 50);
            btnload.TabIndex = 8;
            btnload.Text = "Tải danh sách";
            btnload.TextAlign = ContentAlignment.MiddleLeft;
            btnload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnprint
            // 
            btnprint.Image = (Image)resources.GetObject("btnprint.Image");
            btnprint.Location = new Point(1040, 9);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(190, 50);
            btnprint.TabIndex = 4;
            btnprint.Text = "In danh sách";
            btnprint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1252, 78);
            label1.TabIndex = 2;
            label1.Text = "QUẢN LÝ TÀI KHOẢN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvtaikhoan
            // 
            dgvtaikhoan.AllowUserToAddRows = false;
            dgvtaikhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtaikhoan.Columns.AddRange(new DataGridViewColumn[] { Username, IDGV, IDQTC, Password });
            dgvtaikhoan.Dock = DockStyle.Fill;
            dgvtaikhoan.Location = new Point(3, 323);
            dgvtaikhoan.Name = "dgvtaikhoan";
            dgvtaikhoan.ReadOnly = true;
            dgvtaikhoan.RowHeadersWidth = 51;
            dgvtaikhoan.Size = new Size(1252, 303);
            dgvtaikhoan.TabIndex = 1;
            dgvtaikhoan.CellClick += dgvtaikhoan_CellClick;
            // 
            // Username
            // 
            Username.DataPropertyName = "Username";
            Username.HeaderText = "Username";
            Username.MinimumWidth = 6;
            Username.Name = "Username";
            Username.ReadOnly = true;
            Username.Width = 125;
            // 
            // IDGV
            // 
            IDGV.DataPropertyName = "IDGV";
            IDGV.HeaderText = "ID giảng viên";
            IDGV.MinimumWidth = 6;
            IDGV.Name = "IDGV";
            IDGV.ReadOnly = true;
            IDGV.Width = 125;
            // 
            // IDQTC
            // 
            IDQTC.DataPropertyName = "IDQTC";
            IDQTC.HeaderText = "ID quyền truy cập";
            IDQTC.MinimumWidth = 6;
            IDQTC.Name = "IDQTC";
            IDQTC.ReadOnly = true;
            IDQTC.Width = 125;
            // 
            // Password
            // 
            Password.DataPropertyName = "Password";
            Password.HeaderText = "Password";
            Password.MinimumWidth = 6;
            Password.Name = "Password";
            Password.ReadOnly = true;
            Password.Width = 125;
            // 
            // fAdminTaiKhoan
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(1300, 700);
            MinimumSize = new Size(1300, 700);
            Name = "fAdminTaiKhoan";
            Text = "fAdminTaiKhoan";
            Load += fAdminTaiKhoan_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tabletextcombo.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvtaikhoan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tabletextcombo;
        private Panel panel1;
        private TextBox txtuser;
        private Label label2;
        private Panel panel2;
        private TextBox txtpass;
        private Label label3;
        private Panel panel3;
        private TextBox txtid;
        private Label label5;
        private Panel panel4;
        private Label label4;
        private DataGridView dgvtaikhoan;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnclear;
        private Button btnadd;
        private Button btndelete;
        private Button btnsearch;
        private Button btnprint;
        private Button btnload;
        private Button btnupdate;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn IDGV;
        private DataGridViewTextBoxColumn IDQTC;
        private DataGridViewTextBoxColumn Password;
        private ComboBox cbqtc;
    }
}