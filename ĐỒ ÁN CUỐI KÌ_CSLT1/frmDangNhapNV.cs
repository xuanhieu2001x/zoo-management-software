using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ĐỒ_ÁN_CUỐI_KÌ_CSLT1
{
    public partial class frmDangNhapNV : Form
    {
        public frmDangNhapNV()
        {
            InitializeComponent();
        }
        

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "admin")
            {
                if (txtMatKhau.Text == "1234")
                {
                    string name = "banana";
                    string role = "quản lí";
                    frmNhanVien frm1 = new frmNhanVien(name,role);
                    frm1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Mật khẩu không chính xác");
                }
            } 
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
            }    
                
        }

        private void btnQuayLai1_Click(object sender, EventArgs e)
        {
            frmMap frm = new frmMap();
            frm.Show();
            this.Hide();

        }
    }
}
