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
    public partial class frmMap : Form
    {
        public frmMap()
        {
            InitializeComponent();
        }

        private void btnChim_Click(object sender, EventArgs e)
        {
            frmChim frm = new frmChim();
            frm.ShowDialog();

        }

        private void btnThu_Click(object sender, EventArgs e)
        {
            frmThu frm = new frmThu();
            frm.ShowDialog();
        }

        private void btnThuyCung_Click(object sender, EventArgs e)
        {
            frmThuyCung frm = new frmThuyCung();
            frm.ShowDialog();
        }

        private void btnConTrung_Click(object sender, EventArgs e)
        {
            frmConTrung frm = new frmConTrung();
            frm.ShowDialog();
        }

        private void btnBoSat_Click(object sender, EventArgs e)
        {
            frmBoSat frm = new frmBoSat();
            frm.ShowDialog();
        }

        

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            frmDangNhapNV frm = new frmDangNhapNV();
            frm.ShowDialog();
            this.Hide();
            
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lbNgay.Text = dt.ToString("dd");
            lbThang.Text = dt.ToString("MM");
            lbNam.Text = dt.ToString("yyyy");
            lbGiay.Text = dt.ToString("ss");
            lbPhut.Text = dt.ToString("mm");
            lbGio.Text = dt.ToString("hh");
            timerClock.Start();
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(lbGiay.Text);
            int b = Int32.Parse(lbPhut.Text);
            int c = Int32.Parse(lbGio.Text);
            //chạy giờ:
            a++;
            if (a > 59)
            {
                a = 0;
                b++;
            }
            if(b>59)
            {
                b = 0;
                c++;
            }    
            if(c>23)
            {
                c = 0;
            }    
            if (a < 10)
                lbGiay.Text = "0" + a;
            else
                lbGiay.Text = a + "";
            if (b < 10)
                lbPhut.Text = "0" + b;
            else
                lbPhut.Text = b + "";
            if(c<10)
                lbGio.Text = "0" + c;
            else
                lbGio.Text = c + "";
        }

       
    }
}
