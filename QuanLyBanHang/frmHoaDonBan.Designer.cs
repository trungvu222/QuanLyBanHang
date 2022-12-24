
namespace QuanLyBanHang
{
    partial class frmHoaDonBan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDonBan));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cboMaHDBan = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaKhach = new System.Windows.Forms.ComboBox();
            this.cboMaNhanVien = new System.Windows.Forms.ComboBox();
            this.mtbDienThoai = new System.Windows.Forms.MaskedTextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.txtTenNhanVien = new System.Windows.Forms.TextBox();
            this.dtpNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDBan = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvHDBanHang = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.lblBangChu = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtDonGiaBan = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboMaHang = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnDong = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.btnTimKiem);
            this.panel1.Controls.Add(this.cboMaHDBan);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 678);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1130, 89);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 67);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1130, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // cboMaHDBan
            // 
            this.cboMaHDBan.FormattingEnabled = true;
            this.cboMaHDBan.Location = new System.Drawing.Point(109, 21);
            this.cboMaHDBan.Name = "cboMaHDBan";
            this.cboMaHDBan.Size = new System.Drawing.Size(304, 21);
            this.cboMaHDBan.TabIndex = 1;
            this.cboMaHDBan.DropDown += new System.EventHandler(this.cboMaHDBan_DropDown);
            this.cboMaHDBan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMaHDBan_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(1130, 678);
            this.splitContainer1.SplitterDistance = 333;
            this.splitContainer1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaKhach);
            this.groupBox1.Controls.Add(this.cboMaNhanVien);
            this.groupBox1.Controls.Add(this.mtbDienThoai);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtTenKhach);
            this.groupBox1.Controls.Add(this.txtTenNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayBan);
            this.groupBox1.Controls.Add(this.txtMaHDBan);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(3, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1124, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // cboMaKhach
            // 
            this.cboMaKhach.FormattingEnabled = true;
            this.cboMaKhach.Location = new System.Drawing.Point(767, 27);
            this.cboMaKhach.Name = "cboMaKhach";
            this.cboMaKhach.Size = new System.Drawing.Size(170, 21);
            this.cboMaKhach.TabIndex = 4;
            this.cboMaKhach.SelectedIndexChanged += new System.EventHandler(this.cboMaKhach_SelectedIndexChanged);
            this.cboMaKhach.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMaKhach_KeyUp);
            // 
            // cboMaNhanVien
            // 
            this.cboMaNhanVien.FormattingEnabled = true;
            this.cboMaNhanVien.Location = new System.Drawing.Point(126, 168);
            this.cboMaNhanVien.Name = "cboMaNhanVien";
            this.cboMaNhanVien.Size = new System.Drawing.Size(155, 21);
            this.cboMaNhanVien.TabIndex = 2;
            this.cboMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboMaNhanVien_SelectedIndexChanged);
            this.cboMaNhanVien.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMaNhanVien_KeyUp);
            // 
            // mtbDienThoai
            // 
            this.mtbDienThoai.Location = new System.Drawing.Point(767, 233);
            this.mtbDienThoai.Mask = "(999) 000-0000";
            this.mtbDienThoai.Name = "mtbDienThoai";
            this.mtbDienThoai.ReadOnly = true;
            this.mtbDienThoai.Size = new System.Drawing.Size(170, 20);
            this.mtbDienThoai.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(767, 168);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(170, 20);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Location = new System.Drawing.Point(767, 96);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.ReadOnly = true;
            this.txtTenKhach.Size = new System.Drawing.Size(170, 20);
            this.txtTenKhach.TabIndex = 5;
            // 
            // txtTenNhanVien
            // 
            this.txtTenNhanVien.Location = new System.Drawing.Point(126, 237);
            this.txtTenNhanVien.Name = "txtTenNhanVien";
            this.txtTenNhanVien.ReadOnly = true;
            this.txtTenNhanVien.Size = new System.Drawing.Size(155, 20);
            this.txtTenNhanVien.TabIndex = 3;
            // 
            // dtpNgayBan
            // 
            this.dtpNgayBan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBan.Location = new System.Drawing.Point(126, 96);
            this.dtpNgayBan.Name = "dtpNgayBan";
            this.dtpNgayBan.Size = new System.Drawing.Size(155, 20);
            this.dtpNgayBan.TabIndex = 1;
            this.dtpNgayBan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dtpNgayBan_KeyUp);
            // 
            // txtMaHDBan
            // 
            this.txtMaHDBan.Location = new System.Drawing.Point(126, 28);
            this.txtMaHDBan.Name = "txtMaHDBan";
            this.txtMaHDBan.ReadOnly = true;
            this.txtMaHDBan.Size = new System.Drawing.Size(155, 20);
            this.txtMaHDBan.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(650, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Điện thoại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(650, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Địa chỉ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(646, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(646, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Mã khách hàng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên nhân viên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ngày bán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHDBanHang);
            this.groupBox2.Controls.Add(this.panel4);
            this.groupBox2.Controls.Add(this.panel3);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1130, 341);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgvHDBanHang
            // 
            this.dgvHDBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDBanHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHDBanHang.Location = new System.Drawing.Point(3, 108);
            this.dgvHDBanHang.Name = "dgvHDBanHang";
            this.dgvHDBanHang.Size = new System.Drawing.Size(1124, 123);
            this.dgvHDBanHang.TabIndex = 1;
            this.dgvHDBanHang.DoubleClick += new System.EventHandler(this.dgvHDBanHang_DoubleClick);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtTongTien);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.lblBangChu);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 231);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1124, 51);
            this.panel4.TabIndex = 5;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(733, 7);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(160, 20);
            this.txtTongTien.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(650, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(52, 13);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tổng tiền";
            // 
            // lblBangChu
            // 
            this.lblBangChu.AutoSize = true;
            this.lblBangChu.ForeColor = System.Drawing.Color.Blue;
            this.lblBangChu.Location = new System.Drawing.Point(9, 24);
            this.lblBangChu.Name = "lblBangChu";
            this.lblBangChu.Size = new System.Drawing.Size(59, 13);
            this.lblBangChu.TabIndex = 1;
            this.lblBangChu.Text = "Bằng chữ: ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(9, 3);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nháy đúp một dòng để xóa";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtThanhTien);
            this.panel3.Controls.Add(this.txtGiamGia);
            this.panel3.Controls.Add(this.txtSoLuong);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.txtDonGiaBan);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.txtTenHang);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.cboMaHang);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1124, 92);
            this.panel3.TabIndex = 0;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Location = new System.Drawing.Point(851, 58);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(155, 20);
            this.txtThanhTien.TabIndex = 11;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Location = new System.Drawing.Point(532, 58);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(155, 20);
            this.txtGiamGia.TabIndex = 10;
            this.txtGiamGia.TextChanged += new System.EventHandler(this.txtGiamGia_TextChanged);
            this.txtGiamGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiamGia_KeyPress);
            this.txtGiamGia.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGiamGia_KeyUp);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(123, 58);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(155, 20);
            this.txtSoLuong.TabIndex = 9;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.txtSoLuong_TextChanged);
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            this.txtSoLuong.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyUp);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(764, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Thành tiền";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(447, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 7;
            this.label15.Text = "Giảm giá %";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(24, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Số lượng";
            // 
            // txtDonGiaBan
            // 
            this.txtDonGiaBan.Location = new System.Drawing.Point(851, 18);
            this.txtDonGiaBan.Name = "txtDonGiaBan";
            this.txtDonGiaBan.ReadOnly = true;
            this.txtDonGiaBan.Size = new System.Drawing.Size(155, 20);
            this.txtDonGiaBan.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(761, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Đơn giá";
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(532, 19);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.ReadOnly = true;
            this.txtTenHang.Size = new System.Drawing.Size(155, 20);
            this.txtTenHang.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(444, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Tên hàng";
            // 
            // cboMaHang
            // 
            this.cboMaHang.FormattingEnabled = true;
            this.cboMaHang.Location = new System.Drawing.Point(123, 18);
            this.cboMaHang.Name = "cboMaHang";
            this.cboMaHang.Size = new System.Drawing.Size(155, 21);
            this.cboMaHang.TabIndex = 1;
            this.cboMaHang.SelectedIndexChanged += new System.EventHandler(this.cboMaHang_SelectedIndexChanged);
            this.cboMaHang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMaHang_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1124, 56);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDong);
            this.panel5.Controls.Add(this.btnInHoaDon);
            this.panel5.Controls.Add(this.btnLuu);
            this.panel5.Controls.Add(this.btnXoa);
            this.panel5.Controls.Add(this.btnThem);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, -44);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1124, 100);
            this.panel5.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::QuanLyBanHang.Properties.Resources.closebutton;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(767, 44);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(101, 31);
            this.btnDong.TabIndex = 5;
            this.btnDong.Text = "&Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Image = global::QuanLyBanHang.Properties.Resources.Square44x44Logo_targetsize_24_altform_unplated;
            this.btnInHoaDon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInHoaDon.Location = new System.Drawing.Point(587, 44);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(118, 31);
            this.btnInHoaDon.TabIndex = 4;
            this.btnInHoaDon.Text = "&In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::QuanLyBanHang.Properties.Resources.saveicon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(201, 44);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(138, 31);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "&Lưu hóa đơn";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyBanHang.Properties.Resources.icon_delete_2x;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(399, 44);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(136, 31);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "&Hủy hóa đơn";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Image = global::QuanLyBanHang.Properties.Resources.add_row;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(30, 44);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(127, 31);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "&Thêm hóa đơn";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Image = global::QuanLyBanHang.Properties.Resources.findResults;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(488, 13);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(139, 35);
            this.btnTimKiem.TabIndex = 2;
            this.btnTimKiem.Text = "&Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 767);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHoaDonBan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn bán hàng";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDonBan_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDBanHang)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox cboMaHDBan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTenNhanVien;
        private System.Windows.Forms.DateTimePicker dtpNgayBan;
        public System.Windows.Forms.TextBox txtMaHDBan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtbDienThoai;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cboMaNhanVien;
        private System.Windows.Forms.ComboBox cboMaKhach;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cboMaHang;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtDonGiaBan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvHDBanHang;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblBangChu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}