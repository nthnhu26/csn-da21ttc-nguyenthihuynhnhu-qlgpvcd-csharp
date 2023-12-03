namespace GUI
{
    partial class fUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUser));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            txtgiohoanthanh = new TextBox();
            label1 = new Label();
            btnupdate = new Button();
            panel2 = new Panel();
            txtidminhchung = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            txthoatdong = new TextBox();
            label2 = new Label();
            btnupload = new Button();
            panel5 = new Panel();
            txttenminhchung = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            txtgiangvien = new TextBox();
            label3 = new Label();
            panel4 = new Panel();
            dtpcapnhat = new DateTimePicker();
            label7 = new Label();
            dgvhoatdongdangky = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            dgvminhchung = new DataGridView();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoatdongdangky).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvminhchung).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvhoatdongdangky, 0, 4);
            tableLayoutPanel1.Controls.Add(dgvminhchung, 0, 2);
            tableLayoutPanel1.Controls.Add(label5, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.1117325F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 79.88827F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 145F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 169F));
            tableLayoutPanel1.Size = new Size(1258, 629);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 34.82659F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65.17341F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 342F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 226F));
            tableLayoutPanel2.Controls.Add(panel1, 1, 0);
            tableLayoutPanel2.Controls.Add(panel2, 1, 1);
            tableLayoutPanel2.Controls.Add(panel3, 1, 2);
            tableLayoutPanel2.Controls.Add(panel5, 2, 1);
            tableLayoutPanel2.Controls.Add(panel6, 1, 3);
            tableLayoutPanel2.Controls.Add(panel4, 2, 2);
            tableLayoutPanel2.Controls.Add(btnupdate, 2, 0);
            tableLayoutPanel2.Controls.Add(btnupload, 2, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 64);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 52.727272F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 47.272728F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 52F));
            tableLayoutPanel2.Size = new Size(1252, 239);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtgiohoanthanh);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(241, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(439, 58);
            panel1.TabIndex = 0;
            // 
            // txtgiohoanthanh
            // 
            txtgiohoanthanh.Location = new Point(197, 5);
            txtgiohoanthanh.Name = "txtgiohoanthanh";
            txtgiohoanthanh.Size = new Size(170, 33);
            txtgiohoanthanh.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 12);
            label1.Name = "label1";
            label1.Size = new Size(188, 26);
            label1.TabIndex = 0;
            label1.Text = "Số giờ hoàn thành:";
            // 
            // btnupdate
            // 
            btnupdate.Dock = DockStyle.Left;
            btnupdate.Image = (Image)resources.GetObject("btnupdate.Image");
            btnupdate.Location = new Point(686, 3);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(140, 58);
            btnupdate.TabIndex = 1;
            btnupdate.Text = "Cập nhật";
            btnupdate.TextAlign = ContentAlignment.MiddleLeft;
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtidminhchung);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(241, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(439, 52);
            panel2.TabIndex = 2;
            // 
            // txtidminhchung
            // 
            txtidminhchung.Location = new Point(197, 9);
            txtidminhchung.Name = "txtidminhchung";
            txtidminhchung.Size = new Size(170, 33);
            txtidminhchung.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 17);
            label6.Name = "label6";
            label6.Size = new Size(159, 26);
            label6.TabIndex = 0;
            label6.Text = "ID minh chứng:";
            // 
            // panel3
            // 
            panel3.Controls.Add(txthoatdong);
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(241, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(439, 58);
            panel3.TabIndex = 3;
            // 
            // txthoatdong
            // 
            txthoatdong.Location = new Point(197, 11);
            txthoatdong.Name = "txthoatdong";
            txthoatdong.Size = new Size(170, 33);
            txthoatdong.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(144, 26);
            label2.TabIndex = 0;
            label2.Text = "ID giảng viên:";
            // 
            // btnupload
            // 
            btnupload.Dock = DockStyle.Left;
            btnupload.Image = (Image)resources.GetObject("btnupload.Image");
            btnupload.Location = new Point(686, 189);
            btnupload.Name = "btnupload";
            btnupload.Size = new Size(140, 47);
            btnupload.TabIndex = 5;
            btnupload.Text = "Tải lên";
            btnupload.TextAlign = ContentAlignment.MiddleLeft;
            btnupload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupload.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(txttenminhchung);
            panel5.Controls.Add(label4);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(686, 67);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 52);
            panel5.TabIndex = 6;
            // 
            // txttenminhchung
            // 
            txttenminhchung.Location = new Point(180, 14);
            txttenminhchung.Name = "txttenminhchung";
            txttenminhchung.Size = new Size(142, 33);
            txttenminhchung.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(171, 26);
            label4.TabIndex = 0;
            label4.Text = "Tên minh chứng:";
            // 
            // panel6
            // 
            panel6.Controls.Add(txtgiangvien);
            panel6.Controls.Add(label2);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(241, 189);
            panel6.Name = "panel6";
            panel6.Size = new Size(439, 47);
            panel6.TabIndex = 3;
            // 
            // txtgiangvien
            // 
            txtgiangvien.Location = new Point(197, 11);
            txtgiangvien.Name = "txtgiangvien";
            txtgiangvien.Size = new Size(170, 33);
            txtgiangvien.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 18);
            label3.Name = "label3";
            label3.Size = new Size(141, 26);
            label3.TabIndex = 0;
            label3.Text = "ID hoạt động:";
            // 
            // panel4
            // 
            panel4.Controls.Add(dtpcapnhat);
            panel4.Controls.Add(label7);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(686, 125);
            panel4.Name = "panel4";
            panel4.Size = new Size(336, 58);
            panel4.TabIndex = 4;
            // 
            // dtpcapnhat
            // 
            dtpcapnhat.Format = DateTimePickerFormat.Custom;
            dtpcapnhat.Location = new Point(180, 15);
            dtpcapnhat.Name = "dtpcapnhat";
            dtpcapnhat.Size = new Size(142, 33);
            dtpcapnhat.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 18);
            label7.Name = "label7";
            label7.Size = new Size(150, 26);
            label7.TabIndex = 0;
            label7.Text = "Ngày cập nhật:";
            // 
            // dgvhoatdongdangky
            // 
            dgvhoatdongdangky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoatdongdangky.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvhoatdongdangky.Dock = DockStyle.Fill;
            dgvhoatdongdangky.Location = new Point(3, 462);
            dgvhoatdongdangky.Name = "dgvhoatdongdangky";
            dgvhoatdongdangky.RowHeadersWidth = 51;
            dgvhoatdongdangky.Size = new Size(1252, 164);
            dgvhoatdongdangky.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID hoạt động đăng ký";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "ID hoạt động";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID giảng viên";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "ID trạng thái";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Số giờ đã hoàn thành";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Số giờ còn lại";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Ngày đăng ký";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.Width = 125;
            // 
            // dgvminhchung
            // 
            dgvminhchung.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvminhchung.Columns.AddRange(new DataGridViewColumn[] { Column8, Column9, Column10, Column11, Column12 });
            dgvminhchung.Dock = DockStyle.Fill;
            dgvminhchung.Location = new Point(3, 309);
            dgvminhchung.Name = "dgvminhchung";
            dgvminhchung.RowHeadersWidth = 51;
            dgvminhchung.Size = new Size(1252, 139);
            dgvminhchung.TabIndex = 1;
            // 
            // Column8
            // 
            Column8.HeaderText = "ID minh chứng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.HeaderText = "ID hoạt động";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.HeaderText = "ID giảng viên";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.Width = 125;
            // 
            // Column11
            // 
            Column11.HeaderText = "Tên minh chứng";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.Width = 125;
            // 
            // Column12
            // 
            Column12.HeaderText = "Ngày cập nhật";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.Width = 125;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Times New Roman", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(1252, 61);
            label5.TabIndex = 3;
            label5.Text = "CẬP NHẬT HOẠT ĐỘNG";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // fUser
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(1300, 700);
            MinimumSize = new Size(1300, 700);
            Name = "fUser";
            Text = "fUser";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoatdongdangky).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvminhchung).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private TextBox txtgiohoanthanh;
        private Label label1;
        private Button btnupdate;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnupload;
        private DataGridView dgvminhchung;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridView dgvhoatdongdangky;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private TextBox txtidminhchung;
        private Label label2;
        private TextBox txthoatdong;
        private Label label3;
        private DateTimePicker dtpcapnhat;
        private Label label4;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private Label label6;
        private Panel panel5;
        private TextBox txttenminhchung;
        private Panel panel6;
        private TextBox txtgiangvien;
        private Label label7;
    }
}