using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanHang.Class
{
    public class Account
    {
        public Account(string taiKhoan, string tenhienThi, string email, string type, string matKhau = null)
        {
            this.TaiKhoan = taiKhoan;
            this.TenHienThi = tenhienThi;
            this.Email = email;
            this.Type = type;
            this.MatKhau = matKhau;
        }

        public Account(DataRow row)
        {
            this.TaiKhoan = row["taiKhoan"].ToString();
            this.TenHienThi = row["tenhienThi"].ToString();
            this.Email = row["email"].ToString();
            this.Type = row["type"].ToString();
            this.MatKhau = row["matKhau"].ToString();
        }

        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string tenhienThi;
        public string TenHienThi
        {
            get { return tenhienThi; }
            set { tenhienThi = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }

        private string taiKhoan;

        public string TaiKhoan
        {
            get { return taiKhoan; }
            set { taiKhoan = value; }
        }
    }
}
