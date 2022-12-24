using System;
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
        private Account loginAccount;
        private Account type;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        public frmMain(string tentk, Account acc)
        {
            InitializeComponent();
            lbUsername.Text = tentk;
            this.LoginAccount = acc;
        }

        void ChangeAccount(string type)
        {
            if(type.Equals("Nhân viên"))
            {
                mnuDanhMuc.Visible = false;
                mnuBaoCao.Visible = false;
                mnuAdmin.Visible = false;
                mnuDanhMuc.Visible = true;
                mnuKhachHang.Visible = true;
                mnuChatLieu.Visible = false;
                mnuNhanVien.Visible = false;
                mnuHangHoa.Visible = false;
                mnuTroGiup.Visible = false;
                mnuLienHe.Visible = false;
            }
            mnuTaiKhoan.Text += " (" + LoginAccount.TenHienThi + ")";
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
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.ShowDialog();
        }

        private void mnuFindHoaDon_Click(object sender, EventArgs e)
        {
            frmTimKiemHD frm = new frmTimKiemHD();
            frm.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            frmDoanhThu frm = new frmDoanhThu();
            frm.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }

        private void mnuThongTinTaiKhoan_Click(object sender, EventArgs e)
        {
            frmAccountProfile frm = new frmAccountProfile(LoginAccount);
            frm.UpdateAccount += frm_UpdateAccount;
            frm.ShowDialog();
        }

        void frm_UpdateAccount(object sender, AccountEvent e)
        {
            mnuTaiKhoan.Text = "Tài khoản (" + e.Acc.TenHienThi + ")";
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            frm.ShowDialog();
        }

        private void mnuTaiKhoanNhanVien_Click(object sender, EventArgs e)
        {
            frmAccountStaff frm = new frmAccountStaff();
            frm.ShowDialog();
        }

        private void mnuGitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/trungvu222/QuanLyBanHang";
            Process.Start(url);
        }

        private void mnuFaceBook_Click(object sender, EventArgs e)
        {
            string url = "https://www.facebook.com/vuthanhtrung123/"; // URL cần được mở trên trình duyệt
            Process.Start(url); // Thực hiện mở URL trên trình duyệt
        }

        private void muSkype_Click(object sender, EventArgs e)
        {
            string url = "https://join.skype.com/invite/y5M7tr4LuwY3";
            Process.Start(url);
        }

        private void mnuLienHe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn cần trợ giúp liên hệ với chúng tôi qua FaceBook & Skype\nGitHub (Vui lòng liên hệ trực tiếp với nhà phát triển của bạn)!\nHoặc liên hệ trực tiếp với chúng tôi qua số điện thoại (Zalo) đang hiển thị trên màn hình: 0528592362\nThank you!!!","Liên hệ với chúng tôi");
        }

        private void mnuThongKeHangHoa_Click(object sender, EventArgs e)
        {
            frmThongKeHangHoa frm = new frmThongKeHangHoa();
            frm.ShowDialog();
        }
    }
}
