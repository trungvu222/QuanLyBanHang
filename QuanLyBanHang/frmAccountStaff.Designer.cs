
namespace QuanLyBanHang
{
    partial class frmAccountStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountStaff));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cboAccountType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnShowAccount = new System.Windows.Forms.Button();
            this.btnEditAccount = new System.Windows.Forms.Button();
            this.btnDeleteAccount = new System.Windows.Forms.Button();
            this.btnAddAccount = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAccount);
            this.panel1.Location = new System.Drawing.Point(2, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(454, 422);
            this.panel1.TabIndex = 0;
            // 
            // dgvAccount
            // 
            this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(3, 3);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(448, 416);
            this.dgvAccount.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.btnResetPassword);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(462, 90);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 422);
            this.panel2.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtEmail);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(3, 141);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(313, 63);
            this.panel7.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Email:";
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Location = new System.Drawing.Point(168, 279);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(148, 59);
            this.btnResetPassword.TabIndex = 6;
            this.btnResetPassword.Text = "Đặt lại mật khẩu ";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.cboAccountType);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(3, 210);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(313, 63);
            this.panel6.TabIndex = 5;
            // 
            // cboAccountType
            // 
            this.cboAccountType.FormattingEnabled = true;
            this.cboAccountType.Location = new System.Drawing.Point(123, 23);
            this.cboAccountType.Name = "cboAccountType";
            this.cboAccountType.Size = new System.Drawing.Size(187, 21);
            this.cboAccountType.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại tài khoản";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtDisplayName);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(3, 72);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(313, 63);
            this.panel5.TabIndex = 4;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(123, 25);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(187, 20);
            this.txtDisplayName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hiển thị:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtUserName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(313, 63);
            this.panel4.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(123, 24);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(187, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnShowAccount);
            this.panel3.Controls.Add(this.btnEditAccount);
            this.panel3.Controls.Add(this.btnDeleteAccount);
            this.panel3.Controls.Add(this.btnAddAccount);
            this.panel3.Location = new System.Drawing.Point(2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 83);
            this.panel3.TabIndex = 2;
            // 
            // btnShowAccount
            // 
            this.btnShowAccount.Location = new System.Drawing.Point(331, 3);
            this.btnShowAccount.Name = "btnShowAccount";
            this.btnShowAccount.Size = new System.Drawing.Size(94, 77);
            this.btnShowAccount.TabIndex = 3;
            this.btnShowAccount.Text = "Xem";
            this.btnShowAccount.UseVisualStyleBackColor = true;
            this.btnShowAccount.Click += new System.EventHandler(this.btnShowAccount_Click);
            // 
            // btnEditAccount
            // 
            this.btnEditAccount.Location = new System.Drawing.Point(232, 3);
            this.btnEditAccount.Name = "btnEditAccount";
            this.btnEditAccount.Size = new System.Drawing.Size(93, 77);
            this.btnEditAccount.TabIndex = 2;
            this.btnEditAccount.Text = "Sửa";
            this.btnEditAccount.UseVisualStyleBackColor = true;
            this.btnEditAccount.Click += new System.EventHandler(this.btnEditAccount_Click);
            // 
            // btnDeleteAccount
            // 
            this.btnDeleteAccount.Location = new System.Drawing.Point(132, 3);
            this.btnDeleteAccount.Name = "btnDeleteAccount";
            this.btnDeleteAccount.Size = new System.Drawing.Size(94, 77);
            this.btnDeleteAccount.TabIndex = 1;
            this.btnDeleteAccount.Text = "Xóa";
            this.btnDeleteAccount.UseVisualStyleBackColor = true;
            this.btnDeleteAccount.Click += new System.EventHandler(this.btnDeleteAccount_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Location = new System.Drawing.Point(30, 3);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Size = new System.Drawing.Size(96, 77);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Thêm";
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 514);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(783, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // frmAccountStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 536);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAccountStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.frmAccountStaff_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Button btnShowAccount;
        private System.Windows.Forms.Button btnEditAccount;
        private System.Windows.Forms.Button btnDeleteAccount;
        private System.Windows.Forms.Button btnAddAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cboAccountType;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}