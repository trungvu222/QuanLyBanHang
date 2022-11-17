using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyBanHang.Class
{
    class Connection
    {
        private static string stringConnection = @"Data Source=THANHTRUNG\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
