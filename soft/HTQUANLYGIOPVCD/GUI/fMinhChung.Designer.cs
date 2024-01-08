namespace GUI
{
    partial class fMinhChung
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMinhChung));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnprint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnload = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnxoa = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvminhchung = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDMC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioDaHoanThanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoGioConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiMinhChung = new System.Windows.Forms.DataGridViewLinkColumn();
            this.NgayCapNhat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PheDuyet = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tongso = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvminhchung)).BeginInit();
            this.SuspendLayout();
            // 
            // btnprint
            // 
            this.btnprint.BackColor = System.Drawing.Color.White;
            this.btnprint.BorderRadius = 10;
            this.btnprint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnprint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnprint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnprint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnprint.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnprint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnprint.ForeColor = System.Drawing.Color.Black;
            this.btnprint.Image = ((System.Drawing.Image)(resources.GetObject("btnprint.Image")));
            this.btnprint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprint.ImageSize = new System.Drawing.Size(32, 32);
            this.btnprint.Location = new System.Drawing.Point(513, 43);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(126, 36);
            this.btnprint.TabIndex = 24;
            this.btnprint.Text = "In Excel";
            this.btnprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox1.BorderRadius = 10;
            this.guna2GroupBox1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GroupBox1.Controls.Add(this.tongso);
            this.guna2GroupBox1.Controls.Add(this.btnload);
            this.guna2GroupBox1.Controls.Add(this.txttimkiem);
            this.guna2GroupBox1.Controls.Add(this.btnxoa);
            this.guna2GroupBox1.Controls.Add(this.btnprint);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(7, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1348, 84);
            this.guna2GroupBox1.TabIndex = 28;
            this.guna2GroupBox1.Text = "QUẢN LÝ MINH CHỨNG";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnload.Image = global::GUI.Properties.Resources.load;
            this.btnload.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnload.ImageSize = new System.Drawing.Size(32, 32);
            this.btnload.Location = new System.Drawing.Point(1214, 43);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(127, 36);
            this.btnload.TabIndex = 29;
            this.btnload.Text = "Tải lại";
            this.btnload.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnload.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.White;
            this.txttimkiem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.BorderRadius = 10;
            this.txttimkiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttimkiem.DefaultText = "";
            this.txttimkiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttimkiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttimkiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttimkiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Italic);
            this.txttimkiem.ForeColor = System.Drawing.Color.Black;
            this.txttimkiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttimkiem.Location = new System.Drawing.Point(5, 43);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderText = "Tìm kiếm";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(502, 36);
            this.txttimkiem.TabIndex = 41;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.White;
            this.btnxoa.BorderRadius = 10;
            this.btnxoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnxoa.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnxoa.ForeColor = System.Drawing.Color.Black;
            this.btnxoa.Image = global::GUI.Properties.Resources.delete;
            this.btnxoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnxoa.ImageSize = new System.Drawing.Size(32, 32);
            this.btnxoa.Location = new System.Drawing.Point(645, 43);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(110, 36);
            this.btnxoa.TabIndex = 34;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnxoa.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // dgvminhchung
            // 
            this.dgvminhchung.AllowUserToAddRows = false;
            this.dgvminhchung.AllowUserToResizeColumns = false;
            this.dgvminhchung.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvminhchung.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvminhchung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvminhchung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvminhchung.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvminhchung.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvminhchung.ColumnHeadersHeight = 55;
            this.dgvminhchung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvminhchung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDMC,
            this.IDHD,
            this.IDGV,
            this.Column2,
            this.IDTT,
            this.Column1,
            this.SoGioDaHoanThanh,
            this.SoGioConLai,
            this.LoaiMinhChung,
            this.NgayCapNhat,
            this.PheDuyet});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvminhchung.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvminhchung.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.dgvminhchung.Location = new System.Drawing.Point(5, 102);
            this.dgvminhchung.Name = "dgvminhchung";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvminhchung.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvminhchung.RowHeadersVisible = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvminhchung.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvminhchung.RowTemplate.Height = 24;
            this.dgvminhchung.Size = new System.Drawing.Size(1350, 526);
            this.dgvminhchung.TabIndex = 27;
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
            this.dgvminhchung.ThemeStyle.HeaderStyle.Height = 55;
            this.dgvminhchung.ThemeStyle.ReadOnly = false;
            this.dgvminhchung.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvminhchung.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvminhchung.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvminhchung.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvminhchung.ThemeStyle.RowsStyle.Height = 24;
            this.dgvminhchung.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvminhchung.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvminhchung.DataSourceChanged += new System.EventHandler(this.dgvminhchung_DataSourceChanged);
            this.dgvminhchung.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvminhchung_CellBeginEdit);
            this.dgvminhchung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvminhchung_CellContentClick);
            this.dgvminhchung.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvminhchung_CellFormatting);
            this.dgvminhchung.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvminhchung_CurrentCellDirtyStateChanged);
            // 
            // IDMC
            // 
            this.IDMC.DataPropertyName = "IDMC";
            this.IDMC.HeaderText = "Minh chứng";
            this.IDMC.Name = "IDMC";
            this.IDMC.Width = 125;
            // 
            // IDHD
            // 
            this.IDHD.DataPropertyName = "IDHD";
            this.IDHD.HeaderText = "Hoạt động";
            this.IDHD.Name = "IDHD";
            this.IDHD.Width = 110;
            // 
            // IDGV
            // 
            this.IDGV.DataPropertyName = "IDGV";
            this.IDGV.HeaderText = "IDGV";
            this.IDGV.Name = "IDGV";
            this.IDGV.Width = 115;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoTen";
            this.Column2.HeaderText = "Giảng viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // IDTT
            // 
            this.IDTT.DataPropertyName = "TenTT";
            this.IDTT.HeaderText = "Trạng thái";
            this.IDTT.Name = "IDTT";
            this.IDTT.Width = 150;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "IDTT";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // SoGioDaHoanThanh
            // 
            this.SoGioDaHoanThanh.DataPropertyName = "SoGioDaHoanThanh";
            this.SoGioDaHoanThanh.HeaderText = "Số giờ hoàn thành";
            this.SoGioDaHoanThanh.Name = "SoGioDaHoanThanh";
            this.SoGioDaHoanThanh.Width = 170;
            // 
            // SoGioConLai
            // 
            this.SoGioConLai.DataPropertyName = "SoGioConLai";
            this.SoGioConLai.HeaderText = "Số giờ còn lại";
            this.SoGioConLai.Name = "SoGioConLai";
            this.SoGioConLai.Width = 140;
            // 
            // LoaiMinhChung
            // 
            this.LoaiMinhChung.DataPropertyName = "LoaiMinhChung";
            this.LoaiMinhChung.HeaderText = "Link minh chứng";
            this.LoaiMinhChung.Name = "LoaiMinhChung";
            this.LoaiMinhChung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.LoaiMinhChung.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.LoaiMinhChung.Width = 150;
            // 
            // NgayCapNhat
            // 
            this.NgayCapNhat.DataPropertyName = "NgayCapNhat";
            this.NgayCapNhat.HeaderText = "Ngày cập nhật";
            this.NgayCapNhat.Name = "NgayCapNhat";
            this.NgayCapNhat.Width = 140;
            // 
            // PheDuyet
            // 
            this.PheDuyet.DataPropertyName = "IDTT";
            this.PheDuyet.FalseValue = "cpd";
            this.PheDuyet.HeaderText = "Phê duyệt";
            this.PheDuyet.Name = "PheDuyet";
            this.PheDuyet.TrueValue = "dpd";
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
            this.tongso.Location = new System.Drawing.Point(761, 43);
            this.tongso.Name = "tongso";
            this.tongso.Size = new System.Drawing.Size(447, 36);
            this.tongso.TabIndex = 42;
            this.tongso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fMinhChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 640);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.dgvminhchung);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fMinhChung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMinhChung";
            this.Load += new System.EventHandler(this.fMinhChung_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvminhchung)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnprint;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvminhchung;
        private Guna.UI2.WinForms.Guna2GradientButton btnxoa;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDMC;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioDaHoanThanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoGioConLai;
        private System.Windows.Forms.DataGridViewLinkColumn LoaiMinhChung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayCapNhat;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PheDuyet;
        private Guna.UI2.WinForms.Guna2GradientButton btnload;
        private Guna.UI2.WinForms.Guna2Button tongso;

    }
}