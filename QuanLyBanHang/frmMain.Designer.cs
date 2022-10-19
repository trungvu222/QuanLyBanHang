
namespace QuanLyBanHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuChatLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHoaDonBan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFindHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.btnOpenURL = new System.Windows.Forms.Button();
            this.btnOpenURL1 = new System.Windows.Forms.Button();
            this.btnOpenURL2 = new System.Windows.Forms.Button();
            this.btnOpenURL4 = new System.Windows.Forms.Button();
            this.btnOpenURL3 = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThoat});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.mnuFile.Size = new System.Drawing.Size(55, 20);
            this.mnuFile.Text = "&Tập tin";
            // 
            // mnuThoat
            // 
            this.mnuThoat.Image = global::QuanLyBanHang.Properties.Resources.SecurityAndMaintenance_Error;
            this.mnuThoat.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.mnuThoat.Name = "mnuThoat";
            this.mnuThoat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuThoat.Size = new System.Drawing.Size(146, 22);
            this.mnuThoat.Text = "&Thoát";
            this.mnuThoat.Click += new System.EventHandler(this.mnuThoat_Click);
            // 
            // mnuDanhMuc
            // 
            this.mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuChatLieu,
            this.mnuNhanVien,
            this.mnuKhachHang,
            this.mnuHangHoa});
            this.mnuDanhMuc.Name = "mnuDanhMuc";
            this.mnuDanhMuc.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.mnuDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.mnuDanhMuc.Text = "&Danh mục";
            // 
            // mnuChatLieu
            // 
            this.mnuChatLieu.Image = global::QuanLyBanHang.Properties.Resources.FeatureToastBulldogImg;
            this.mnuChatLieu.Name = "mnuChatLieu";
            this.mnuChatLieu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mnuChatLieu.Size = new System.Drawing.Size(180, 22);
            this.mnuChatLieu.Text = "&Chất liệu";
            this.mnuChatLieu.Click += new System.EventHandler(this.mnuChatLieu_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = global::QuanLyBanHang.Properties.Resources.DefaultAccountTile;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuNhanVien.Size = new System.Drawing.Size(180, 22);
            this.mnuNhanVien.Text = "&Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = global::QuanLyBanHang.Properties.Resources.DefaultAccountTile1;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnuKhachHang.Text = "&Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Image = global::QuanLyBanHang.Properties.Resources.store_contrast_black;
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuHangHoa.Size = new System.Drawing.Size(180, 22);
            this.mnuHangHoa.Text = "&Hàng hóa";
            this.mnuHangHoa.Click += new System.EventHandler(this.mnuHangHoa_Click);
            // 
            // mnuHoaDon
            // 
            this.mnuHoaDon.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHoaDonBan});
            this.mnuHoaDon.Name = "mnuHoaDon";
            this.mnuHoaDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.mnuHoaDon.Size = new System.Drawing.Size(65, 20);
            this.mnuHoaDon.Text = "&Hóa đơn";
            // 
            // mnuHoaDonBan
            // 
            this.mnuHoaDonBan.Image = global::QuanLyBanHang.Properties.Resources.Backpack;
            this.mnuHoaDonBan.Name = "mnuHoaDonBan";
            this.mnuHoaDonBan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuHoaDonBan.Size = new System.Drawing.Size(183, 22);
            this.mnuHoaDonBan.Text = "&Hóa đơn bán";
            this.mnuHoaDonBan.Click += new System.EventHandler(this.mnuHoaDonBan_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFindHoaDon});
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.mnuTimKiem.Size = new System.Drawing.Size(68, 20);
            this.mnuTimKiem.Text = "&Tìm kiếm";
            // 
            // mnuFindHoaDon
            // 
            this.mnuFindHoaDon.Image = global::QuanLyBanHang.Properties.Resources.store_contrast_black;
            this.mnuFindHoaDon.Name = "mnuFindHoaDon";
            this.mnuFindHoaDon.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.mnuFindHoaDon.Size = new System.Drawing.Size(180, 22);
            this.mnuFindHoaDon.Text = "&Hóa đơn";
            this.mnuFindHoaDon.Click += new System.EventHandler(this.mnuFindHoaDon_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoanhThu});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "&Báo cáo";
            // 
            // mnuDoanhThu
            // 
            this.mnuDoanhThu.Image = global::QuanLyBanHang.Properties.Resources.FeatureToastDlpImg;
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuDoanhThu.Size = new System.Drawing.Size(180, 22);
            this.mnuDoanhThu.Text = "&Doanh thu";
            this.mnuDoanhThu.Click += new System.EventHandler(this.mnuDoanhThu_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(299, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cửa hàng quà lưu niệm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1077, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(349, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "CHỦ SHOP";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Red;
            this.lbUsername.Location = new System.Drawing.Point(533, 129);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(41, 31);
            this.lbUsername.TabIndex = 8;
            this.lbUsername.Text = "...";
            // 
            // btnOpenURL
            // 
            this.btnOpenURL.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenURL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenURL.BackgroundImage")));
            this.btnOpenURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenURL.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenURL.ImageKey = "(none)";
            this.btnOpenURL.Location = new System.Drawing.Point(777, 510);
            this.btnOpenURL.Name = "btnOpenURL";
            this.btnOpenURL.Size = new System.Drawing.Size(71, 62);
            this.btnOpenURL.TabIndex = 10;
            this.btnOpenURL.Text = "FaceBook";
            this.btnOpenURL.UseVisualStyleBackColor = false;
            this.btnOpenURL.Click += new System.EventHandler(this.btnOpenURL_Click);
            // 
            // btnOpenURL1
            // 
            this.btnOpenURL1.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenURL1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenURL1.BackgroundImage")));
            this.btnOpenURL1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenURL1.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenURL1.ImageKey = "(none)";
            this.btnOpenURL1.Location = new System.Drawing.Point(854, 510);
            this.btnOpenURL1.Name = "btnOpenURL1";
            this.btnOpenURL1.Size = new System.Drawing.Size(73, 62);
            this.btnOpenURL1.TabIndex = 11;
            this.btnOpenURL1.Text = "Zalo";
            this.btnOpenURL1.UseVisualStyleBackColor = false;
            this.btnOpenURL1.Click += new System.EventHandler(this.btnOpenURL1_Click);
            // 
            // btnOpenURL2
            // 
            this.btnOpenURL2.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenURL2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenURL2.BackgroundImage")));
            this.btnOpenURL2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenURL2.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenURL2.Location = new System.Drawing.Point(1003, 510);
            this.btnOpenURL2.Name = "btnOpenURL2";
            this.btnOpenURL2.Size = new System.Drawing.Size(62, 62);
            this.btnOpenURL2.TabIndex = 12;
            this.btnOpenURL2.Text = "Skype";
            this.btnOpenURL2.UseVisualStyleBackColor = false;
            this.btnOpenURL2.Click += new System.EventHandler(this.btnOpenURL2_Click);
            // 
            // btnOpenURL4
            // 
            this.btnOpenURL4.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenURL4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenURL4.BackgroundImage")));
            this.btnOpenURL4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenURL4.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenURL4.ImageKey = "(none)";
            this.btnOpenURL4.Location = new System.Drawing.Point(696, 510);
            this.btnOpenURL4.Name = "btnOpenURL4";
            this.btnOpenURL4.Size = new System.Drawing.Size(75, 62);
            this.btnOpenURL4.TabIndex = 14;
            this.btnOpenURL4.Text = "github";
            this.btnOpenURL4.UseVisualStyleBackColor = false;
            this.btnOpenURL4.Click += new System.EventHandler(this.btnOpenURL4_Click);
            // 
            // btnOpenURL3
            // 
            this.btnOpenURL3.BackColor = System.Drawing.Color.Transparent;
            this.btnOpenURL3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenURL3.BackgroundImage")));
            this.btnOpenURL3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenURL3.ForeColor = System.Drawing.Color.Transparent;
            this.btnOpenURL3.Location = new System.Drawing.Point(933, 510);
            this.btnOpenURL3.Name = "btnOpenURL3";
            this.btnOpenURL3.Size = new System.Drawing.Size(64, 62);
            this.btnOpenURL3.TabIndex = 15;
            this.btnOpenURL3.Text = "Instagram";
            this.btnOpenURL3.UseVisualStyleBackColor = false;
            this.btnOpenURL3.Click += new System.EventHandler(this.btnOpenURL3_Click);
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.Color.Transparent;
            this.picAnh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picAnh.BackgroundImage")));
            this.picAnh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAnh.Location = new System.Drawing.Point(0, 27);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(156, 142);
            this.picAnh.TabIndex = 16;
            this.picAnh.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 597);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnOpenURL3);
            this.Controls.Add(this.btnOpenURL4);
            this.Controls.Add(this.btnOpenURL2);
            this.Controls.Add(this.btnOpenURL1);
            this.Controls.Add(this.btnOpenURL);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý bán hàng lưu niệm";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuThoat;
        private System.Windows.Forms.ToolStripMenuItem mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuChatLieu;
        private System.Windows.Forms.ToolStripMenuItem mnuNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnuHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripMenuItem mnuFindHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDon;
        private System.Windows.Forms.ToolStripMenuItem mnuHoaDonBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.Button btnOpenURL;
        private System.Windows.Forms.Button btnOpenURL1;
        private System.Windows.Forms.Button btnOpenURL2;
        private System.Windows.Forms.Button btnOpenURL4;
        private System.Windows.Forms.Button btnOpenURL3;
        private System.Windows.Forms.PictureBox picAnh;
    }
}

