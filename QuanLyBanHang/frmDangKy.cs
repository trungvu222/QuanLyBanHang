using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        public bool CheckAccount(string ac) //Check mat khau va tai khoan
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em) //Check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }
        Modify modify = new Modify();
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            string xnmatkhau = textBox_XNMatKhau.Text;
            string email = textBox_Email.Text;
            if (!CheckAccount(tentk)) { MessageBox.Show("Vui lòng nhập tên tài khoản dài 3-15 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!") ;return;}
            if (!CheckAccount(matkhau)) { MessageBox.Show("Vui lòng nhập mật khẩu dài 3-15 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!"); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Vui lòng xác nhận mật khẩu!"); return; }
            if (!CheckEmail(email)) { MessageBox.Show("Vui lòng nhập đúng định dạng email!"); return; }
            if (modify.TaiKhoans("Select * from tblDangNhap where Email = '"+ email + "'").Count != 0) { MessageBox.Show("Email này đã được đăng kí, vui lòng đăng kí email khác!"); return; }
            try
            {
                string query = "Insert into tblDangNhap values ('"+tentk+"','"+matkhau+"','"+email+"')";
                modify.Command(query);
                if(MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác!");
            }
        }

        private void textBox_TenTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void textBox_MatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void textBox_XNMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void textBox_Email_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnDangKy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
