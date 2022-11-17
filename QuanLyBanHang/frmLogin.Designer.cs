
namespace QuanLyBanHang
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.linkLabel_QuenMatKhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel_DangKy = new System.Windows.Forms.LinkLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập hệ thống";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Location = new System.Drawing.Point(140, 337);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(226, 20);
            this.txtTaiKhoan.TabIndex = 3;
            this.txtTaiKhoan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTaiKhoan_KeyUp);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(140, 371);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(226, 20);
            this.txtMatKhau.TabIndex = 4;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyUp);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(146, 450);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(104, 37);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            this.btnLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnLogin_KeyUp);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(265, 450);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 37);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Exit";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            this.btnThoat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnThoat_KeyUp);
            // 
            // linkLabel_QuenMatKhau
            // 
            this.linkLabel_QuenMatKhau.AutoSize = true;
            this.linkLabel_QuenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_QuenMatKhau.Location = new System.Drawing.Point(142, 410);
            this.linkLabel_QuenMatKhau.Name = "linkLabel_QuenMatKhau";
            this.linkLabel_QuenMatKhau.Size = new System.Drawing.Size(134, 20);
            this.linkLabel_QuenMatKhau.TabIndex = 8;
            this.linkLabel_QuenMatKhau.TabStop = true;
            this.linkLabel_QuenMatKhau.Text = "Quên Mật Khẩu?";
            this.linkLabel_QuenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_QuenMatKhau_LinkClicked);
            // 
            // linkLabel_DangKy
            // 
            this.linkLabel_DangKy.AutoSize = true;
            this.linkLabel_DangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_DangKy.Location = new System.Drawing.Point(294, 410);
            this.linkLabel_DangKy.Name = "linkLabel_DangKy";
            this.linkLabel_DangKy.Size = new System.Drawing.Size(72, 20);
            this.linkLabel_DangKy.TabIndex = 9;
            this.linkLabel_DangKy.TabStop = true;
            this.linkLabel_DangKy.Text = "Đăng Ký";
            this.linkLabel_DangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_DangKy_LinkClicked);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Violet;
            this.pictureBox2.Image = global::QuanLyBanHang.Properties.Resources.dismiss2;
            this.pictureBox2.Location = new System.Drawing.Point(472, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.imager_1_32515_700;
            this.pictureBox1.Location = new System.Drawing.Point(130, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 202);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(502, 508);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel_DangKy);
            this.Controls.Add(this.linkLabel_QuenMatKhau);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập hệ thống";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel_QuenMatKhau;
        private System.Windows.Forms.LinkLabel linkLabel_DangKy;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}