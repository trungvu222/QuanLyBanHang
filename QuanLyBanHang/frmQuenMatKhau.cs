using QuanLyBanHang.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmQuenMatKhau : Form
    {
        public frmQuenMatKhau()
        {
            InitializeComponent();
            label2.Text = "";
        }
        Modify modify = new Modify();
        private void btnQuenMatKhau_Click(object sender, EventArgs e)
        {
            string email = txtEmailDangKy.Text;
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập email đăng kí!"); }
            else
            {
                string query = "Select * from tblDangNhap where Email = '" + email + "'";
                if(modify.TaiKhoans(query).Count!=0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text = "Mật khẩu: " + modify.TaiKhoans(query)[0].MatKhau;
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Email này chưa được đăng kí!";
                }
            }
        }

        private void txtEmailDangKy_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void btnQuenMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
