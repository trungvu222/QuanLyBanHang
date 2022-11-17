using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmDoanhThu : Form
    {
        public frmDoanhThu()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void frmDoanhThu_Load(object sender, EventArgs e)
        {
            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report1.rdlc";
                reportViewer2.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report2.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                ReportDataSource reportDataSource1 = new ReportDataSource();
                reportDataSource1.Name = "DataSet1";
                reportDataSource.Name = "DataSet2";
                reportDataSource1.Value = modify.getAllHoaDonBan();
                reportDataSource.Value = modify.getAllHang();
                reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
                reportViewer2.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
                this.reportViewer2.RefreshReport();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }
    }
}
