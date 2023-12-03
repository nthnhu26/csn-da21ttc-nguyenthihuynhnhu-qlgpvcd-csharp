namespace GUI
{
    partial class fHoatDongDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fHoatDongDangKy));
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnclear = new Button();
            btnadd = new Button();
            btndelete = new Button();
            btnupdate = new Button();
            btnsearchid = new Button();
            btnsearchten = new Button();
            btnprint = new Button();
            label1 = new Label();
            dgvhoatdongdangky = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel1 = new Panel();
            label2 = new Label();
            txthddk = new TextBox();
            panel2 = new Panel();
            label3 = new Label();
            txtgiohoanthanh = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            txtgioconlai = new TextBox();
            panel4 = new Panel();
            txtidhd = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            txtidgv = new TextBox();
            panel6 = new Panel();
            label7 = new Label();
            dtpdangky = new DateTimePicker();
            panel7 = new Panel();
            label8 = new Label();
            txtidtt = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvhoatdongdangky).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvhoatdongdangky, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.72928F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.27072F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 83F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 349F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
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
            flowLayoutPanel2.Controls.Add(btnprint);
            flowLayoutPanel2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flowLayoutPanel2.Location = new Point(3, 199);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(6);
            flowLayoutPanel2.Size = new Size(1252, 67);
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
            // 
            // btnadd
            // 
            btnadd.Image = (Image)resources.GetObject("btnadd.Image");
            btnadd.ImageAlign = ContentAlignment.MiddleLeft;
            btnadd.Location = new Point(181, 9);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(166, 50);
            btnadd.TabIndex = 1;
            btnadd.Text = "Thêm";
            btnadd.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnadd.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            btndelete.Image = (Image)resources.GetObject("btndelete.Image");
            btndelete.ImageAlign = ContentAlignment.MiddleLeft;
            btndelete.Location = new Point(353, 9);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(166, 50);
            btndelete.TabIndex = 2;
            btndelete.Text = "Xóa";
            btndelete.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndelete.UseVisualStyleBackColor = true;
            // 
            // btnupdate
            // 
            btnupdate.Image = (Image)resources.GetObject("btnupdate.Image");
            btnupdate.Location = new Point(525, 9);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(166, 50);
            btnupdate.TabIndex = 3;
            btnupdate.Text = "Cập nhật";
            btnupdate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnupdate.UseVisualStyleBackColor = true;
            // 
            // btnsearchid
            // 
            btnsearchid.Image = (Image)resources.GetObject("btnsearchid.Image");
            btnsearchid.Location = new Point(697, 9);
            btnsearchid.Name = "btnsearchid";
            btnsearchid.Size = new Size(165, 50);
            btnsearchid.TabIndex = 5;
            btnsearchid.Text = "Tìm ID";
            btnsearchid.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsearchid.UseVisualStyleBackColor = true;
            // 
            // btnsearchten
            // 
            btnsearchten.Image = (Image)resources.GetObject("btnsearchten.Image");
            btnsearchten.Location = new Point(868, 9);
            btnsearchten.Name = "btnsearchten";
            btnsearchten.Size = new Size(165, 50);
            btnsearchten.TabIndex = 6;
            btnsearchten.Text = "Tìm tên";
            btnsearchten.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsearchten.UseVisualStyleBackColor = true;
            // 
            // btnprint
            // 
            btnprint.Image = (Image)resources.GetObject("btnprint.Image");
            btnprint.Location = new Point(1039, 9);
            btnprint.Name = "btnprint";
            btnprint.Size = new Size(204, 50);
            btnprint.TabIndex = 4;
            btnprint.Text = "In danh sách";
            btnprint.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnprint.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1252, 56);
            label1.TabIndex = 0;
            label1.Text = "HOẠT ĐỘNG ĐƯỢC ĐĂNG KÝ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvhoatdongdangky
            // 
            dgvhoatdongdangky.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvhoatdongdangky.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7 });
            dgvhoatdongdangky.Dock = DockStyle.Fill;
            dgvhoatdongdangky.Location = new Point(3, 282);
            dgvhoatdongdangky.Name = "dgvhoatdongdangky";
            dgvhoatdongdangky.RowHeadersWidth = 51;
            dgvhoatdongdangky.Size = new Size(1252, 344);
            dgvhoatdongdangky.TabIndex = 1;
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
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.71246F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.6805115F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.28115F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.3258781F));
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 1, 1);
            tableLayoutPanel2.Controls.Add(panel4, 1, 0);
            tableLayoutPanel2.Controls.Add(panel5, 2, 0);
            tableLayoutPanel2.Controls.Add(panel6, 2, 1);
            tableLayoutPanel2.Controls.Add(panel7, 3, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 59);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1252, 134);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txthddk);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(366, 61);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(222, 26);
            label2.TabIndex = 1;
            label2.Text = "ID hoạt động đăng ký:";
            // 
            // txthddk
            // 
            txthddk.Location = new Point(225, 13);
            txthddk.Name = "txthddk";
            txthddk.Size = new Size(138, 33);
            txthddk.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtgiohoanthanh);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 61);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 21);
            label3.Name = "label3";
            label3.Size = new Size(188, 26);
            label3.TabIndex = 1;
            label3.Text = "Số giờ hoàn thành:";
            // 
            // txtgiohoanthanh
            // 
            txtgiohoanthanh.Location = new Point(225, 16);
            txtgiohoanthanh.Name = "txtgiohoanthanh";
            txtgiohoanthanh.Size = new Size(138, 33);
            txtgiohoanthanh.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtgioconlai);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(375, 70);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 61);
            panel3.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 21);
            label5.Name = "label5";
            label5.Size = new Size(146, 26);
            label5.TabIndex = 1;
            label5.Text = "Số giờ còn lại:";
            // 
            // txtgioconlai
            // 
            txtgioconlai.Location = new Point(167, 16);
            txtgioconlai.Name = "txtgioconlai";
            txtgioconlai.Size = new Size(133, 33);
            txtgioconlai.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtidhd);
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(375, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 61);
            panel4.TabIndex = 3;
            // 
            // txtidhd
            // 
            txtidhd.Location = new Point(167, 13);
            txtidhd.Name = "txtidhd";
            txtidhd.Size = new Size(133, 33);
            txtidhd.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 20);
            label6.Name = "label6";
            label6.Size = new Size(141, 26);
            label6.TabIndex = 1;
            label6.Text = "ID hoạt động:";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(txtidgv);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(684, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(298, 61);
            panel5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 17);
            label4.Name = "label4";
            label4.Size = new Size(144, 26);
            label4.TabIndex = 1;
            label4.Text = "ID giảng viên:";
            // 
            // txtidgv
            // 
            txtidgv.Location = new Point(156, 14);
            txtidgv.Name = "txtidgv";
            txtidgv.Size = new Size(139, 33);
            txtidgv.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(label7);
            panel6.Controls.Add(dtpdangky);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(684, 70);
            panel6.Name = "panel6";
            panel6.Size = new Size(298, 61);
            panel6.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 19);
            label7.Name = "label7";
            label7.Size = new Size(147, 26);
            label7.TabIndex = 1;
            label7.Text = "Ngày đăng ký:";
            // 
            // dtpdangky
            // 
            dtpdangky.Format = DateTimePickerFormat.Custom;
            dtpdangky.Location = new Point(156, 15);
            dtpdangky.MaxDate = new DateTime(2024, 12, 31, 0, 0, 0, 0);
            dtpdangky.Name = "dtpdangky";
            dtpdangky.Size = new Size(139, 33);
            dtpdangky.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(label8);
            panel7.Controls.Add(txtidtt);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(988, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(261, 61);
            panel7.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 16);
            label8.Name = "label8";
            label8.Size = new Size(135, 26);
            label8.TabIndex = 1;
            label8.Text = "ID trạng thái:";
            // 
            // txtidtt
            // 
            txtidtt.Location = new Point(144, 14);
            txtidtt.Name = "txtidtt";
            txtidtt.Size = new Size(111, 33);
            txtidtt.TabIndex = 0;
            // 
            // fHoatDongDangKy
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1282, 653);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(1300, 700);
            MinimumSize = new Size(1300, 700);
            Name = "fHoatDongDangKy";
            Text = "fHoatDongDangKy";
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvhoatdongdangky).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
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
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView dgvhoatdongdangky;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Label label2;
        private TextBox txthddk;
        private Label label3;
        private TextBox txtgiohoanthanh;
        private Label label5;
        private TextBox txtgioconlai;
        private Label label4;
        private TextBox txtidhd;
        private Label label6;
        private TextBox txtidgv;
        private Label label7;
        private DateTimePicker dtpdangky;
        private TextBox txtidtt;
        private Label label8;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnclear;
        private Button btnadd;
        private Button btndelete;
        private Button btnupdate;
        private Button btnsearchid;
        private Button btnsearchten;
        private Button btnprint;
    }
}