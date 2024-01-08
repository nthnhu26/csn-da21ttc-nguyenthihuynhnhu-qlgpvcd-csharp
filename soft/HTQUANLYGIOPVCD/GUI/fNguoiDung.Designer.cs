namespace GUI
{
    partial class fNguoiDung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNguoiDung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btndelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btngioconlai = new Guna.UI2.WinForms.Guna2Button();
            this.dgvminhchung = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnsearch = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbidtt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.IDMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDGV2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioDaHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMinhChung = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongso = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvminhchung)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.White;
            this.btndelete.BorderRadius = 10;
            this.btndelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btndelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btndelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btndelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btndelete.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btndelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.Image")));
            this.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndelete.ImageSize = new System.Drawing.Size(32, 32);
            this.btndelete.Location = new System.Drawing.Point(690, 54);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(144, 36);
            this.btndelete.TabIndex = 36;
            this.btndelete.Text = "Xóa";
            this.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btngioconlai
            // 
            this.btngioconlai.BackColor = System.Drawing.Color.White;
            this.btngioconlai.BorderRadius = 10;
            this.btngioconlai.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngioconlai.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngioconlai.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngioconlai.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngioconlai.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.btngioconlai.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngioconlai.ForeColor = System.Drawing.Color.Black;
            this.btngioconlai.Location = new System.Drawing.Point(781, 110);
            this.btngioconlai.Name = "btngioconlai";
            this.btngioconlai.Size = new System.Drawing.Size(547, 44);
            this.btngioconlai.TabIndex = 35;
            this.btngioconlai.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dgvminhchung
            // 
            this.dgvminhchung.AllowUserToAddRows = false;
            this.dgvminhchung.AllowUserToResizeColumns = false;
            this.dgvminhchung.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvminhchung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvminhchung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvminhchung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvminhchung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvminhchung.ColumnHeadersHeight = 50;
            this.dgvminhchung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvminhchung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMC,
            this.IDHD,
            this.IDGV2,
            this.TenTT,
            this.Column1,
            this.SoGioDaHoanThanh,
            this.SoGioConLai,
            this.LoaiMinhChung,
            this.NgayCapNhat});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvminhchung.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvminhchung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.dgvminhchung.Location = new System.Drawing.Point(5, 178);
            this.dgvminhchung.MultiSelect = false;
            this.dgvminhchung.Name = "dgvminhchung";
            this.dgvminhchung.ReadOnly = true;
            this.dgvminhchung.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvminhchung.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvminhchung.RowHeadersVisible = false;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvminhchung.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvminhchung.RowTemplate.Height = 25;
            this.dgvminhchung.Size = new System.Drawing.Size(1350, 450);
            this.dgvminhchung.TabIndex = 36;
            this.dgvminhchung.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvminhchung.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvminhchung.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvminhchung.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvminhchung.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvminhchung.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvminhchung.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.dgvminhchung.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.dgvminhchung.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvminhchung.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvminhchung.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvminhchung.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvminhchung.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvminhchung.ThemeStyle.ReadOnly = true;
            this.dgvminhchung.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvminhchung.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvminhchung.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvminhchung.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvminhchung.ThemeStyle.RowsStyle.Height = 25;
            this.dgvminhchung.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvminhchung.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvminhchung.DataSourceChanged += new System.EventHandler(this.dgvminhchung_DataSourceChanged);
            this.dgvminhchung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvminhchung_CellContentClick);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox2.BorderRadius = 10;
            this.guna2GroupBox2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GroupBox2.Controls.Add(this.tongso);
            this.guna2GroupBox2.Controls.Add(this.btnload);
            this.guna2GroupBox2.Controls.Add(this.btnsearch);
            this.guna2GroupBox2.Controls.Add(this.cmbidtt);
            this.guna2GroupBox2.Controls.Add(this.btndelete);
            this.guna2GroupBox2.Controls.Add(this.btngioconlai);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.guna2GroupBox2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(5, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(1350, 170);
            this.guna2GroupBox2.TabIndex = 35;
            this.guna2GroupBox2.Text = "CẬP NHẬT HOẠT ĐỘNG";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.White;
            this.btnload.BorderRadius = 10;
            this.btnload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnload.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnload.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnload.ForeColor = System.Drawing.Color.Black;
            this.btnload.Image = ((System.Drawing.Image)(resources.GetObject("btnload.Image")));
            this.btnload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnload.ImageSize = new System.Drawing.Size(32, 32);
            this.btnload.Location = new System.Drawing.Point(854, 54);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(144, 36);
            this.btnload.TabIndex = 39;
            this.btnload.Text = "Tải lại";
            this.btnload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnload.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.White;
            this.btnsearch.BorderRadius = 10;
            this.btnsearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearch.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnsearch.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnsearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnsearch.ForeColor = System.Drawing.Color.Black;
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsearch.ImageSize = new System.Drawing.Size(32, 32);
            this.btnsearch.Location = new System.Drawing.Point(527, 54);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(144, 36);
            this.btnsearch.TabIndex = 38;
            this.btnsearch.Text = "Tìm kiếm";
            this.btnsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // cmbidtt
            // 
            this.cmbidtt.BackColor = System.Drawing.Color.White;
            this.cmbidtt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbidtt.BorderRadius = 10;
            this.cmbidtt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbidtt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbidtt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbidtt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbidtt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbidtt.ForeColor = System.Drawing.Color.Black;
            this.cmbidtt.ItemHeight = 30;
            this.cmbidtt.Location = new System.Drawing.Point(271, 54);
            this.cmbidtt.Name = "cmbidtt";
            this.cmbidtt.Size = new System.Drawing.Size(227, 36);
            this.cmbidtt.TabIndex = 37;
            // 
            // IDMC
            // 
            this.IDMC.DataPropertyName = "IDMC";
            this.IDMC.HeaderText = "ID minh chứng";
            this.IDMC.Name = "IDMC";
            this.IDMC.ReadOnly = true;
            this.IDMC.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // IDHD
            // 
            this.IDHD.DataPropertyName = "IDHD";
            this.IDHD.HeaderText = "ID hoạt động";
            this.IDHD.Name = "IDHD";
            this.IDHD.ReadOnly = true;
            // 
            // IDGV2
            // 
            this.IDGV2.DataPropertyName = "IDGV";
            this.IDGV2.HeaderText = "ID giảng viên";
            this.IDGV2.Name = "IDGV2";
            this.IDGV2.ReadOnly = true;
            // 
            // TenTT
            // 
            this.TenTT.DataPropertyName = "TenTT";
            this.TenTT.HeaderText = "Trạng thái";
            this.TenTT.Name = "TenTT";
            this.TenTT.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDTT";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // SoGioDaHoanThanh
            // 
            this.SoGioDaHoanThanh.DataPropertyName = "SoGioDaHoanThanh";
            this.SoGioDaHoanThanh.HeaderText = "Số giờ đã hoàn thành";
            this.SoGioDaHoanThanh.Name = "SoGioDaHoanThanh";
            this.SoGioDaHoanThanh.ReadOnly = true;
            // 
            // SoGioConLai
            // 
            this.SoGioConLai.DataPropertyName = "SoGioConLai";
            this.SoGioConLai.HeaderText = "Số giờ còn lại";
            this.SoGioConLai.Name = "SoGioConLai";
            this.SoGioConLai.ReadOnly = true;
            // 
            // LoaiMinhChung
            // 
            this.LoaiMinhChung.DataPropertyName = "LoaiMinhChung";
            this.LoaiMinhChung.HeaderText = "Đường dẫn";
            this.LoaiMinhChung.Name = "LoaiMinhChung";
            this.LoaiMinhChung.ReadOnly = true;
            this.LoaiMinhChung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiMinhChung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày cập nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            this.NgayCapNhat.ReadOnly = true;
            // 
            // tongso
            // 
            this.tongso.BackColor = System.Drawing.Color.White;
            this.tongso.BorderRadius = 10;
            this.tongso.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tongso.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tongso.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tongso.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tongso.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(219)))), ((int)(((byte)(255)))));
            this.tongso.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tongso.ForeColor = System.Drawing.Color.Black;
            this.tongso.Location = new System.Drawing.Point(36, 110);
            this.tongso.Name = "tongso";
            this.tongso.Size = new System.Drawing.Size(500, 44);
            this.tongso.TabIndex = 43;
            this.tongso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 640);
            this.Controls.Add(this.dgvminhchung);
            this.Controls.Add(this.guna2GroupBox2);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fNguoiDung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fNguoiDung";
            this.Load += new System.EventHandler(this.fNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvminhchung)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btndelete;
        private Guna.UI2.WinForms.Guna2Button btngioconlai;
        private Guna.UI2.WinForms.Guna2DataGridView dgvminhchung;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GradientButton btnsearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbidtt;
        private Guna.UI2.WinForms.Guna2GradientButton btnload;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGV2;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioDaHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioConLai;
        private System.Windows.Forms.DataGridViewLinkColumn LoaiMinhChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private Guna.UI2.WinForms.Guna2Button tongso;


    }
}