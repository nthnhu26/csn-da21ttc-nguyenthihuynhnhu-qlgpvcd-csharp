namespace GUI
{
    partial class fHoatDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoatDong));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnclear = new Button();
            btnadd = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnsearchid = new Button();
            btnsearchten = new Button();
            btnload = new Button();
            btnprint = new Button();
            label1 = new Label();
            tabletextcombotime = new TableLayoutPanel();
            panel1 = new Panel();
            txtid = new TextBox();
            label2 = new Label();
            panel2 = new Panel();
            dtpbatdau = new DateTimePicker();
            label3 = new Label();
            panel3 = new Panel();
            txtten = new TextBox();
            label4 = new Label();
            panel4 = new Panel();
            dtpketthuc = new DateTimePicker();
            label5 = new Label();
            panel5 = new Panel();
            txtsogio = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            cbdonvitinh = new ComboBox();
            label7 = new Label();
            dgvhoatdong = new DataGridView();
            IDHD = new DataGridViewTextBoxColumn();
            TenHD = new DataGridViewTextBoxColumn();
            SoGioQuyDinh = new DataGridViewTextBoxColumn();
            NgayBatDau = new DataGridViewTextBoxColumn();
            NgayKetThuc = new DataGridViewTextBoxColumn();
            DonViTinh = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            tabletextcombotime.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoatdong).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tabletextcombotime, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvhoatdong, 0, 3);
            tableLayoutPanel1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.2105255F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.31579F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.4736843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 343F));
            tableLayoutPanel1.Size = new Size(1258, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnclear);
            flowLayoutPanel2.Controls.Add(btnadd);
            flowLayoutPanel2.Controls.Add(btndelete);
            flowLayoutPanel2.Controls.Add(btnupdate);
            flowLayoutPanel2.Controls.Add(btnsearchid);
            flowLayoutPanel2.Controls.Add(btnsearchten);
            flowLayoutPanel2.Controls.Add(btnload);
            flowLayoutPanel2.Controls.Add(btnprint);
            flowLayoutPanel2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel2.Location = new Point(3, 204);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(6);
            flowLayoutPanel2.Size = new Size(1252, 67);
            flowLayoutPanel2.TabIndex = 4;
            // 
            // btnclear
            // 
            btnclear.Image = (Image)resources.GetObject("btnclear.Image");
            btnclear.Location = new Point(9, 9);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(140, 50);
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
            btnadd.Location = new Point(155, 9);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(127, 50);
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
            btndelete.Location = new Point(288, 9);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(107, 50);
            btndelete.TabIndex = 2;
            btndelete.Text = "Xóa";
            btndelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // btnupdate
            // 
            btnupdate.Image = (Image)resources.GetObject("btnupdate.Image");
            btnupdate.Location = new Point(401, 9);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(146, 50);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Cập nhật";
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsearchid
            // 
            btnsearchid.Image = (Image)resources.GetObject("btnsearchid.Image");
            btnsearchid.Location = new Point(553, 9);
            btnsearchid.Name = "btnsearchid";
            btnsearchid.Size = new Size(141, 50);
            btnsearchid.TabIndex = 5;
            btnsearchid.Text = "Tìm ID";
            btnsearchid.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsearchid.UseVisualStyleBackColor = true;
            btnsearchid.Click += btnsearchid_Click;
            // 
            // btnsearchten
            // 
            btnsearchten.Image = (Image)resources.GetObject("btnsearchten.Image");
            btnsearchten.Location = new Point(700, 9);
            btnsearchten.Name = "btnsearchten";
            btnsearchten.Size = new Size(133, 50);
            btnsearchten.TabIndex = 6;
            btnsearchten.Text = "Tìm tên";
            btnsearchten.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsearchten.UseVisualStyleBackColor = true;
            btnsearchten.Click += btnsearchten_Click;
            // 
            // btnload
            // 
            btnload.Image = (Image)resources.GetObject("btnload.Image");
            btnload.Location = new Point(839, 9);
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
            btnprint.Location = new Point(1030, 9);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(181, 50);
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
            label1.Size = new Size(1252, 69);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ CÁC HOẠT ĐỘNG PHỤC VỤ CỘNG ĐỒNG";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabletextcombotime
            // 
            tabletextcombotime.ColumnCount = 3;
            tabletextcombotime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.11182F));
            tabletextcombotime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 39.6964874F));
            tabletextcombotime.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.2715664F));
            tabletextcombotime.Controls.Add(panel1, 0, 0);
            tabletextcombotime.Controls.Add(panel2, 0, 1);
            tabletextcombotime.Controls.Add(panel3, 1, 0);
            tabletextcombotime.Controls.Add(panel4, 1, 1);
            tabletextcombotime.Controls.Add(panel5, 2, 0);
            tabletextcombotime.Controls.Add(panel6, 2, 1);
            tabletextcombotime.Location = new Point(3, 72);
            tabletextcombotime.Name = "tabletextcombotime";
            tabletextcombotime.RowCount = 2;
            tabletextcombotime.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabletextcombotime.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tabletextcombotime.Size = new Size(1252, 114);
            tabletextcombotime.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtid);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(370, 51);
            panel1.TabIndex = 0;
            // 
            // txtid
            // 
            txtid.Location = new Point(145, 9);
            txtid.Name = "txtid";
            txtid.Size = new Size(223, 33);
            txtid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 12);
            label2.Name = "label2";
            label2.Size = new Size(141, 26);
            label2.TabIndex = 0;
            label2.Text = "ID hoạt động:";
            // 
            // panel2
            // 
            panel2.Controls.Add(dtpbatdau);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(3, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(370, 51);
            panel2.TabIndex = 1;
            // 
            // dtpbatdau
            // 
            dtpbatdau.Format = DateTimePickerFormat.Short;
            dtpbatdau.Location = new Point(144, 8);
            dtpbatdau.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpbatdau.MinDate = new DateTime(2023, 12, 1, 20, 50, 10, 0);
            dtpbatdau.Name = "dtpbatdau";
            dtpbatdau.Size = new Size(223, 33);
            dtpbatdau.TabIndex = 2;
            dtpbatdau.Value = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 11);
            label3.Name = "label3";
            label3.Size = new Size(140, 26);
            label3.TabIndex = 1;
            label3.Text = "Ngày bắt đầu:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txtten);
            panel3.Controls.Add(label4);
            panel3.Location = new Point(379, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(490, 51);
            panel3.TabIndex = 2;
            // 
            // txtten
            // 
            txtten.Location = new Point(162, 9);
            txtten.Name = "txtten";
            txtten.Size = new Size(321, 33);
            txtten.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 12);
            label4.Name = "label4";
            label4.Size = new Size(153, 26);
            label4.TabIndex = 0;
            label4.Text = "Tên hoạt động:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dtpketthuc);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(379, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(490, 51);
            panel4.TabIndex = 3;
            // 
            // dtpketthuc
            // 
            dtpketthuc.Format = DateTimePickerFormat.Short;
            dtpketthuc.Location = new Point(162, 8);
            dtpketthuc.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpketthuc.MinDate = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            dtpketthuc.Name = "dtpketthuc";
            dtpketthuc.Size = new Size(321, 33);
            dtpketthuc.TabIndex = 1;
            dtpketthuc.UseWaitCursor = true;
            dtpketthuc.Value = new DateTime(2023, 12, 3, 0, 0, 0, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 11);
            label5.Name = "label5";
            label5.Size = new Size(146, 26);
            label5.TabIndex = 0;
            label5.Text = "Ngày kết thúc:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txtsogio);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(875, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(374, 51);
            panel5.TabIndex = 4;
            // 
            // txtsogio
            // 
            txtsogio.Location = new Point(176, 9);
            txtsogio.Name = "txtsogio";
            txtsogio.Size = new Size(192, 33);
            txtsogio.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 12);
            label6.Name = "label6";
            label6.Size = new Size(167, 26);
            label6.TabIndex = 0;
            label6.Text = "Số giờ quy định:";
            // 
            // panel6
            // 
            panel6.Controls.Add(cbdonvitinh);
            panel6.Controls.Add(label7);
            panel6.Location = new Point(875, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(374, 51);
            panel6.TabIndex = 5;
            // 
            // cbdonvitinh
            // 
            cbdonvitinh.FormattingEnabled = true;
            cbdonvitinh.Location = new Point(176, 11);
            cbdonvitinh.Name = "cbdonvitinh";
            cbdonvitinh.Size = new Size(192, 33);
            cbdonvitinh.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 11);
            label7.Name = "label7";
            label7.Size = new Size(125, 26);
            label7.TabIndex = 0;
            label7.Text = "Đơn vị tính:";
            // 
            // dgvhoatdong
            // 
            dgvhoatdong.AllowUserToAddRows = false;
            dgvhoatdong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoatdong.Columns.AddRange(new DataGridViewColumn[] { IDHD, TenHD, SoGioQuyDinh, NgayBatDau, NgayKetThuc, DonViTinh });
            dgvhoatdong.Dock = DockStyle.Fill;
            dgvhoatdong.Location = new Point(3, 288);
            dgvhoatdong.Name = "dgvhoatdong";
            dgvhoatdong.ReadOnly = true;
            dgvhoatdong.RowHeadersWidth = 51;
            dgvhoatdong.Size = new Size(1252, 338);
            dgvhoatdong.TabIndex = 2;
            dgvhoatdong.CellClick += dgvhoatdong_CellClick;
            // 
            // IDHD
            // 
            IDHD.DataPropertyName = "IDHD";
            IDHD.HeaderText = "ID Hoạt động";
            IDHD.MinimumWidth = 6;
            IDHD.Name = "IDHD";
            IDHD.ReadOnly = true;
            IDHD.Width = 125;
            // 
            // TenHD
            // 
            TenHD.DataPropertyName = "TenHD";
            TenHD.HeaderText = "Tên hoạt động";
            TenHD.MinimumWidth = 6;
            TenHD.Name = "TenHD";
            TenHD.ReadOnly = true;
            TenHD.Width = 125;
            // 
            // SoGioQuyDinh
            // 
            SoGioQuyDinh.DataPropertyName = "SoGioQuyDinh";
            SoGioQuyDinh.HeaderText = "Số giờ quy định";
            SoGioQuyDinh.MinimumWidth = 6;
            SoGioQuyDinh.Name = "SoGioQuyDinh";
            SoGioQuyDinh.ReadOnly = true;
            SoGioQuyDinh.Width = 125;
            // 
            // NgayBatDau
            // 
            NgayBatDau.DataPropertyName = "NgayBatDau";
            NgayBatDau.HeaderText = "Ngày bắt đầu";
            NgayBatDau.MinimumWidth = 6;
            NgayBatDau.Name = "NgayBatDau";
            NgayBatDau.ReadOnly = true;
            NgayBatDau.Width = 125;
            // 
            // NgayKetThuc
            // 
            NgayKetThuc.DataPropertyName = "NgayKetThuc";
            NgayKetThuc.HeaderText = "Ngày kết thúc";
            NgayKetThuc.MinimumWidth = 6;
            NgayKetThuc.Name = "NgayKetThuc";
            NgayKetThuc.ReadOnly = true;
            NgayKetThuc.Width = 125;
            // 
            // DonViTinh
            // 
            DonViTinh.DataPropertyName = "DonViTinh";
            DonViTinh.HeaderText = "Đơn vị tính";
            DonViTinh.MinimumWidth = 6;
            DonViTinh.Name = "DonViTinh";
            DonViTinh.ReadOnly = true;
            DonViTinh.Width = 125;
            // 
            // fHoatDong
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(1300, 700);
            MinimumSize = new Size(1300, 700);
            Name = "fHoatDong";
            Text = "fHoatDong";
            Load += fHoatDong_Load;
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            tabletextcombotime.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoatdong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private TableLayoutPanel tabletextcombotime;
        private Panel panel1;
        private TextBox txtid;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private TextBox txtten;
        private Label label4;
        private Panel panel4;
        private Label label5;
        private Panel panel5;
        private TextBox txtsogio;
        private Label label6;
        private Panel panel6;
        private Label label7;
        private DataGridView dgvhoatdong;
        private DataGridViewTextBoxColumn IDHD;
        private DataGridViewTextBoxColumn TenHD;
        private DataGridViewTextBoxColumn SoGioQuyDinh;
        private DataGridViewTextBoxColumn NgayBatDau;
        private DataGridViewTextBoxColumn NgayKetThuc;
        private DataGridViewTextBoxColumn DonViTinh;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnclear;
        private Button btnadd;
        private Button btndelete;
        private Button btnupdate;
        private Button btnsearchid;
        private Button btnsearchten;
        private Button btnprint;
        private DateTimePicker dtpbatdau;
        private DateTimePicker dtpketthuc;
        private ComboBox cbdonvitinh;
        private Button btnload;
    }
}