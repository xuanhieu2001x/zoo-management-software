
namespace ĐỒ_ÁN_CUỐI_KÌ_CSLT1
{
    partial class frmDangNhapNV
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
            this.labTaiKhoan = new System.Windows.Forms.Label();
            this.labMatKhau = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtTaiKhoan = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.btnQuayLai1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labTaiKhoan
            // 
            this.labTaiKhoan.AutoSize = true;
            this.labTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labTaiKhoan.Location = new System.Drawing.Point(15, 65);
            this.labTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labTaiKhoan.Name = "labTaiKhoan";
            this.labTaiKhoan.Size = new System.Drawing.Size(148, 32);
            this.labTaiKhoan.TabIndex = 0;
            this.labTaiKhoan.Text = "Tài khoản:";
            // 
            // labMatKhau
            // 
            this.labMatKhau.AutoSize = true;
            this.labMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labMatKhau.Location = new System.Drawing.Point(21, 142);
            this.labMatKhau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labMatKhau.Name = "labMatKhau";
            this.labMatKhau.Size = new System.Drawing.Size(144, 32);
            this.labMatKhau.TabIndex = 1;
            this.labMatKhau.Text = "Mật Khẩu:";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDangNhap.Location = new System.Drawing.Point(27, 224);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(189, 66);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtTaiKhoan.Location = new System.Drawing.Point(164, 61);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Size = new System.Drawing.Size(237, 39);
            this.txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtMatKhau.Location = new System.Drawing.Point(164, 139);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(237, 39);
            this.txtMatKhau.TabIndex = 4;
            // 
            // btnQuayLai1
            // 
            this.btnQuayLai1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuayLai1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnQuayLai1.Location = new System.Drawing.Point(237, 224);
            this.btnQuayLai1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuayLai1.Name = "btnQuayLai1";
            this.btnQuayLai1.Size = new System.Drawing.Size(164, 66);
            this.btnQuayLai1.TabIndex = 5;
            this.btnQuayLai1.Text = "Quay lại";
            this.btnQuayLai1.UseVisualStyleBackColor = true;
            this.btnQuayLai1.Click += new System.EventHandler(this.btnQuayLai1_Click);
            // 
            // frmDangNhapNV
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 351);
            this.Controls.Add(this.btnQuayLai1);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.labMatKhau);
            this.Controls.Add(this.labTaiKhoan);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmDangNhapNV";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập Nhân viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labTaiKhoan;
        private System.Windows.Forms.Label labMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.TextBox txtTaiKhoan;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button btnQuayLai1;
    }
}