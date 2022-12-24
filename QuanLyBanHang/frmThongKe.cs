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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            LoadDateTimePickerBill();
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            //LoadReportList();
        }

        #region methods
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpkFromDate.Value = new DateTime(today.Year, today.Month, 1);
            dtpkToDate.Value = dtpkFromDate.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            dgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }
        #endregion

        #region events
        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }
        #endregion

        //void LoadReportList()
        //{
        //    string query = "SELECT MaHDBan AS [Mã hóa đơn], MaNhanVien AS [Mã nhân viên], NgayBan AS [Ngày bán], MaKhach AS [Mã khách], TongTien AS [Tổng tiền] FROM dbo.tblHDBan";

        //    DataProvider provider = new DataProvider();

        //    dgvBill.DataSource = provider.ExecuteQuery(query);
        //}
    }
}
