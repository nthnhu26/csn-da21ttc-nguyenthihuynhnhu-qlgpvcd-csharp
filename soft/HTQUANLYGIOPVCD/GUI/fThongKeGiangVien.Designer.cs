namespace GUI
{
    partial class fThongKeGiangVien
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
            this.sp_ThongKeGiangVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThongKeGiangVien = new GUI.ThongKeGiangVien();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rptthongkegv = new Microsoft.Reporting.WinForms.ReportViewer();
            this.sp_ThongKeGiangVienTableAdapter = new GUI.ThongKeGiangVienTableAdapters.sp_ThongKeGiangVienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.sp_ThongKeGiangVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeGiangVien)).BeginInit();
            this.SuspendLayout();
            // 
            // sp_ThongKeGiangVienBindingSource
            // 
            this.sp_ThongKeGiangVienBindingSource.DataMember = "sp_ThongKeGiangVien";
            this.sp_ThongKeGiangVienBindingSource.DataSource = this.ThongKeGiangVien;
            // 
            // ThongKeGiangVien
            // 
            this.ThongKeGiangVien.DataSetName = "ThongKeGiangVien";
            this.ThongKeGiangVien.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(587, 5);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(265, 27);
            this.guna2HtmlLabel1.TabIndex = 2;
            this.guna2HtmlLabel1.Text = "THỐNG KÊ GIẢNG VIÊN";
            // 
            // rptthongkegv
            // 
            reportDataSource1.Name = "ThongKeGiangVien";
            reportDataSource1.Value = this.sp_ThongKeGiangVienBindingSource;
            this.rptthongkegv.LocalReport.DataSources.Add(reportDataSource1);
            this.rptthongkegv.LocalReport.ReportEmbeddedResource = "GUI.ThongKeGiangVien.rdlc";
            this.rptthongkegv.Location = new System.Drawing.Point(81, 42);
            this.rptthongkegv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rptthongkegv.Name = "rptthongkegv";
            this.rptthongkegv.Size = new System.Drawing.Size(1200, 584);
            this.rptthongkegv.TabIndex = 3;
            this.rptthongkegv.SizeChanged += new System.EventHandler(this.rptthongkegv_SizeChanged);
            // 
            // sp_ThongKeGiangVienTableAdapter
            // 
            this.sp_ThongKeGiangVienTableAdapter.ClearBeforeFill = true;
            // 
            // fThongKeGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 640);
            this.Controls.Add(this.rptthongkegv);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fThongKeGiangVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fThongKeGiangVien";
            this.Load += new System.EventHandler(this.fThongKeGiangVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sp_ThongKeGiangVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThongKeGiangVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Microsoft.Reporting.WinForms.ReportViewer rptthongkegv;
        private System.Windows.Forms.BindingSource sp_ThongKeGiangVienBindingSource;
        private ThongKeGiangVien ThongKeGiangVien;
        private ThongKeGiangVienTableAdapters.sp_ThongKeGiangVienTableAdapter sp_ThongKeGiangVienTableAdapter;
    }
}