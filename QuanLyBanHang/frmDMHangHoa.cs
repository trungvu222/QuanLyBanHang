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
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using QuanLyBanHang.Class;
using System.Data.OleDb;

namespace QuanLyBanHang
{
    public partial class frmDMHangHoa : Form
    {
        DataTable tblH; //Bảng hàng
        public frmDMHangHoa()
        {
            InitializeComponent();
        }

        private void frmDMHangHoa_Load(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT * from tblChatLieu";
            txtMaHang.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
            Functions.FillCombo(sql, cboMaChatLieu, "maChatLieu", "TenChatLieu");
            cboMaChatLieu.SelectedIndex = -1;
            ResetValues();
        }
        //Phương thức nạp dữ liệu

        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT A.MaHang,A.TenHang,B.MaChatLieu,A.SoLuong,A.DonGiaNhap,A.GiaBan,A.Anh,A.GhiChu " +
                "FROM tblHang AS A INNER JOIN tblChatLieu AS B ON A.maChatLieu = B.maChatLieu";
            tblH = Functions.GetDataToTable(sql);
            dgvHang.DataSource = tblH;
            dgvHang.Columns[0].HeaderText = "Mã hàng";
            dgvHang.Columns[1].HeaderText = "Tên hàng";
            dgvHang.Columns[2].HeaderText = "Chất liệu";
            dgvHang.Columns[3].HeaderText = "Số lượng";
            dgvHang.Columns[4].HeaderText = "Đơn giá nhập";
            dgvHang.Columns[5].HeaderText = "Đơn giá bán";
            dgvHang.Columns[6].HeaderText = "Ảnh";
            dgvHang.Columns[7].HeaderText = "Ghi chú";
            dgvHang.Columns[0].Width = 80;
            dgvHang.Columns[1].Width = 140;
            dgvHang.Columns[2].Width = 80;
            dgvHang.Columns[3].Width = 80;
            dgvHang.Columns[4].Width = 100;
            dgvHang.Columns[5].Width = 100;
            dgvHang.Columns[6].Width = 200;
            dgvHang.Columns[7].Width = 300;
            dgvHang.AllowUserToAddRows = false;
            dgvHang.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        //Khởi tạo lại giá trị
        private void ResetValues()
        {
            txtMaHang.Text = "";
            txtTenHang.Text = "";
            cboMaChatLieu.Text = "";
            txtSoLuong.Text = "0";
            txtDonGiaNhap.Text = "0";
            txtDonGiaBan.Text = "0";
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = false;
            txtDonGiaBan.Enabled = false;
            txtAnh.Text = "";
            picAnh.Image = null;
            txtGhiChu.Text = "";
            txtMaHang.Focus();
        }

        private void dgvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaChatLieu;
            string sql;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }           
            txtMaHang.Text = dgvHang.CurrentRow.Cells["MaHang"].Value.ToString();
            txtTenHang.Text = dgvHang.CurrentRow.Cells["TenHang"].Value.ToString();
            MaChatLieu = dgvHang.CurrentRow.Cells["MaChatLieu"].Value.ToString();
            sql = "SELECT TenChatLieu FROM tblChatLieu WHERE MaChatLieu=N'" + MaChatLieu + "'";
            cboMaChatLieu.Text = Functions.GetFieldValues(sql);
            txtSoLuong.Text = dgvHang.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDonGiaNhap.Text = dgvHang.CurrentRow.Cells["DonGiaNhap"].Value.ToString();
            txtDonGiaBan.Text = dgvHang.CurrentRow.Cells["GiaBan"].Value.ToString();
            sql = "SELECT Anh FROM tblHang WHERE MaHang=N'" + txtMaHang.Text + "'";
            txtAnh.Text = Functions.GetFieldValues(sql);
            picAnh.Image = Image.FromFile(txtAnh.Text);
            sql = "SELECT Ghichu FROM tblHang WHERE MaHang = N'" + txtMaHang.Text + "'";
            txtGhiChu.Text = Functions.GetFieldValues(sql);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMaHang.Enabled = true;
            txtMaHang.Focus();
            txtSoLuong.Enabled = true;
            txtDonGiaNhap.Enabled = true;
            txtDonGiaBan.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMaHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaChatLieu.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOpen.Focus();
                return;
            }
            sql = "SELECT MaHang FROM tblHang WHERE MaHang=N'" + txtMaHang.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã hàng này đã tồn tại, bạn phải chọn mã hàng khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            sql = "INSERT INTO tblHang(MaHang,TenHang,maChatLieu,SoLuong,DonGiaNhap,GiaBan,Anh,Ghichu) VALUES(N'"
                + txtMaHang.Text.Trim() + "',N'" + txtTenHang.Text.Trim() +
                "',N'" + cboMaChatLieu.SelectedValue.ToString() +
                "'," + txtSoLuong.Text.Trim() + "," + txtDonGiaNhap.Text +
                "," + txtDonGiaBan.Text + ",'" + txtAnh.Text + "',N'" + txtGhiChu.Text.Trim() + "')";

            Functions.RunSQL(sql);
            LoadDataGridView();
            //ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|All files(*.*)|*.*";
            dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh minh hoạ cho sản phẩm";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(dlgOpen.FileName);
                txtAnh.Text = dlgOpen.FileName;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaHang.Focus();
                return;
            }
            if (txtTenHang.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTenHang.Focus();
                return;
            }
            if (cboMaChatLieu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập chất liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMaChatLieu.Focus();
                return;
            }
            if (txtAnh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải ảnh minh hoạ cho hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAnh.Focus();
                return;
            }
            sql = "UPDATE tblHang SET TenHang=N'" + txtTenHang.Text.Trim().ToString() +
                "',maChatLieu=N'" + cboMaChatLieu.SelectedValue.ToString() +
                "',SoLuong=" + txtSoLuong.Text +
                ",Anh='" + txtAnh.Text + "',Ghichu=N'" + txtGhiChu.Text + "' WHERE MaHang=N'" + txtMaHang.Text + "'";
            Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValues();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaHang.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá bản ghi này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblHang WHERE MaHang=N'" + txtMaHang.Text + "'";
                Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValues();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaHang.Enabled = false;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtMaHang.Text == "") && (txtTenHang.Text == "") && (cboMaChatLieu.Text == ""))
            {
                MessageBox.Show("Bạn hãy nhập điều kiện tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT * from tblHang WHERE 1=1";
            if (txtMaHang.Text != "")
                sql += " AND MaHang LIKE N'%" + txtMaHang.Text + "%'";
            if (txtTenHang.Text != "")
                sql += " AND TenHang LIKE N'%" + txtTenHang.Text + "%'";
            if (cboMaChatLieu.Text != "")
                sql += " AND maChatLieu LIKE N'%" + cboMaChatLieu.SelectedValue + "%'";
            tblH = Functions.GetDataToTable(sql);
            if (tblH.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thoả mãn điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Có " + tblH.Rows.Count + "  bản ghi thoả mãn điều kiện!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dgvHang.DataSource = tblH;
            ResetValues();
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT MaHang,TenHang,maChatLieu,SoLuong,DonGiaNhap,Anh,GiaBan,Ghichu FROM tblHang";
            tblH = Functions.GetDataToTable(sql);
            dgvHang.DataSource = tblH;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = string.Format("Hôm nay là ngày {0} - Bây giờ là {1}", DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("hh:mm:ss tt"));
        }

        private void txtMaHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtTenHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void cboMaChatLieu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtSoLuong_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDonGiaNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtDonGiaBan_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtAnh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void txtGhiChu_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }

        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for(int i=0;i<dgvHang.Columns.Count;i++)
            {
                application.Cells[1, i + 1] = dgvHang.Columns[i].HeaderText;
            }
            for(int i=0;i<dgvHang.Rows.Count;i++)
            {
                for(int j=0;j<dgvHang.Columns.Count;j++)
                {
                    application.Cells[i + 2, j + 1] = dgvHang.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }

        //private void ImportExcel(string path)
        //{
        //    using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
        //    {
        //        ExcelWorksheet excelWorksheet = excelPackage.Workbook.Worksheets[0];
        //        DataTable dataTable = new DataTable();
        //        for(int i = excelWorksheet.Dimension.Start.Column;i<=excelWorksheet.Dimension.End.Column;i++)
        //        {
        //            dataTable.Columns.Add(excelWorksheet.Cells[1, i].Value.ToString());
        //        }
        //        for (int i = excelWorksheet.Dimension.Start.Row+1; i <= excelWorksheet.Dimension.End.Row; i++)
        //        {
        //            List<string> listRows = new List<string>();
        //            for (int j = excelWorksheet.Dimension.Start.Column; j <= excelWorksheet.Dimension.End.Column; j++)
        //            {
        //                listRows.Add(excelWorksheet.Cells[i, j].Value.ToString());
        //            }
        //            dataTable.Rows.Add(listRows.ToArray());
        //        }
        //        dgvHang.DataSource = dataTable;
        //    }
        //}

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("Xuất hàng thành công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Xuất hàng không thành công!\n" + ex.Message);
                }
            }
        }

        //private void btnImportExcel_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        //        {
        //            using (OleDbConnection myConnecct = new OleDbConnection(string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=Excel 8.0;", openFileDialog1.FileName)))
        //            {
        //                DataTable dt = new DataTable();
        //                OleDbDataAdapter cmd = new OleDbDataAdapter("select * from [Sheet1$]", myConnecct);
        //                cmd.Fill(dt);
        //                dgvHang.DataSource = dt;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }         
        //}
    }
}
