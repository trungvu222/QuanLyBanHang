using QuanLyBanHang.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        public bool UpdateAccount(string taiKhoan, string tenhienThi, string email, string matKhau, string newPass)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("exec USP_UpdateAccount @taiKhoan , @tenhienThi , @email , @matKhau , @newPassword", new object[] {taiKhoan, tenhienThi, email, matKhau, newPass});

            return result > 0;
        }

        public DataTable GetListAccount()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT TaiKhoan AS [Tài khoản], TenHienThi AS [Tên hiển thị], Email, Type AS [Loại tài khoản] FROM dbo.tblDangNhap");
        }

        public Account GetAccountByUserName(string tentk)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from tblDangNhap where TaiKhoan = '" + tentk + "'");

            foreach (DataRow item in data.Rows)
            {
                return new Account(item);
            }

            return null;
        }

        public bool InsertAccount(string username, string displayname, string email, string type)
        {
            string query = string.Format("INSERT dbo.tblDangNhap ( TaiKhoan, TenHienThi, Email, Type )VALUES ( N'{0}', N'{1}', N'{2}', N'{3}')", username, displayname, email, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateAccount(string username, string displayname, string email, string type)
        {
            string query = string.Format("UPDATE dbo.tblDangNhap SET TenHienThi = N'{1}', Email = N'{2}', Type = N'{3}' WHERE TaiKhoan = N'{0}'", username, displayname, email, type);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteAccount(string username)
        {
            string query = string.Format("Delete dbo.tblDangNhap where TaiKhoan = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool ResetPassword(string username)
        {
            string query = string.Format("UPDATE dbo.tblDangNhap set MatKhau = N'0' where TaiKhoan = N'{0}'", username);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
