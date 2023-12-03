namespace GUI
{
    partial class fGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGiangVien));
            tableLayoutPanel1 = new TableLayoutPanel();
            dgvgiangvien = new DataGridView();
            IDGV = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            HocVi = new DataGridViewTextBoxColumn();
            ChucVu = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            BoMon = new DataGridViewTextBoxColumn();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnclaer = new Button();
            btnadd = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            searchid = new Button();
            btnsearchten = new Button();
            btnload = new Button();
            btnprint = new Button();
            tabletextcombo = new TableLayoutPanel();
            panel3 = new Panel();
            label10 = new Label();
            cbbomon = new ComboBox();
            label9 = new Label();
            panel9 = new Panel();
            txtsdt = new TextBox();
            label8 = new Label();
            panel8 = new Panel();
            txtemail = new TextBox();
            label7 = new Label();
            panel7 = new Panel();
            cbchucvu = new ComboBox();
            label6 = new Label();
            panel6 = new Panel();
            cbhocvi = new ComboBox();
            label5 = new Label();
            panel5 = new Panel();
            cbgioitinh = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            txthoten = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            txtid = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvgiangvien).BeginInit();
            flowLayoutPanel2.SuspendLayout();
            tabletextcombo.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(dgvgiangvien, 0, 3);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tabletextcombo, 0, 1);
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.647779F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.0964775F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.4854517F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.77029F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1282, 653);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dgvgiangvien
            // 
            dgvgiangvien.AllowUserToAddRows = false;
            dgvgiangvien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvgiangvien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvgiangvien.Columns.AddRange(new DataGridViewColumn[] { IDGV, HoTen, GioiTinh, HocVi, ChucVu, Email, SoDienThoai, BoMon });
            dgvgiangvien.Location = new Point(3, 331);
            dgvgiangvien.Name = "dgvgiangvien";
            dgvgiangvien.ReadOnly = true;
            dgvgiangvien.RowHeadersWidth = 51;
            dgvgiangvien.Size = new Size(1276, 319);
            dgvgiangvien.TabIndex = 0;
            dgvgiangvien.CellClick += dgvgiangvien_CellClick;
            // 
            // IDGV
            // 
            IDGV.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            IDGV.DataPropertyName = "IDGV";
            IDGV.HeaderText = "ID giảng viên";
            IDGV.MinimumWidth = 6;
            IDGV.Name = "IDGV";
            IDGV.ReadOnly = true;
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.DataPropertyName = "HoTen";
            HoTen.HeaderText = "Họ tên ";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            // 
            // GioiTinh
            // 
            GioiTinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            // 
            // HocVi
            // 
            HocVi.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HocVi.DataPropertyName = "HocVi";
            HocVi.HeaderText = "Học vị";
            HocVi.MinimumWidth = 6;
            HocVi.Name = "HocVi";
            HocVi.ReadOnly = true;
            // 
            // ChucVu
            // 
            ChucVu.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ChucVu.DataPropertyName = "ChucVu";
            ChucVu.HeaderText = "Chức vụ";
            ChucVu.MinimumWidth = 6;
            ChucVu.Name = "ChucVu";
            ChucVu.ReadOnly = true;
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.DataPropertyName = "Email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // SoDienThoai
            // 
            SoDienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            SoDienThoai.ReadOnly = true;
            // 
            // BoMon
            // 
            BoMon.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            BoMon.DataPropertyName = "BoMon";
            BoMon.HeaderText = "Bộ môn";
            BoMon.MinimumWidth = 6;
            BoMon.Name = "BoMon";
            BoMon.ReadOnly = true;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.Controls.Add(btnclaer);
            flowLayoutPanel2.Controls.Add(btnadd);
            flowLayoutPanel2.Controls.Add(btndelete);
            flowLayoutPanel2.Controls.Add(btnupdate);
            flowLayoutPanel2.Controls.Add(searchid);
            flowLayoutPanel2.Controls.Add(btnsearchten);
            flowLayoutPanel2.Controls.Add(btnload);
            flowLayoutPanel2.Controls.Add(btnprint);
            flowLayoutPanel2.Location = new Point(3, 256);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(6);
            flowLayoutPanel2.Size = new Size(1276, 69);
            flowLayoutPanel2.TabIndex = 3;
            // 
            // btnclaer
            // 
            btnclaer.Image = (Image)resources.GetObject("btnclaer.Image");
            btnclaer.Location = new Point(9, 9);
            btnclaer.Name = "btnclaer";
            btnclaer.Size = new Size(140, 50);
            btnclaer.TabIndex = 0;
            btnclaer.Text = "Làm mới";
            btnclaer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnclaer.UseVisualStyleBackColor = true;
            btnclaer.Click += btnclaer_Click;
            // 
            // btnadd
            // 
            btnadd.Image = (Image)resources.GetObject("btnadd.Image");
            btnadd.ImageAlign = ContentAlignment.MiddleLeft;
            btnadd.Location = new Point(155, 9);
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
            btndelete.Location = new Point(301, 9);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(140, 50);
            btndelete.TabIndex = 2;
            btndelete.Text = "Xóa";
            btndelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Image = (Image)resources.GetObject("btnupdate.Image");
            btnupdate.Location = new Point(447, 9);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(155, 50);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Cập nhật";
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // searchid
            // 
            searchid.Image = (Image)resources.GetObject("searchid.Image");
            searchid.Location = new Point(608, 9);
            searchid.Name = "searchid";
            searchid.Size = new Size(135, 50);
            searchid.TabIndex = 5;
            searchid.Text = "Tìm ID";
            searchid.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchid.UseVisualStyleBackColor = true;
            searchid.Click += searchid_Click;
            // 
            // btnsearchten
            // 
            btnsearchten.Image = (Image)resources.GetObject("btnsearchten.Image");
            btnsearchten.Location = new Point(749, 9);
            btnsearchten.Name = "btnsearchten";
            btnsearchten.Size = new Size(135, 50);
            btnsearchten.TabIndex = 6;
            btnsearchten.Text = "Tìm tên";
            btnsearchten.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsearchten.UseVisualStyleBackColor = true;
            btnsearchten.Click += btnsearchten_Click;
            // 
            // btnload
            // 
            btnload.Image = (Image)resources.GetObject("btnload.Image");
            btnload.Location = new Point(890, 9);
            btnload.Name = "btnload";
            btnload.Size = new Size(185, 50);
            btnload.TabIndex = 7;
            btnload.Text = "Tải danh sách";
            btnload.TextAlign = ContentAlignment.MiddleLeft;
            btnload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnload.UseVisualStyleBackColor = true;
            btnload.Click += btnload_Click;
            // 
            // btnprint
            // 
            btnprint.Image = (Image)resources.GetObject("btnprint.Image");
            btnprint.Location = new Point(1081, 9);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(185, 50);
            btnprint.TabIndex = 4;
            btnprint.Text = "In danh sách";
            btnprint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnprint.UseVisualStyleBackColor = true;
            btnprint.Click += btnprint_Click;
            // 
            // tabletextcombo
            // 
            tabletextcombo.ColumnCount = 3;
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tabletextcombo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tabletextcombo.Controls.Add(panel3, 2, 1);
            tabletextcombo.Controls.Add(panel9, 2, 0);
            tabletextcombo.Controls.Add(panel8, 1, 2);
            tabletextcombo.Controls.Add(panel7, 1, 1);
            tabletextcombo.Controls.Add(panel6, 1, 0);
            tabletextcombo.Controls.Add(panel5, 0, 2);
            tabletextcombo.Controls.Add(panel2, 0, 1);
            tabletextcombo.Controls.Add(panel1, 0, 0);
            tabletextcombo.Dock = DockStyle.Fill;
            tabletextcombo.Location = new Point(3, 66);
            tabletextcombo.Name = "tabletextcombo";
            tabletextcombo.RowCount = 3;
            tabletextcombo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tabletextcombo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tabletextcombo.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tabletextcombo.Size = new Size(1276, 184);
            tabletextcombo.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(cbbomon);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(853, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(416, 55);
            panel3.TabIndex = 9;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 19);
            label10.Name = "label10";
            label10.Size = new Size(92, 26);
            label10.TabIndex = 2;
            label10.Text = "Bộ môn:";
            // 
            // cbbomon
            // 
            cbbomon.FormattingEnabled = true;
            cbbomon.Location = new Point(150, 14);
            cbbomon.Name = "cbbomon";
            cbbomon.Size = new Size(263, 33);
            cbbomon.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(858, 132);
            label9.Name = "label9";
            label9.Size = new Size(92, 26);
            label9.TabIndex = 0;
            label9.Text = "Bộ môn:";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtsdt);
            panel9.Controls.Add(label8);
            panel9.Location = new Point(853, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(416, 55);
            panel9.TabIndex = 8;
            // 
            // txtsdt
            // 
            txtsdt.Location = new Point(150, 14);
            txtsdt.Name = "txtsdt";
            txtsdt.Size = new Size(263, 33);
            txtsdt.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 17);
            label8.Name = "label8";
            label8.Size = new Size(141, 26);
            label8.TabIndex = 0;
            label8.Text = "Số điện thoại:";
            // 
            // panel8
            // 
            panel8.Controls.Add(txtemail);
            panel8.Controls.Add(label7);
            panel8.Location = new Point(428, 125);
            panel8.Name = "panel8";
            panel8.Size = new Size(415, 56);
            panel8.TabIndex = 7;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(109, 11);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(303, 33);
            txtemail.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 18);
            label7.Name = "label7";
            label7.Size = new Size(71, 26);
            label7.TabIndex = 0;
            label7.Text = "Email:";
            // 
            // panel7
            // 
            panel7.Controls.Add(cbchucvu);
            panel7.Controls.Add(label6);
            panel7.Location = new Point(428, 64);
            panel7.Name = "panel7";
            panel7.Size = new Size(415, 55);
            panel7.TabIndex = 6;
            // 
            // cbchucvu
            // 
            cbchucvu.FormattingEnabled = true;
            cbchucvu.Location = new Point(109, 15);
            cbchucvu.Name = "cbchucvu";
            cbchucvu.Size = new Size(303, 33);
            cbchucvu.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 19);
            label6.Name = "label6";
            label6.Size = new Size(97, 26);
            label6.TabIndex = 0;
            label6.Text = "Chức vụ:";
            // 
            // panel6
            // 
            panel6.Controls.Add(cbhocvi);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(428, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(415, 55);
            panel6.TabIndex = 5;
            // 
            // cbhocvi
            // 
            cbhocvi.FormattingEnabled = true;
            cbhocvi.Items.AddRange(new object[] { "Giáo sư", "P. Giáo sư", "Tiến sĩ", "Thạc sĩ", "Nghiên cứu sinh" });
            cbhocvi.Location = new Point(109, 14);
            cbhocvi.Name = "cbhocvi";
            cbhocvi.Size = new Size(303, 33);
            cbhocvi.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 17);
            label5.Name = "label5";
            label5.Size = new Size(79, 26);
            label5.TabIndex = 0;
            label5.Text = "Học vị:";
            // 
            // panel5
            // 
            panel5.Controls.Add(cbgioitinh);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(3, 125);
            panel5.Name = "panel5";
            panel5.Size = new Size(415, 56);
            panel5.TabIndex = 4;
            // 
            // cbgioitinh
            // 
            cbgioitinh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbgioitinh.FormattingEnabled = true;
            cbgioitinh.Items.AddRange(new object[] { "Nam", "Nữ" });
            cbgioitinh.Location = new Point(150, 11);
            cbgioitinh.Name = "cbgioitinh";
            cbgioitinh.Size = new Size(262, 33);
            cbgioitinh.TabIndex = 1;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(3, 14);
            label4.Name = "label4";
            label4.Size = new Size(100, 26);
            label4.TabIndex = 0;
            label4.Text = "Giới tính:";
            // 
            // panel2
            // 
            panel2.Controls.Add(txthoten);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(415, 55);
            panel2.TabIndex = 1;
            // 
            // txthoten
            // 
            txthoten.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txthoten.Location = new Point(150, 16);
            txthoten.Name = "txthoten";
            txthoten.Size = new Size(262, 33);
            txthoten.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(3, 19);
            label3.Name = "label3";
            label3.Size = new Size(107, 26);
            label3.TabIndex = 0;
            label3.Text = "Họ và tên:";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(415, 55);
            panel1.TabIndex = 0;
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtid.Location = new Point(150, 14);
            txtid.Name = "txtid";
            txtid.Size = new Size(262, 33);
            txtid.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(144, 26);
            label2.TabIndex = 0;
            label2.Text = "ID giảng viên:";
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(1276, 57);
            panel4.TabIndex = 5;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(406, 6);
            label1.Name = "label1";
            label1.Size = new Size(501, 51);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ GIẢNG VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // fGiangVien
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4);
            MinimumSize = new Size(1300, 700);
            Name = "fGiangVien";
            Text = "fGiangVien";
            Load += fGiangVien_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvgiangvien).EndInit();
            flowLayoutPanel2.ResumeLayout(false);
            tabletextcombo.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dgvgiangvien;
        private Panel panel2;
        private TextBox txthoten;
        private Label label3;
        private Panel panel5;
        private ComboBox cbgioitinh;
        private Label label4;
        private Panel panel6;
        private Label label5;
        private ComboBox cbhocvi;
        private Panel panel7;
        private Panel panel8;
        private Panel panel9;
        private ComboBox cbchucvu;
        private Label label6;
        private TextBox txtemail;
        private Label label7;
        private TextBox txtsdt;
        private Label label8;
        private Panel panel3;
        private ComboBox cbbomon;
        private Label label9;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnclaer;
        private Button btnadd;
        private Button btndelete;
        private Button btnupdate;
        private Button btnprint;
        private Button searchid;
        private Button btnsearchten;
        private Label label10;
        private TableLayoutPanel tabletextcombo;
        private Panel panel1;
        private TextBox txtid;
        private Label label2;
        private DataGridViewTextBoxColumn IDGV;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn HocVi;
        private DataGridViewTextBoxColumn ChucVu;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn BoMon;
        private Panel panel4;
        private Label label1;
        private Button btnload;
    }
}