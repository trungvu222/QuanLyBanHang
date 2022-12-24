using QuanLyBanHang.Class;
using QuanLyBanHang.DAO;
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
    public partial class frmAccountStaff : Form
    {
        BindingSource accountList = new BindingSource();
        public frmAccountStaff()
        {
            InitializeComponent();
            dgvAccount.DataSource = accountList;
            LoadAccount();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tài khoản", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Tên hiển thị", true, DataSourceUpdateMode.Never));
            txtEmail.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Email", true, DataSourceUpdateMode.Never));
            cboAccountType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }

        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void frmAccountStaff_Load(object sender, EventArgs e)
        {
            string sql = "Select * from tblDangNhap";
            cboAccountType.DataSource = DataProvider.Instance.ExecuteQuery(sql);
            cboAccountType.DisplayMember = "Type";
        }

        void AddAccount(string taiKhoan, string tenhienThi, string email, string type)
        {
            if (AccountDAO.Instance.InsertAccount(taiKhoan, tenhienThi, email, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }

            LoadAccount();
        }

        void EditAccount(string taiKhoan, string tenhienThi, string email, string type)
        {
            if (AccountDAO.Instance.UpdateAccount(taiKhoan, tenhienThi, email, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }

            LoadAccount();
        }

        void DeleteAccount(string taiKhoan)
        {
            if (AccountDAO.Instance.DeleteAccount(taiKhoan))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }

            LoadAccount();
        }

        void ResetPass(string taiKhoan)
        {
            if (AccountDAO.Instance.ResetPassword(taiKhoan))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
        }

        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtUserName.Text;
            string tenhienThi = txtDisplayName.Text;
            string email = txtEmail.Text;
            string type = cboAccountType.Text;

            AddAccount(taiKhoan, tenhienThi, email, type);
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtUserName.Text;
            DeleteAccount(taiKhoan);
        }

        private void btnEditAccount_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtUserName.Text;
            string tenhienThi = txtDisplayName.Text;
            string email = txtEmail.Text;
            string type = cboAccountType.Text;

            EditAccount(taiKhoan, tenhienThi, email, type);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string taiKhoan = txtUserName.Text;
            ResetPass(taiKhoan);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
