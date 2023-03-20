using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace OnlineShop
{
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        double OriPrice = 0;

        private void Cart_Load(object sender, EventArgs e)
        {
            if(MainMenu.ShoppingInfo.GlobalDiscount == 0)
            {
                btn_Apply.Enabled = true;
                txt_PromoCode.Enabled = true;
            }
            else
            {
                btn_Apply.Enabled = false;
                txt_PromoCode.Enabled = false;
            }
            btn_Cart.BackColor = Color.DeepPink;
            for (int i = 0; i < MainMenu.ShoppingInfo.GlobalName.Count; i++)
            {
                CartItem x = new CartItem();
                x.ItemImage = Image.FromFile(@"..\\..\\EarPhone\" + MainMenu.ShoppingInfo.GlobalName[i] + ".jpg");
                x.ItemName = MainMenu.ShoppingInfo.GlobalName[i];
                x.ItemPrice = MainMenu.ShoppingInfo.GlobalPrice[i];
                x.ItemQuantity = MainMenu.ShoppingInfo.GlobalQuantity[i].ToString();
                flowLayoutPanel.Controls.Add(x);
            }
            int q = MainMenu.ShoppingInfo.GlobalQuantity.Sum();
            if(q == 0)
            {
                btn_CheckOut.Enabled = false;
            }
            if(q <= 1)
            {
                lbl_Quantity.Text = q.ToString() + " item";
            }
            else
            {
                lbl_Quantity.Text = q.ToString() + " items";
            }
            
            for(int i=0; i<MainMenu.ShoppingInfo.GlobalPrice.Count; i++)
            {
               // OriPrice += Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[i].Replace(".", "").Replace(" VNĐ", ""));
            }
            MainMenu.ShoppingInfo.GlobalOriPrice = OriPrice;
            string FinalOriPrice = string.Format("{0:N}", OriPrice).Replace(',', '.');
            lbl_OriginalPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " VNĐ";
            if(OriPrice >= 2000000)
            {
                MainMenu.ShoppingInfo.GlobalDelivery = 0;
                lbl_Delivery.Text = "FREE";
            }
            else
            {
                double D = 10000 * q;
                MainMenu.ShoppingInfo.GlobalDelivery = D;
                string FinalD = string.Format("{0:N}", D).Replace(',', '.');
                lbl_Delivery.Text = FinalD.Substring(0, FinalD.Length - 3) + " VNĐ";
            }
            if (MainMenu.ShoppingInfo.GlobalDiscount != 0)
            {
                txt_PromoCode.Enabled = false;
                btn_Apply.Enabled = false;
            }
            lbl_Sale.Text = MainMenu.ShoppingInfo.GlobalDiscount.ToString() + "%";
            MainMenu.ShoppingInfo.GlobalTotalPrice = ((OriPrice + MainMenu.ShoppingInfo.GlobalDelivery) * (100 - MainMenu.ShoppingInfo.GlobalDiscount)) / 100;
            string total = string.Format("{0:N}", MainMenu.ShoppingInfo.GlobalTotalPrice).Replace(',', '.');
            lbl_Total.Text = total.Substring(0, total.Length - 3) + " VNĐ";
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            xmlDoc.Load(@"..\\..\\XML\PromoCode.xml");
            nodeList = xmlDoc.SelectNodes("/PromoCodes/PromoCode");
            int flag = 1;
            for(int i=0; i<nodeList.Count; i++)
            {
                if(txt_PromoCode.Text == nodeList[i].InnerText.Trim())
                {
                    if(txt_PromoCode.Text == "HaPeo")
                    {
                        MainMenu.ShoppingInfo.GlobalDiscount = 100;
                    }
                    else
                    {
                        MainMenu.ShoppingInfo.GlobalDiscount = 10;
                    }
                    lbl_Sale.Text = MainMenu.ShoppingInfo.GlobalDiscount.ToString() + "%";
                    MainMenu.ShoppingInfo.GlobalTotalPrice = ((MainMenu.ShoppingInfo.GlobalOriPrice + MainMenu.ShoppingInfo.GlobalDelivery) * (100 - MainMenu.ShoppingInfo.GlobalDiscount)) / 100;
                    string total = string.Format("{0:N}", MainMenu.ShoppingInfo.GlobalTotalPrice).Replace(',', '.');
                    lbl_Total.Text = total.Substring(0, total.Length - 3) + " VNĐ";
                    txt_PromoCode.Enabled = false;
                    btn_Apply.Enabled = false;
                    flag = 0;
                    break;
                }
            }
            if(flag == 1)
            {
                
            }
        }

        private void rjButton1_MouseMove(object sender, MouseEventArgs e)
        {
            ptr_CheckOut.BackColor = Color.FromArgb(229, 94, 161);
        }

        private void btn_CheckOut_MouseLeave(object sender, EventArgs e)
        {
            ptr_CheckOut.BackColor = Color.HotPink;
        }

        private void btn_CheckOut_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            using (CheckOut newform = new CheckOut())
            {
                if(newform.ShowDialog() == DialogResult.OK)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            this.Show();
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHistory newform = new OrderHistory();
            newform.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
