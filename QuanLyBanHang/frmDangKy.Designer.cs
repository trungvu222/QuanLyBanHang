﻿
namespace QuanLyBanHang
{
    partial class frmDangKy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangKy));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_XNMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pShow = new System.Windows.Forms.PictureBox();
            this.ptShow = new System.Windows.Forms.PictureBox();
            this.pHide = new System.Windows.Forms.PictureBox();
            this.ptHide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptHide)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(25, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên tài khoản:";
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(244, 283);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(223, 20);
            this.textBox_TenTaiKhoan.TabIndex = 0;
            this.textBox_TenTaiKhoan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_TenTaiKhoan_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(25, 317);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(244, 323);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.PasswordChar = '•';
            this.textBox_MatKhau.Size = new System.Drawing.Size(223, 20);
            this.textBox_MatKhau.TabIndex = 1;
            this.textBox_MatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_MatKhau_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(25, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Xác nhận mật khẩu:";
            // 
            // textBox_XNMatKhau
            // 
            this.textBox_XNMatKhau.Location = new System.Drawing.Point(244, 363);
            this.textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            this.textBox_XNMatKhau.PasswordChar = '•';
            this.textBox_XNMatKhau.Size = new System.Drawing.Size(223, 20);
            this.textBox_XNMatKhau.TabIndex = 2;
            this.textBox_XNMatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_XNMatKhau_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(25, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(244, 402);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(223, 20);
            this.textBox_Email.TabIndex = 3;
            this.textBox_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Email_KeyUp);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangKy.Location = new System.Drawing.Point(187, 442);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(101, 36);
            this.btnDangKy.TabIndex = 4;
            this.btnDangKy.Text = "Đăng Kí";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            this.btnDangKy.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btnDangKy_KeyUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources.Users;
            this.pictureBox1.Location = new System.Drawing.Point(93, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(314, 231);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pShow
            // 
            this.pShow.Image = global::QuanLyBanHang.Properties.Resources.show;
            this.pShow.Location = new System.Drawing.Point(475, 323);
            this.pShow.Name = "pShow";
            this.pShow.Size = new System.Drawing.Size(27, 20);
            this.pShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pShow.TabIndex = 15;
            this.pShow.TabStop = false;
            this.pShow.Click += new System.EventHandler(this.pShow_Click);
            // 
            // ptShow
            // 
            this.ptShow.Image = global::QuanLyBanHang.Properties.Resources.show;
            this.ptShow.Location = new System.Drawing.Point(475, 363);
            this.ptShow.Name = "ptShow";
            this.ptShow.Size = new System.Drawing.Size(27, 20);
            this.ptShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptShow.TabIndex = 16;
            this.ptShow.TabStop = false;
            this.ptShow.Click += new System.EventHandler(this.ptShow_Click);
            // 
            // pHide
            // 
            this.pHide.Image = global::QuanLyBanHang.Properties.Resources.hide;
            this.pHide.Location = new System.Drawing.Point(475, 323);
            this.pHide.Name = "pHide";
            this.pHide.Size = new System.Drawing.Size(27, 20);
            this.pHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pHide.TabIndex = 17;
            this.pHide.TabStop = false;
            this.pHide.Click += new System.EventHandler(this.pHide_Click_1);
            // 
            // ptHide
            // 
            this.ptHide.Image = global::QuanLyBanHang.Properties.Resources.hide;
            this.ptHide.Location = new System.Drawing.Point(475, 363);
            this.ptHide.Name = "ptHide";
            this.ptHide.Size = new System.Drawing.Size(27, 20);
            this.ptHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptHide.TabIndex = 18;
            this.ptHide.TabStop = false;
            this.ptHide.Click += new System.EventHandler(this.ptHide_Click_1);
            // 
            // frmDangKy
            // 
            this.AcceptButton = this.btnDangKy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(510, 490);
            this.Controls.Add(this.ptHide);
            this.Controls.Add(this.pHide);
            this.Controls.Add(this.ptShow);
            this.Controls.Add(this.pShow);
            this.Controls.Add(this.btnDangKy);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_XNMatKhau);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng ký";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_TenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_MatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_XNMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.PictureBox pShow;
        private System.Windows.Forms.PictureBox ptShow;
        private System.Windows.Forms.PictureBox pHide;
        private System.Windows.Forms.PictureBox ptHide;
    }
}