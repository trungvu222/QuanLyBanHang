using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyBanHang.Class;
using QuanLyBanHang.DAO;

namespace QuanLyBanHang
{
    public partial class frmLogin : Form
    {
        public static SqlConnection conn;
        public frmLogin()
        {
            InitializeComponent();
        }

        Modify modify = new Modify();

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tentk = txtTaiKhoan.Text;
            string matkhau = txtMatKhau.Text;

            if (cboLoaiTaiKhoan.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }

            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!"); }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu!"); }
            else
            {
                string query = "Select * from tblDangNhap where TaiKhoan = '" + tentk + "' and MatKhau = '" + matkhau + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    //MessageBox.Show("Đăng nhập thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    this.Hide();
                    Account loginAccount = AccountDAO.Instance.GetAccountByUserName(tentk);
                    frmMain frM = new frmMain(tentk, loginAccount);
                    frM.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.DialogResult = DialogResult.OK;
            if (cbLogin.Checked)
            {
                Properties.Settings.Default.users = txtTaiKhoan.Text;
                Properties.Settings.Default.pass = txtMatKhau.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.users = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = Properties.Settings.Default.users;
            txtMatKhau.Text = Properties.Settings.Default.pass;
            if (Properties.Settings.Default.users != "")
            {
                cbLogin.Checked = true;
            }

            //string sql = "Select * from tblDangNhap";
            //cboLoaiTaiKhoan.DataSource = DataProvider.Instance.ExecuteQuery(sql);
            //cboLoaiTaiKhoan.DisplayMember = "TaiKhoan";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có muốn thoát hay không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                Application.Exit();
        }

        private void txtTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnThoat_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmQuenMatKhau quenMatKhau = new frmQuenMatKhau();
            quenMatKhau.ShowDialog();
        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDangKy dangKy = new frmDangKy();
            dangKy.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pHide_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar == '•')
            {
                pShow.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void pShow_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar == '\0')
            {
                pHide.BringToFront();
                txtMatKhau.PasswordChar = '•';
            }
        }

        private void cbLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text != "" && txtMatKhau.Text != "")
            {
                if (cbLogin.Checked == true)
                {
                    string user = txtTaiKhoan.Text;
                    string pwd = txtMatKhau.Text;
                    Properties.Settings.Default.users = user;
                    Properties.Settings.Default.pass = pwd;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Reset();
                }
            }
        }
    }
}
