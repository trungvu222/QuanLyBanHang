using QuanLyBanHang.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmThongKeHangHoa : Form
    {
        public frmThongKeHangHoa()
        {
            InitializeComponent();
            LoadReportList();
        }

        void LoadReportList()
        {
            string connectionSTR = "Data Source=THANHTRUNG\\SQLEXPRESS01;Initial Catalog=QuanLyBanHang;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionSTR);

            string query = "SELECT MaHang AS [Mã hàng hóa], TenHang AS [Tên hàng hóa], maChatLieu AS [Mã chất liệu], SoLuong AS [Số lượng], DonGiaNhap AS [Đơn giá nhập], GiaBan AS [Giá bán] FROM dbo.tblHang";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvProduct.DataSource = data;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
