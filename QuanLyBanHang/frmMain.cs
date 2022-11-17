﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public frmMain(string tentk)
        {
            InitializeComponent();
            lbUsername.Text = tentk;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Functions.Connect();  // Mo ket noi
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();   // Dong ket noi
            Application.Exit();   // Thoat
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmDMChatLieu frm = new frmDMChatLieu();
            frm.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.Show();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.Show();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.Show();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.Show();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frm = new frmTimKiemHD();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = new frmDoanhThu();
            frm.Show();
        }

        private void btnOpenURL2_Click_1(object sender, EventArgs e)
        {
            string url = "https://web.skype.com/";
            Process.Start(url);
        }

        private void btnOpenURL_Click_1(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/vuthanhtrung123/"; // URL cần được mở trên trình duyệt
            Process.Start(url); // Thực hiện mở URL trên trình duyệt
        }

        private void btnOpenURL4_Click_1(object sender, EventArgs e)
        {
            string url = "https://github.com/trungvu222/QuanLyBanHang";
            Process.Start(url);
        }

        private void btnDangXuat_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }
    }
}
