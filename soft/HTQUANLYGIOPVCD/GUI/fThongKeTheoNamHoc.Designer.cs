namespace GUI
{
    partial class fThongKeTheoNamHoc
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.sp_ThongKeTheoNamHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeTheoNamHoc = new GUI.ThongKeTheoNamHoc();
            this.rptthongkenamhoc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpketthuc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpbatdau = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnthongke = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbloc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sp_ThongKeTheoNamHocTableAdapter = new GUI.ThongKeTheoNamHocTableAdapters.sp_ThongKeTheoNamHocTableAdapter();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ThongKeTheoNamHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeTheoNamHoc)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // sp_ThongKeTheoNamHocBindingSource
            // 
            this.sp_ThongKeTheoNamHocBindingSource.DataMember = "sp_ThongKeTheoNamHoc";
            this.sp_ThongKeTheoNamHocBindingSource.DataSource = this.ThongKeTheoNamHoc;
            // 
            // ThongKeTheoNamHoc
            // 
            this.ThongKeTheoNamHoc.DataSetName = "ThongKeTheoNamHoc";
            this.ThongKeTheoNamHoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptthongkenamhoc
            // 
            reportDataSource1.Name = "ThongKeTheoNamHoc";
            reportDataSource1.Value = this.sp_ThongKeTheoNamHocBindingSource;
            this.rptthongkenamhoc.LocalReport.DataSources.Add(reportDataSource1);
            this.rptthongkenamhoc.LocalReport.ReportEmbeddedResource = "GUI.ThongKeTheoNamHoc.rdlc";
            this.rptthongkenamhoc.Location = new System.Drawing.Point(423, 45);
            this.rptthongkenamhoc.Name = "rptthongkenamhoc";
            this.rptthongkenamhoc.Size = new System.Drawing.Size(925, 583);
            this.rptthongkenamhoc.TabIndex = 0;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2GroupBox3.BorderRadius = 10;
            this.guna2GroupBox3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2GroupBox3.Controls.Add(this.label2);
            this.guna2GroupBox3.Controls.Add(this.label1);
            this.guna2GroupBox3.Controls.Add(this.dtpketthuc);
            this.guna2GroupBox3.Controls.Add(this.dtpbatdau);
            this.guna2GroupBox3.Controls.Add(this.btnthongke);
            this.guna2GroupBox3.Controls.Add(this.cmbloc);
            this.guna2GroupBox3.Controls.Add(this.label16);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.guna2GroupBox3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(12, 45);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(405, 262);
            this.guna2GroupBox3.TabIndex = 34;
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 26);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ngày kết thúc:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 28;
            this.label1.Text = "Lọc giờ vượt";
            // 
            // dtpketthuc
            // 
            this.dtpketthuc.BackColor = System.Drawing.Color.White;
            this.dtpketthuc.BorderRadius = 10;
            this.dtpketthuc.Checked = true;
            this.dtpketthuc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.dtpketthuc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpketthuc.ForeColor = System.Drawing.Color.Black;
            this.dtpketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpketthuc.Location = new System.Drawing.Point(171, 102);
            this.dtpketthuc.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpketthuc.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpketthuc.Name = "dtpketthuc";
            this.dtpketthuc.Size = new System.Drawing.Size(227, 36);
            this.dtpketthuc.TabIndex = 27;
            this.dtpketthuc.Value = new System.DateTime(2024, 5, 31, 0, 0, 0, 0);
            // 
            // dtpbatdau
            // 
            this.dtpbatdau.BackColor = System.Drawing.Color.White;
            this.dtpbatdau.BorderRadius = 10;
            this.dtpbatdau.Checked = true;
            this.dtpbatdau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.dtpbatdau.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.dtpbatdau.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpbatdau.ForeColor = System.Drawing.Color.Black;
            this.dtpbatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpbatdau.Location = new System.Drawing.Point(171, 51);
            this.dtpbatdau.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpbatdau.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpbatdau.Name = "dtpbatdau";
            this.dtpbatdau.Size = new System.Drawing.Size(227, 36);
            this.dtpbatdau.TabIndex = 26;
            this.dtpbatdau.Value = new System.DateTime(2023, 9, 1, 0, 0, 0, 0);
            // 
            // btnthongke
            // 
            this.btnthongke.BackColor = System.Drawing.Color.White;
            this.btnthongke.BorderRadius = 10;
            this.btnthongke.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthongke.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthongke.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthongke.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthongke.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthongke.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(179)))), ((int)(((byte)(227)))));
            this.btnthongke.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(200)))));
            this.btnthongke.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.btnthongke.ForeColor = System.Drawing.Color.Black;
            this.btnthongke.Image = global::GUI.Properties.Resources.capnhat;
            this.btnthongke.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnthongke.ImageSize = new System.Drawing.Size(32, 32);
            this.btnthongke.Location = new System.Drawing.Point(254, 186);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(144, 45);
            this.btnthongke.TabIndex = 25;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnthongke.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // cmbloc
            // 
            this.cmbloc.BackColor = System.Drawing.Color.White;
            this.cmbloc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbloc.BorderRadius = 10;
            this.cmbloc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbloc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbloc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbloc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbloc.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbloc.ForeColor = System.Drawing.Color.Black;
            this.cmbloc.ItemHeight = 30;
            this.cmbloc.Items.AddRange(new object[] {
            "0",
            "1",
            "-1"});
            this.cmbloc.Location = new System.Drawing.Point(176, 144);
            this.cmbloc.Name = "cmbloc";
            this.cmbloc.Size = new System.Drawing.Size(222, 36);
            this.cmbloc.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(3, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(156, 26);
            this.label16.TabIndex = 4;
            this.label16.Text = "Ngày bắt đầu:";
            // 
            // sp_ThongKeTheoNamHocTableAdapter
            // 
            this.sp_ThongKeTheoNamHocTableAdapter.ClearBeforeFill = true;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(659, 12);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(448, 27);
            this.guna2HtmlLabel1.TabIndex = 35;
            this.guna2HtmlLabel1.Text = "THỐNG KÊ GIẢNG VIÊN THEO NĂM HỌC";
            // 
            // fThongKeTheoNamHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 640);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.rptthongkenamhoc);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fThongKeTheoNamHoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThongKeTheoNamHoc";
            this.Load += new System.EventHandler(this.fThongKeTheoNamHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ThongKeTheoNamHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeTheoNamHoc)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptthongkenamhoc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2ComboBox cmbloc;
        private System.Windows.Forms.Label label16;
        private Guna.UI2.WinForms.Guna2GradientButton btnthongke;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpbatdau;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpketthuc;
        private System.Windows.Forms.BindingSource sp_ThongKeTheoNamHocBindingSource;
        private ThongKeTheoNamHoc ThongKeTheoNamHoc;
        private ThongKeTheoNamHocTableAdapters.sp_ThongKeTheoNamHocTableAdapter sp_ThongKeTheoNamHocTableAdapter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}