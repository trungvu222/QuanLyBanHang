
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
            this.mnuBaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoanhThu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongTinTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTaiKhoanNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTroGiup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGitHub = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFaceBook = new System.Windows.Forms.ToolStripMenuItem();
            this.muSkype = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLienHe = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mnuThongKeHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuDanhMuc,
            this.mnuHoaDon,
            this.mnuTimKiem,
            this.mnuBaoCao,
            this.mnuTaiKhoan,
            this.mnuAdmin,
            this.mnuTroGiup,
            this.mnuLienHe});
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
            this.mnuChatLieu.Size = new System.Drawing.Size(179, 22);
            this.mnuChatLieu.Text = "&Chất liệu";
            this.mnuChatLieu.Click += new System.EventHandler(this.mnuChatLieu_Click);
            // 
            // mnuNhanVien
            // 
            this.mnuNhanVien.Image = global::QuanLyBanHang.Properties.Resources.DefaultAccountTile;
            this.mnuNhanVien.Name = "mnuNhanVien";
            this.mnuNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.mnuNhanVien.Size = new System.Drawing.Size(179, 22);
            this.mnuNhanVien.Text = "&Nhân viên";
            this.mnuNhanVien.Click += new System.EventHandler(this.mnuNhanVien_Click);
            // 
            // mnuKhachHang
            // 
            this.mnuKhachHang.Image = global::QuanLyBanHang.Properties.Resources.DefaultAccountTile1;
            this.mnuKhachHang.Name = "mnuKhachHang";
            this.mnuKhachHang.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuKhachHang.Size = new System.Drawing.Size(179, 22);
            this.mnuKhachHang.Text = "&Khách hàng";
            this.mnuKhachHang.Click += new System.EventHandler(this.mnuKhachHang_Click);
            // 
            // mnuHangHoa
            // 
            this.mnuHangHoa.Image = global::QuanLyBanHang.Properties.Resources.store_contrast_black;
            this.mnuHangHoa.Name = "mnuHangHoa";
            this.mnuHangHoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.mnuHangHoa.Size = new System.Drawing.Size(179, 22);
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
            this.mnuFindHoaDon.Size = new System.Drawing.Size(165, 22);
            this.mnuFindHoaDon.Text = "&Hóa đơn";
            this.mnuFindHoaDon.Click += new System.EventHandler(this.mnuFindHoaDon_Click);
            // 
            // mnuBaoCao
            // 
            this.mnuBaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoanhThu});
            this.mnuBaoCao.Name = "mnuBaoCao";
            this.mnuBaoCao.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.mnuBaoCao.Size = new System.Drawing.Size(61, 20);
            this.mnuBaoCao.Text = "&Báo cáo";
            // 
            // mnuDoanhThu
            // 
            this.mnuDoanhThu.Image = global::QuanLyBanHang.Properties.Resources.FeatureToastDlpImg;
            this.mnuDoanhThu.Name = "mnuDoanhThu";
            this.mnuDoanhThu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuDoanhThu.Size = new System.Drawing.Size(170, 22);
            this.mnuDoanhThu.Text = "&Doanh thu";
            this.mnuDoanhThu.Click += new System.EventHandler(this.mnuDoanhThu_Click);
            // 
            // mnuTaiKhoan
            // 
            this.mnuTaiKhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongTinTaiKhoan,
            this.mnuDangXuat});
            this.mnuTaiKhoan.Name = "mnuTaiKhoan";
            this.mnuTaiKhoan.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F2)));
            this.mnuTaiKhoan.Size = new System.Drawing.Size(69, 20);
            this.mnuTaiKhoan.Text = "&Tài khoản";
            // 
            // mnuThongTinTaiKhoan
            // 
            this.mnuThongTinTaiKhoan.Image = global::QuanLyBanHang.Properties.Resources.SquareTile44x44_scale_400;
            this.mnuThongTinTaiKhoan.Name = "mnuThongTinTaiKhoan";
            this.mnuThongTinTaiKhoan.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F8)));
            this.mnuThongTinTaiKhoan.Size = new System.Drawing.Size(219, 22);
            this.mnuThongTinTaiKhoan.Text = "&Thông tin tài khoản";
            this.mnuThongTinTaiKhoan.Click += new System.EventHandler(this.mnuThongTinTaiKhoan_Click);
            // 
            // mnuDangXuat
            // 
            this.mnuDangXuat.Image = global::QuanLyBanHang.Properties.Resources.WindowsSecurityIcon;
            this.mnuDangXuat.Name = "mnuDangXuat";
            this.mnuDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F7)));
            this.mnuDangXuat.Size = new System.Drawing.Size(219, 22);
            this.mnuDangXuat.Text = "&Đăng xuất";
            this.mnuDangXuat.Click += new System.EventHandler(this.mnuDangXuat_Click);
            // 
            // mnuAdmin
            // 
            this.mnuAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKe,
            this.mnuTaiKhoanNhanVien,
            this.mnuThongKeHangHoa});
            this.mnuAdmin.Name = "mnuAdmin";
            this.mnuAdmin.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F3)));
            this.mnuAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnuAdmin.Text = "&Admin";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Image = global::QuanLyBanHang.Properties.Resources.Outlook_Theme_Light_Scale_250;
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.mnuThongKe.Size = new System.Drawing.Size(223, 22);
            this.mnuThongKe.Text = "&Thống kê doanh thu";
            this.mnuThongKe.Click += new System.EventHandler(this.mnuThongKe_Click);
            // 
            // mnuTaiKhoanNhanVien
            // 
            this.mnuTaiKhoanNhanVien.Image = global::QuanLyBanHang.Properties.Resources.Advanced_Theme_Light_Scale_100;
            this.mnuTaiKhoanNhanVien.Name = "mnuTaiKhoanNhanVien";
            this.mnuTaiKhoanNhanVien.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuTaiKhoanNhanVien.Size = new System.Drawing.Size(223, 22);
            this.mnuTaiKhoanNhanVien.Text = "&Quản lý tài khoản";
            this.mnuTaiKhoanNhanVien.Click += new System.EventHandler(this.mnuTaiKhoanNhanVien_Click);
            // 
            // mnuTroGiup
            // 
            this.mnuTroGiup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuGitHub,
            this.mnuFaceBook,
            this.muSkype});
            this.mnuTroGiup.Name = "mnuTroGiup";
            this.mnuTroGiup.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D6)));
            this.mnuTroGiup.Size = new System.Drawing.Size(62, 20);
            this.mnuTroGiup.Text = "&Trợ giúp";
            // 
            // mnuGitHub
            // 
            this.mnuGitHub.Image = global::QuanLyBanHang.Properties.Resources.github;
            this.mnuGitHub.Name = "mnuGitHub";
            this.mnuGitHub.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D7)));
            this.mnuGitHub.Size = new System.Drawing.Size(188, 22);
            this.mnuGitHub.Text = "&GitHub";
            this.mnuGitHub.Click += new System.EventHandler(this.mnuGitHub_Click);
            // 
            // mnuFaceBook
            // 
            this.mnuFaceBook.Image = global::QuanLyBanHang.Properties.Resources.facebook;
            this.mnuFaceBook.Name = "mnuFaceBook";
            this.mnuFaceBook.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D8)));
            this.mnuFaceBook.Size = new System.Drawing.Size(188, 22);
            this.mnuFaceBook.Text = "&FaceBook";
            this.mnuFaceBook.Click += new System.EventHandler(this.mnuFaceBook_Click);
            // 
            // muSkype
            // 
            this.muSkype.Image = global::QuanLyBanHang.Properties.Resources.skype;
            this.muSkype.Name = "muSkype";
            this.muSkype.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.D9)));
            this.muSkype.Size = new System.Drawing.Size(188, 22);
            this.muSkype.Text = "&Skype";
            this.muSkype.Click += new System.EventHandler(this.muSkype_Click);
            // 
            // mnuLienHe
            // 
            this.mnuLienHe.Name = "mnuLienHe";
            this.mnuLienHe.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F12)));
            this.mnuLienHe.Size = new System.Drawing.Size(57, 20);
            this.mnuLienHe.Text = "&Liên hệ";
            this.mnuLienHe.Click += new System.EventHandler(this.mnuLienHe_Click);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Violet;
            this.panel1.Controls.Add(this.lbUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 100);
            this.panel1.TabIndex = 20;
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.BackColor = System.Drawing.Color.Transparent;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Green;
            this.lbUsername.Location = new System.Drawing.Point(524, 54);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(41, 31);
            this.lbUsername.TabIndex = 9;
            this.lbUsername.Text = "...";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.ImageKey = "(none)";
            this.label2.Location = new System.Drawing.Point(399, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "CHỨC VỤ";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(313, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(435, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cửa hàng quà lưu niệm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Diem_danh_14_mat_hang_kinh_doanh_online_ban_chay_nhat_hien_nay_Phan_1_21;
            this.pictureBox1.Location = new System.Drawing.Point(0, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1077, 449);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // mnuThongKeHangHoa
            // 
            this.mnuThongKeHangHoa.Image = global::QuanLyBanHang.Properties.Resources.Outlook_Theme_Light_Scale_250;
            this.mnuThongKeHangHoa.Name = "mnuThongKeHangHoa";
            this.mnuThongKeHangHoa.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.mnuThongKeHangHoa.Size = new System.Drawing.Size(223, 22);
            this.mnuThongKeHangHoa.Text = "Thống kê hàng hóa";
            this.mnuThongKeHangHoa.Click += new System.EventHandler(this.mnuThongKeHangHoa_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 597);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cửa hàng quà lưu niệm";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao;
        private System.Windows.Forms.ToolStripMenuItem mnuDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuThongTinTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnuDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnuAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
        private System.Windows.Forms.ToolStripMenuItem mnuTaiKhoanNhanVien;
        private System.Windows.Forms.ToolStripMenuItem mnuTroGiup;
        private System.Windows.Forms.ToolStripMenuItem mnuGitHub;
        private System.Windows.Forms.ToolStripMenuItem mnuFaceBook;
        private System.Windows.Forms.ToolStripMenuItem muSkype;
        private System.Windows.Forms.ToolStripMenuItem mnuLienHe;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKeHangHoa;
    }
}

