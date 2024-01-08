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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnprint = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnupdate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btndelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnadd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnclear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dgvgiangvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.IDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HocVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoMon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioChuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nupgiochuan = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.cmbbomon = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtemail = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbchucvu = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtsdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbhocvi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txthotengv = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbgioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtidgv = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tongso = new Guna.UI2.WinForms.Guna2Button();
            this.txttimkiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiangvien)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupgiochuan)).BeginInit();
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
            this.btnprint.Image = global::GUI.Properties.Resources.print;
            this.btnprint.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprint.ImageSize = new System.Drawing.Size(32, 32);
            this.btnprint.Location = new System.Drawing.Point(1001, 191);
            this.btnprint.Name = "btnprint";
            this.btnprint.Size = new System.Drawing.Size(144, 45);
            this.btnprint.TabIndex = 24;
            this.btnprint.Text = "In Excel";
            this.btnprint.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnprint.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnprint.Click += new System.EventHandler(this.btnprint_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.BorderRadius = 10;
            this.btnupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnupdate.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnupdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.Black;
            this.btnupdate.Image = global::GUI.Properties.Resources.capnhat;
            this.btnupdate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnupdate.ImageSize = new System.Drawing.Size(32, 32);
            this.btnupdate.Location = new System.Drawing.Point(815, 191);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(144, 45);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnupdate.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
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
            this.btndelete.Image = global::GUI.Properties.Resources.delete;
            this.btndelete.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndelete.ImageSize = new System.Drawing.Size(32, 32);
            this.btndelete.Location = new System.Drawing.Point(627, 191);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(144, 45);
            this.btndelete.TabIndex = 22;
            this.btndelete.Text = "Xóa";
            this.btndelete.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btndelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.White;
            this.btnadd.BorderRadius = 10;
            this.btnadd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnadd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnadd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnadd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnadd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnadd.ForeColor = System.Drawing.Color.Black;
            this.btnadd.Image = global::GUI.Properties.Resources.them;
            this.btnadd.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnadd.ImageSize = new System.Drawing.Size(32, 32);
            this.btnadd.Location = new System.Drawing.Point(439, 191);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(144, 45);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "Thêm ";
            this.btnadd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnadd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.White;
            this.btnclear.BorderRadius = 10;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnclear.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnclear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.Image = global::GUI.Properties.Resources.clear;
            this.btnclear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnclear.ImageSize = new System.Drawing.Size(32, 32);
            this.btnclear.Location = new System.Drawing.Point(250, 191);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(144, 45);
            this.btnclear.TabIndex = 17;
            this.btnclear.Text = "Làm mới";
            this.btnclear.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnclear.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // dgvgiangvien
            // 
            this.dgvgiangvien.AllowUserToAddRows = false;
            this.dgvgiangvien.AllowUserToResizeColumns = false;
            this.dgvgiangvien.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvgiangvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvgiangvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvgiangvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvgiangvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgiangvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvgiangvien.ColumnHeadersHeight = 50;
            this.dgvgiangvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvgiangvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDGV,
            this.HoTen,
            this.GioiTinh,
            this.HocVi,
            this.ChucVu,
            this.Email,
            this.SoDienThoai,
            this.BoMon,
            this.GioChuan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvgiangvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvgiangvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.dgvgiangvien.Location = new System.Drawing.Point(5, 299);
            this.dgvgiangvien.MultiSelect = false;
            this.dgvgiangvien.Name = "dgvgiangvien";
            this.dgvgiangvien.ReadOnly = true;
            this.dgvgiangvien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvgiangvien.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvgiangvien.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvgiangvien.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvgiangvien.RowTemplate.Height = 24;
            this.dgvgiangvien.Size = new System.Drawing.Size(1350, 329);
            this.dgvgiangvien.TabIndex = 25;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvgiangvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvgiangvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(219)))), ((int)(((byte)(233)))));
            this.dgvgiangvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.dgvgiangvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.dgvgiangvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvgiangvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvgiangvien.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvgiangvien.ThemeStyle.ReadOnly = true;
            this.dgvgiangvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvgiangvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvgiangvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvgiangvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvgiangvien.ThemeStyle.RowsStyle.Height = 24;
            this.dgvgiangvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvgiangvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvgiangvien.DataSourceChanged += new System.EventHandler(this.dgvgiangvien_DataSourceChanged);
            this.dgvgiangvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvgiangvien_CellClick);
            // 
            // IDGV
            // 
            this.IDGV.DataPropertyName = "IDGV";
            this.IDGV.HeaderText = "Giảng viên";
            this.IDGV.Name = "IDGV";
            this.IDGV.ReadOnly = true;
            this.IDGV.Width = 115;
            // 
            // HoTen
            // 
            this.HoTen.DataPropertyName = "HoTen";
            this.HoTen.HeaderText = "Họ tên";
            this.HoTen.Name = "HoTen";
            this.HoTen.ReadOnly = true;
            this.HoTen.Width = 210;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.ReadOnly = true;
            // 
            // HocVi
            // 
            this.HocVi.DataPropertyName = "HocVi";
            this.HocVi.HeaderText = "Học vị";
            this.HocVi.Name = "HocVi";
            this.HocVi.ReadOnly = true;
            this.HocVi.Width = 130;
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            this.ChucVu.ReadOnly = true;
            this.ChucVu.Width = 170;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 195;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoai";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            this.SoDienThoai.ReadOnly = true;
            this.SoDienThoai.Width = 128;
            // 
            // BoMon
            // 
            this.BoMon.DataPropertyName = "BoMon";
            this.BoMon.HeaderText = "Bộ môn";
            this.BoMon.Name = "BoMon";
            this.BoMon.ReadOnly = true;
            this.BoMon.Width = 170;
            // 
            // GioChuan
            // 
            this.GioChuan.DataPropertyName = "GioChuan";
            this.GioChuan.HeaderText = "Giờ chuẩn";
            this.GioChuan.Name = "GioChuan";
            this.GioChuan.ReadOnly = true;
            this.GioChuan.Width = 110;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GroupBox3.Controls.Add(this.btnprint);
            this.guna2GroupBox3.Controls.Add(this.btnupdate);
            this.guna2GroupBox3.Controls.Add(this.label1);
            this.guna2GroupBox3.Controls.Add(this.btnclear);
            this.guna2GroupBox3.Controls.Add(this.btndelete);
            this.guna2GroupBox3.Controls.Add(this.nupgiochuan);
            this.guna2GroupBox3.Controls.Add(this.cmbbomon);
            this.guna2GroupBox3.Controls.Add(this.btnadd);
            this.guna2GroupBox3.Controls.Add(this.txtemail);
            this.guna2GroupBox3.Controls.Add(this.cmbchucvu);
            this.guna2GroupBox3.Controls.Add(this.txtsdt);
            this.guna2GroupBox3.Controls.Add(this.cmbhocvi);
            this.guna2GroupBox3.Controls.Add(this.txthotengv);
            this.guna2GroupBox3.Controls.Add(this.cmbgioitinh);
            this.guna2GroupBox3.Controls.Add(this.txtidgv);
            this.guna2GroupBox3.Controls.Add(this.label10);
            this.guna2GroupBox3.Controls.Add(this.label11);
            this.guna2GroupBox3.Controls.Add(this.label12);
            this.guna2GroupBox3.Controls.Add(this.label13);
            this.guna2GroupBox3.Controls.Add(this.label14);
            this.guna2GroupBox3.Controls.Add(this.label15);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.Controls.Add(this.label17);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(5, 2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1350, 247);
            this.guna2GroupBox3.TabIndex = 33;
            this.guna2GroupBox3.Text = "QUẢN LÝ THÔNG TIN GIẢNG VIÊN";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(960, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Giờ chuẩn:";
            // 
            // nupgiochuan
            // 
            this.nupgiochuan.BackColor = System.Drawing.Color.Transparent;
            this.nupgiochuan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nupgiochuan.BorderRadius = 10;
            this.nupgiochuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nupgiochuan.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupgiochuan.Location = new System.Drawing.Point(1092, 138);
            this.nupgiochuan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nupgiochuan.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.nupgiochuan.Name = "nupgiochuan";
            this.nupgiochuan.Size = new System.Drawing.Size(240, 36);
            this.nupgiochuan.TabIndex = 27;
            this.nupgiochuan.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.nupgiochuan.UpDownButtonForeColor = System.Drawing.Color.Black;
            // 
            // cmbbomon
            // 
            this.cmbbomon.BackColor = System.Drawing.Color.White;
            this.cmbbomon.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbomon.BorderRadius = 10;
            this.cmbbomon.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbbomon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbomon.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbomon.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbbomon.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbomon.ForeColor = System.Drawing.Color.Black;
            this.cmbbomon.ItemHeight = 30;
            this.cmbbomon.Items.AddRange(new object[] {
            "Công nghệ thông tin",
            "Xây dựng ",
            "Điện - Điện tử",
            "Cơ khí - Động lực"});
            this.cmbbomon.Location = new System.Drawing.Point(1092, 50);
            this.cmbbomon.Name = "cmbbomon";
            this.cmbbomon.Size = new System.Drawing.Size(242, 36);
            this.cmbbomon.TabIndex = 26;
            // 
            // txtemail
            // 
            this.txtemail.BackColor = System.Drawing.Color.White;
            this.txtemail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.BorderRadius = 10;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.DefaultText = "";
            this.txtemail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtemail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtemail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtemail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtemail.ForeColor = System.Drawing.Color.Black;
            this.txtemail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtemail.Location = new System.Drawing.Point(1092, 96);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.PlaceholderText = "";
            this.txtemail.SelectedText = "";
            this.txtemail.Size = new System.Drawing.Size(240, 34);
            this.txtemail.TabIndex = 25;
            // 
            // cmbchucvu
            // 
            this.cmbchucvu.BackColor = System.Drawing.Color.White;
            this.cmbchucvu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbchucvu.BorderRadius = 10;
            this.cmbchucvu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbchucvu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbchucvu.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbchucvu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbchucvu.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbchucvu.ForeColor = System.Drawing.Color.Black;
            this.cmbchucvu.ItemHeight = 30;
            this.cmbchucvu.Items.AddRange(new object[] {
            "Giảng viên ",
            "Chuyên gia đầu ngành",
            "Trưởng bộ môn",
            "Phó trưởng bộ môn"});
            this.cmbchucvu.Location = new System.Drawing.Point(644, 137);
            this.cmbchucvu.Name = "cmbchucvu";
            this.cmbchucvu.Size = new System.Drawing.Size(242, 36);
            this.cmbchucvu.TabIndex = 24;
            // 
            // txtsdt
            // 
            this.txtsdt.BackColor = System.Drawing.Color.White;
            this.txtsdt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.BorderRadius = 10;
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.DefaultText = "";
            this.txtsdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsdt.ForeColor = System.Drawing.Color.Black;
            this.txtsdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtsdt.Location = new System.Drawing.Point(644, 50);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtsdt.PlaceholderText = "";
            this.txtsdt.SelectedText = "";
            this.txtsdt.Size = new System.Drawing.Size(240, 36);
            this.txtsdt.TabIndex = 23;
            // 
            // cmbhocvi
            // 
            this.cmbhocvi.BackColor = System.Drawing.Color.White;
            this.cmbhocvi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbhocvi.BorderRadius = 10;
            this.cmbhocvi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbhocvi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbhocvi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbhocvi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbhocvi.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbhocvi.ForeColor = System.Drawing.Color.Black;
            this.cmbhocvi.ItemHeight = 30;
            this.cmbhocvi.Items.AddRange(new object[] {
            "Thạc sĩ",
            "Tiến sĩ",
            "Nghiên cứu sinh",
            "Giáo sư",
            "Phó giáo sư"});
            this.cmbhocvi.Location = new System.Drawing.Point(644, 93);
            this.cmbhocvi.Name = "cmbhocvi";
            this.cmbhocvi.Size = new System.Drawing.Size(242, 36);
            this.cmbhocvi.TabIndex = 22;
            // 
            // txthotengv
            // 
            this.txthotengv.BackColor = System.Drawing.Color.White;
            this.txthotengv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthotengv.BorderRadius = 10;
            this.txthotengv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthotengv.DefaultText = "";
            this.txthotengv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txthotengv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txthotengv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthotengv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txthotengv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthotengv.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthotengv.ForeColor = System.Drawing.Color.Black;
            this.txthotengv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txthotengv.Location = new System.Drawing.Point(171, 94);
            this.txthotengv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txthotengv.Name = "txthotengv";
            this.txthotengv.PasswordChar = '\0';
            this.txthotengv.PlaceholderText = "";
            this.txthotengv.SelectedText = "";
            this.txthotengv.Size = new System.Drawing.Size(240, 36);
            this.txthotengv.TabIndex = 21;
            // 
            // cmbgioitinh
            // 
            this.cmbgioitinh.BackColor = System.Drawing.Color.White;
            this.cmbgioitinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbgioitinh.BorderRadius = 10;
            this.cmbgioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbgioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbgioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbgioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbgioitinh.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbgioitinh.ForeColor = System.Drawing.Color.Black;
            this.cmbgioitinh.ItemHeight = 30;
            this.cmbgioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cmbgioitinh.Location = new System.Drawing.Point(171, 137);
            this.cmbgioitinh.Name = "cmbgioitinh";
            this.cmbgioitinh.Size = new System.Drawing.Size(242, 36);
            this.cmbgioitinh.TabIndex = 17;
            // 
            // txtidgv
            // 
            this.txtidgv.BackColor = System.Drawing.Color.White;
            this.txtidgv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidgv.BorderRadius = 10;
            this.txtidgv.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtidgv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtidgv.DefaultText = "";
            this.txtidgv.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtidgv.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtidgv.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidgv.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtidgv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidgv.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtidgv.ForeColor = System.Drawing.Color.Black;
            this.txtidgv.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtidgv.IconLeftSize = new System.Drawing.Size(32, 32);
            this.txtidgv.Location = new System.Drawing.Point(169, 50);
            this.txtidgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtidgv.Name = "txtidgv";
            this.txtidgv.PasswordChar = '\0';
            this.txtidgv.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtidgv.PlaceholderText = "";
            this.txtidgv.SelectedText = "";
            this.txtidgv.Size = new System.Drawing.Size(240, 36);
            this.txtidgv.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(962, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 26);
            this.label10.TabIndex = 7;
            this.label10.Text = "Bộ môn:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(156, 26);
            this.label11.TabIndex = 0;
            this.label11.Text = "ID giảng viên:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(485, 60);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(153, 26);
            this.label12.TabIndex = 6;
            this.label12.Text = "Số điện thoại:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(7, 104);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 26);
            this.label13.TabIndex = 1;
            this.label13.Text = "Họ tên:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(960, 106);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 26);
            this.label14.TabIndex = 5;
            this.label14.Text = "Email:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(7, 147);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 26);
            this.label15.TabIndex = 2;
            this.label15.Text = "Giới tính:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(487, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 26);
            this.label16.TabIndex = 4;
            this.label16.Text = "Chức vụ:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(485, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 26);
            this.label17.TabIndex = 3;
            this.label17.Text = "Học vị:";
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
            this.tongso.Location = new System.Drawing.Point(874, 256);
            this.tongso.Name = "tongso";
            this.tongso.Size = new System.Drawing.Size(398, 36);
            this.tongso.TabIndex = 32;
            this.tongso.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txttimkiem.Location = new System.Drawing.Point(5, 256);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.PasswordChar = '\0';
            this.txttimkiem.PlaceholderText = "Tìm kiếm";
            this.txttimkiem.SelectedText = "";
            this.txttimkiem.Size = new System.Drawing.Size(724, 36);
            this.txttimkiem.TabIndex = 29;
            this.txttimkiem.TextChanged += new System.EventHandler(this.txttimkiem_TextChanged);
            // 
            // fGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 640);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.tongso);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.dgvgiangvien);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.fGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvgiangvien)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupgiochuan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnprint;
        private Guna.UI2.WinForms.Guna2GradientButton btnupdate;
        private Guna.UI2.WinForms.Guna2GradientButton btndelete;
        private Guna.UI2.WinForms.Guna2GradientButton btnadd;
        private Guna.UI2.WinForms.Guna2GradientButton btnclear;
        private Guna.UI2.WinForms.Guna2DataGridView dgvgiangvien;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2Button tongso;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nupgiochuan;
        private Guna.UI2.WinForms.Guna2ComboBox cmbbomon;
        private Guna.UI2.WinForms.Guna2TextBox txtemail;
        private Guna.UI2.WinForms.Guna2ComboBox cmbchucvu;
        private Guna.UI2.WinForms.Guna2TextBox txtsdt;
        private Guna.UI2.WinForms.Guna2ComboBox cmbhocvi;
        private Guna.UI2.WinForms.Guna2TextBox txthotengv;
        private Guna.UI2.WinForms.Guna2ComboBox cmbgioitinh;
        private Guna.UI2.WinForms.Guna2TextBox txtidgv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2TextBox txttimkiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn HocVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioChuan;
    }
}

