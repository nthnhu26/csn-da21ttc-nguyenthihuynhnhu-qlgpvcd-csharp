namespace GUI
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            checkBox1 = new CheckBox();
            btnlogin = new Button();
            btnexit = new Button();
            panel3 = new Panel();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            txtpass = new TextBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            txtuser = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 228);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(246, 28);
            label1.Name = "label1";
            label1.Size = new Size(524, 158);
            label1.TabIndex = 1;
            label1.Text = "HỆ THỐNG QUẢN LÝ GIỜ PHỤC VỤ CỘNG ĐỒNG";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 621F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 72F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 275);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.0765F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.923497F));
            tableLayoutPanel1.Size = new Size(758, 366);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(btnlogin);
            panel1.Controls.Add(btnexit);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(68, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(615, 331);
            panel1.TabIndex = 0;
            // 
            // checkBox1
            // 
            checkBox1.Location = new Point(246, 198);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(163, 33);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Lưu mật khẩu";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnlogin
            // 
            btnlogin.Image = (Image)resources.GetObject("btnlogin.Image");
            btnlogin.Location = new Point(445, 257);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(155, 50);
            btnlogin.TabIndex = 3;
            btnlogin.Text = "Đăng nhập";
            btnlogin.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlogin.UseVisualStyleBackColor = true;
            btnlogin.Click += btnlogin_Click;
            // 
            // btnexit
            // 
            btnexit.Image = (Image)resources.GetObject("btnexit.Image");
            btnexit.Location = new Point(243, 257);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(155, 50);
            btnexit.TabIndex = 2;
            btnexit.Text = "Thoát";
            btnexit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(txtpass);
            panel3.Location = new Point(3, 98);
            panel3.Name = "panel3";
            panel3.Size = new Size(609, 80);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 31);
            label3.Name = "label3";
            label3.Size = new Size(175, 25);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(240, 23);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(360, 33);
            txtpass.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtuser);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(609, 80);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 25);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 2;
            label2.Text = "Tên đăng nhập:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(32, 32);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(240, 17);
            txtuser.Name = "txtuser";
            txtuser.Size = new Size(360, 33);
            txtuser.TabIndex = 0;
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.Control;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(782, 653);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximumSize = new Size(800, 700);
            MinimumSize = new Size(800, 700);
            Name = "fLogin";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button btnlogin;
        private Button btnexit;
        private Panel panel3;
        private TextBox txtpass;
        private Panel panel2;
        private PictureBox pictureBox2;
        private TextBox txtuser;
        private Label label3;
        private PictureBox pictureBox3;
        private Label label2;
        private CheckBox checkBox1;
    }
}