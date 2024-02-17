using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;

namespace ĐỒ_ÁN_CUỐI_KÌ_CSLT1
{
    public partial class frmNhanVien : Form
    {
        private string _name, _role;
        public frmNhanVien()
        {
            InitializeComponent();
        }
        public frmNhanVien(string name, string role)
        {
            InitializeComponent();
            this._name = name;
            this._role = role;
            lbTenNV.Text = this._name + "[" + this._role + "]";

        }

        public List<ThuModel> thuModels = new List<ThuModel>();

        //In + Lưu thông tin vé
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //In vé
            DialogResult dialogResult = MessageBox.Show("Ban co chac in khong", "Thong Bao", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                decimal tong = nudAdult.Value * 50000 + nudChildren.Value * 40000 + nudCombo.Value * 130000;
                lbTicket.Text = "Số vé người lớn " + nudAdult.Value.ToString() + " vé\n\n" + "Số vé trẻ em " + nudChildren.Value.ToString() + " vé\n\n"
                   + "Số vé combo " + nudCombo.Value.ToString() + " vé\n\n" + "Tổng tiền " + string.Format("{0:#,0}", tong) + " VNĐ";
                lbTongTien.Text = string.Format("{0:#,0}", tong);
                string s = lbTicket.Text;

                PrintDocument p = new PrintDocument();
                p.PrintPage += delegate (object sender1, PrintPageEventArgs e1)
                {
                    e1.Graphics.DrawString(s, new Font("Times New Roman", 12), new SolidBrush(Color.Black), new RectangleF(0, 0, p.DefaultPageSettings.PrintableArea.Width, p.DefaultPageSettings.PrintableArea.Height));

                };
                try
                {
                    p.Print();
                }
                catch (Exception ex)
                {
                    throw new Exception("Exception Occured While Printing", ex);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
            }

            //Lưu thông tin
            ListViewItem itemTicket = new System.Windows.Forms.ListViewItem(new string[]
                {nudAdult.Value.ToString(),nudChildren.Value.ToString(),nudCombo.Value.ToString(),dtpNgayBan.Text,lbTongTien.Text});
            lvTicket.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemTicket });

            //Trả về form cũ
            nudAdult.Value = 0;
            nudChildren.Value = 0;
            nudCombo.Value = 0;
            dtpNgayBan.Value = DateTime.Now;
        }

        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            int sh = s.Height - 50;
            int sw = s.Width;
            bitmap = new Bitmap(sw, sh, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        //Xóa form báo cáo thú
        public void XoaTPDaily()
        {
            dtpDaily.Value = DateTime.Now;
            cbxThu.Text = "";
            rdbtnDrinkLittle.Checked = false;
            rdbtnDrinkOK.Checked = false;
            rdbtnFoodDu.Checked = false;
            rdbtnFoodOK.Checked = false;
            rdbtnHealthNotOK.Checked = false;
            rdbtnHealthOK.Checked = false;
            rdbtnHungry.Checked = false;
            txtNotOK.Text = "";
        }

        //Lưu dữ liệu quản lý thú hằng ngày
        private void btnSave_Click(object sender, EventArgs e)
        {
            ThuModel thuModel = new ThuModel();

            //Gọi tên thú
            if (cbxThu.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thú", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Lấy dữ liệu radiobutton về thức ăn
            string Foodvalue = "";
            foreach (Control a in this.grbFood.Controls)
            {
                if (a is RadioButton)
                {
                    RadioButton b = (RadioButton)a;
                    if (b.Checked)
                    {
                        Foodvalue = b.Text;
                    }
                }
            }

            //Lấy dữ liệu checkbox về nước uống
            string Drinkvalue = "";
            foreach (Control a in this.grbDrink.Controls)
            {
                if (a is RadioButton)
                {
                    RadioButton b = (RadioButton)a;
                    if (b.Checked)
                    {
                        Drinkvalue = b.Text;
                    }
                }
            }

            //Lấy dữ liệu checkbox về sức khỏe
            string Healthvalue = "";
            if (rdbtnHealthOK.Checked == true)
            {
                Healthvalue = rdbtnHealthOK.Text;
            }
            if (rdbtnHealthNotOK.Checked == true)
            {
                if (txtNotOK.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập rõ thông tin sức khỏe bất thường của thú", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtNotOK.Text != "")
                {
                    Healthvalue = "BẤT THƯỜNG - " + txtNotOK.Text;
                }
            }

            //Khai báo biến "itemAnimalDaily"
            //Truyền lần lượt các tham số theo thứ tự vào ListView
            thuModel.TenThu = cbxThu.Text;
            thuModel.Ngay = dtpDaily.Text;
            thuModel.ThucAn = Foodvalue;
            thuModel.NuocUong = Drinkvalue;
            thuModel.SucKhoe = Healthvalue;
            thuModels.Add(thuModel);
            ListViewItem itemAnimalDaily = new System.Windows.Forms.ListViewItem(new string[]
            {cbxThu.Text,dtpDaily.Text,Foodvalue,Drinkvalue,Healthvalue});

            //Thêm đối tượng vào ListView
            lvAnimal.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemAnimalDaily });

            //Xóa form sau khi add
            XoaTPDaily();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<ThuModel> lst = new List<ThuModel>(); 
            lvAnimal.Items.Clear();
            if(txtSearchBox.Text != "")
            {
                lst = thuModels.Where(s => s.TenThu.Contains(txtSearchBox.Text) || s.ThucAn.Contains(txtSearchBox.Text) || s.NuocUong.Contains(txtSearchBox.Text) || s.SucKhoe.Contains(txtSearchBox.Text)).ToList();
            }
            else
            {
                lst = thuModels;
            }
            if (ckSearchByDate.Checked == true)
            {
                lst = thuModels.Where(s => s.Ngay.Contains(dtpDate.Text)).ToList();
            }
            int count = lst.Count;
            for (int i = 0; i < count; i++)
            {
                ListViewItem itemAnimalDaily = new System.Windows.Forms.ListViewItem(new string[]
           {lst[i].TenThu,lst[i].Ngay, lst[i].ThucAn,lst[i].NuocUong,lst[i].SucKhoe});
                //Thêm đối tượng vào ListView
                lvAnimal.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemAnimalDaily });
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            int count = thuModels.Count;
            for (int i = 0; i < count; i++)
            {
                ListViewItem itemAnimalDaily = new System.Windows.Forms.ListViewItem(new string[]
           {thuModels[i].TenThu,thuModels[i].Ngay, thuModels[i].ThucAn,thuModels[i].NuocUong,thuModels[i].SucKhoe});
                //Thêm đối tượng vào ListView
                lvAnimal.Items.AddRange(new System.Windows.Forms.ListViewItem[] { itemAnimalDaily });
            }
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            //Thống kê tổng số vé người lớn
            double SumAdult = 0;
            foreach (ListViewItem Adult in lvTicket.Items)
            {
                double Adults = Convert.ToDouble(Adult.SubItems[0].Text);
                SumAdult = SumAdult + Adults;
            }
            lbAdultsTotal.Text = "Tổng số vé người lớn là " + SumAdult.ToString();

            //Thống kê tổng số vé trẻ em
            double SumChildren = 0;
            foreach (ListViewItem Children in lvTicket.Items)
            {
                double Childrens = Convert.ToDouble(Children.SubItems[1].Text);
                SumChildren = SumChildren + Childrens;
            }
            lbChildrenTotal.Text = "Tổng số vé trẻ em là " + SumChildren.ToString();

            //Thống kê tổng số vé combo
            double SumCombo = 0;
            foreach (ListViewItem Combo in lvTicket.Items)
            {
                double Combos = Convert.ToDouble(Combo.SubItems[2].Text);
                SumCombo = SumCombo + Combos;
            }
            lbComboTotal.Text = "Tổng số vé combo là " + SumCombo.ToString();

            //Thống kê tổng số tiền
            decimal SumMoney = 0;
            foreach (ListViewItem Money in lvTicket.Items)
            {
                decimal Moneys = Convert.ToDecimal(Money.SubItems[4].Text);
                SumMoney = SumMoney + Moneys;
            }
            lbMoneyTotal.Text = "Tổng thành tiền bán vé là " + string.Format("{0:#,0}", SumMoney);
        }

		private void TPTicket_Click(object sender, EventArgs e)
		{

		}

		private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dtpDate.Text = "";
        }


    }
}
public class ThuModel
{
    public string TenThu { get; set; }
    public string Ngay { get; set; }
    public string ThucAn { get; set; }
    public string NuocUong { get; set; }
    public string SucKhoe { get; set; }
}
