
namespace QuanLyBanHang
{
    partial class frmDoanhThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoanhThu));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHoaDonBan = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabHangHoa = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabHoaDonBan.SuspendLayout();
            this.tabHangHoa.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(829, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHoaDonBan);
            this.tabControl1.Controls.Add(this.tabHangHoa);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(829, 458);
            this.tabControl1.TabIndex = 2;
            // 
            // tabHoaDonBan
            // 
            this.tabHoaDonBan.Controls.Add(this.reportViewer1);
            this.tabHoaDonBan.Location = new System.Drawing.Point(4, 22);
            this.tabHoaDonBan.Name = "tabHoaDonBan";
            this.tabHoaDonBan.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoaDonBan.Size = new System.Drawing.Size(821, 432);
            this.tabHoaDonBan.TabIndex = 0;
            this.tabHoaDonBan.Text = "Thống kê hóa đơn bán hàng";
            this.tabHoaDonBan.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(815, 426);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabHangHoa
            // 
            this.tabHangHoa.Controls.Add(this.reportViewer2);
            this.tabHangHoa.Location = new System.Drawing.Point(4, 22);
            this.tabHangHoa.Name = "tabHangHoa";
            this.tabHangHoa.Padding = new System.Windows.Forms.Padding(3);
            this.tabHangHoa.Size = new System.Drawing.Size(821, 432);
            this.tabHangHoa.TabIndex = 1;
            this.tabHangHoa.Text = "Thống kê hàng hóa";
            this.tabHangHoa.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(815, 426);
            this.reportViewer2.TabIndex = 0;
            // 
            // frmDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê doanh thu";
            this.Load += new System.EventHandler(this.frmDoanhThu_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabHoaDonBan.ResumeLayout(false);
            this.tabHangHoa.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHoaDonBan;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabHangHoa;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}