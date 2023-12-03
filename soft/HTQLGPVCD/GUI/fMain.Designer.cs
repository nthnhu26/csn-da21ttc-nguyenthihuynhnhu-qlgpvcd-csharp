namespace GUI
{
    partial class fMain
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
            tableLayoutPanel1 = new TableLayoutPanel();
            menuStrip1 = new MenuStrip();
            aDMINToolStripMenuItem = new ToolStripMenuItem();
            giảngViênToolStripMenuItem = new ToolStripMenuItem();
            hoạtĐộngToolStripMenuItem = new ToolStripMenuItem();
            hoạtĐộngĐăngKýToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            bÁOCÁOToolStripMenuItem = new ToolStripMenuItem();
            giảngViênHoànThànhToolStripMenuItem = new ToolStripMenuItem();
            giảngViênKhôngHoànThànhToolStripMenuItem = new ToolStripMenuItem();
            tổngSốGiờToolStripMenuItem = new ToolStripMenuItem();
            tHÔNGTINTÀIKHOẢNToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            cậpNhậtTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            tRỢGIÚPToolStripMenuItem = new ToolStripMenuItem();
            tHOÁTToolStripMenuItem = new ToolStripMenuItem();
            frameform = new Panel();
            tableLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.052198F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 91.48351F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 4.39560461F));
            tableLayoutPanel1.Controls.Add(menuStrip1, 1, 0);
            tableLayoutPanel1.Controls.Add(frameform, 1, 1);
            tableLayoutPanel1.Location = new Point(13, 13);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.98122072F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 92.0187759F));
            tableLayoutPanel1.Size = new Size(1456, 827);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aDMINToolStripMenuItem, bÁOCÁOToolStripMenuItem, tHÔNGTINTÀIKHOẢNToolStripMenuItem, tRỢGIÚPToolStripMenuItem, tHOÁTToolStripMenuItem });
            menuStrip1.Location = new Point(59, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 2, 0, 2);
            menuStrip1.Size = new Size(1332, 66);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // aDMINToolStripMenuItem
            // 
            aDMINToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giảngViênToolStripMenuItem, hoạtĐộngToolStripMenuItem, hoạtĐộngĐăngKýToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            aDMINToolStripMenuItem.Name = "aDMINToolStripMenuItem";
            aDMINToolStripMenuItem.Size = new Size(124, 62);
            aDMINToolStripMenuItem.Text = "ADMIN";
            // 
            // giảngViênToolStripMenuItem
            // 
            giảngViênToolStripMenuItem.Name = "giảngViênToolStripMenuItem";
            giảngViênToolStripMenuItem.Size = new Size(331, 36);
            giảngViênToolStripMenuItem.Text = "Giảng viên";
            giảngViênToolStripMenuItem.Click += giảngViênToolStripMenuItem_Click;
            // 
            // hoạtĐộngToolStripMenuItem
            // 
            hoạtĐộngToolStripMenuItem.Name = "hoạtĐộngToolStripMenuItem";
            hoạtĐộngToolStripMenuItem.Size = new Size(331, 36);
            hoạtĐộngToolStripMenuItem.Text = "Hoạt động";
            // 
            // hoạtĐộngĐăngKýToolStripMenuItem
            // 
            hoạtĐộngĐăngKýToolStripMenuItem.Name = "hoạtĐộngĐăngKýToolStripMenuItem";
            hoạtĐộngĐăngKýToolStripMenuItem.Size = new Size(331, 36);
            hoạtĐộngĐăngKýToolStripMenuItem.Text = "Hoạt động đăng ký";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(331, 36);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // bÁOCÁOToolStripMenuItem
            // 
            bÁOCÁOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { giảngViênHoànThànhToolStripMenuItem, giảngViênKhôngHoànThànhToolStripMenuItem, tổngSốGiờToolStripMenuItem });
            bÁOCÁOToolStripMenuItem.Name = "bÁOCÁOToolStripMenuItem";
            bÁOCÁOToolStripMenuItem.Size = new Size(159, 62);
            bÁOCÁOToolStripMenuItem.Text = "BÁO CÁO";
            // 
            // giảngViênHoànThànhToolStripMenuItem
            // 
            giảngViênHoànThànhToolStripMenuItem.Name = "giảngViênHoànThànhToolStripMenuItem";
            giảngViênHoànThànhToolStripMenuItem.Size = new Size(460, 36);
            giảngViênHoànThànhToolStripMenuItem.Text = "Giảng viên hoàn thành";
            // 
            // giảngViênKhôngHoànThànhToolStripMenuItem
            // 
            giảngViênKhôngHoànThànhToolStripMenuItem.Name = "giảngViênKhôngHoànThànhToolStripMenuItem";
            giảngViênKhôngHoànThànhToolStripMenuItem.Size = new Size(460, 36);
            giảngViênKhôngHoànThànhToolStripMenuItem.Text = "Giảng viên không hoàn thành";
            // 
            // tổngSốGiờToolStripMenuItem
            // 
            tổngSốGiờToolStripMenuItem.Name = "tổngSốGiờToolStripMenuItem";
            tổngSốGiờToolStripMenuItem.Size = new Size(460, 36);
            tổngSốGiờToolStripMenuItem.Text = "Tổng số giờ";
            // 
            // tHÔNGTINTÀIKHOẢNToolStripMenuItem
            // 
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, cậpNhậtTàiKhoảnToolStripMenuItem });
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.Name = "tHÔNGTINTÀIKHOẢNToolStripMenuItem";
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.Size = new Size(354, 62);
            tHÔNGTINTÀIKHOẢNToolStripMenuItem.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(334, 36);
            toolStripMenuItem1.Text = "Theo dõi hoạt động";
            // 
            // cậpNhậtTàiKhoảnToolStripMenuItem
            // 
            cậpNhậtTàiKhoảnToolStripMenuItem.Name = "cậpNhậtTàiKhoảnToolStripMenuItem";
            cậpNhậtTàiKhoảnToolStripMenuItem.Size = new Size(334, 36);
            cậpNhậtTàiKhoảnToolStripMenuItem.Text = "Cập nhật tài khoản";
            // 
            // tRỢGIÚPToolStripMenuItem
            // 
            tRỢGIÚPToolStripMenuItem.Name = "tRỢGIÚPToolStripMenuItem";
            tRỢGIÚPToolStripMenuItem.Size = new Size(165, 62);
            tRỢGIÚPToolStripMenuItem.Text = "TRỢ GIÚP";
            // 
            // tHOÁTToolStripMenuItem
            // 
            tHOÁTToolStripMenuItem.Name = "tHOÁTToolStripMenuItem";
            tHOÁTToolStripMenuItem.Size = new Size(128, 62);
            tHOÁTToolStripMenuItem.Text = "THOÁT";
            tHOÁTToolStripMenuItem.Click += tHOÁTToolStripMenuItem_Click;
            // 
            // frameform
            // 
            frameform.Dock = DockStyle.Fill;
            frameform.Location = new Point(62, 69);
            frameform.MaximumSize = new Size(1320, 720);
            frameform.MinimumSize = new Size(1320, 720);
            frameform.Name = "frameform";
            frameform.Size = new Size(1320, 720);
            frameform.TabIndex = 1;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1482, 853);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            MaximumSize = new Size(1500, 900);
            MinimumSize = new Size(1470, 900);
            Name = "fMain";
            Text = "fMain";
            tableLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aDMINToolStripMenuItem;
        private ToolStripMenuItem giảngViênToolStripMenuItem;
        private ToolStripMenuItem hoạtĐộngToolStripMenuItem;
        private ToolStripMenuItem hoạtĐộngĐăngKýToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem bÁOCÁOToolStripMenuItem;
        private ToolStripMenuItem giảngViênHoànThànhToolStripMenuItem;
        private ToolStripMenuItem giảngViênKhôngHoànThànhToolStripMenuItem;
        private ToolStripMenuItem tổngSốGiờToolStripMenuItem;
        private ToolStripMenuItem tHÔNGTINTÀIKHOẢNToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem tRỢGIÚPToolStripMenuItem;
        private ToolStripMenuItem tHOÁTToolStripMenuItem;
        private ToolStripMenuItem cậpNhậtTàiKhoảnToolStripMenuItem;
        private Panel frameform;
    }
}