using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShop
{
    public partial class CartItem : UserControl
    {
        public CartItem()
        {
            InitializeComponent();
        }

        public Image ItemImage
        {
            get
            {
                return ptr_Item.Image;
            }
            set
            {
                ptr_Item.BackgroundImage = value;
            }
        }

        public string ItemName
        {
            get
            {
                return lbl_Name.Text;
            }
            set
            {
                lbl_Name.Text = value;
            }
        }

        public string ItemPrice
        {
            get
            {
                return lbl_Price.Text;
            }
            set
            {
                lbl_Price.Text = value;
            }
        }

        public string ItemQuantity
        {
            get
            {
                return lbl_Quantity.Text;
            }
            set
            {
                lbl_Quantity.Text = value;
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            int x = MainMenu.ShoppingInfo.GlobalName.IndexOf(this.ItemName);
            double old_price = Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[x].Replace(".", "").Replace(" VNĐ", ""));
            double new_price = (old_price / MainMenu.ShoppingInfo.GlobalQuantity[x]);
            MainMenu.ShoppingInfo.GlobalQuantity[x]++;
            new_price *= MainMenu.ShoppingInfo.GlobalQuantity[x];
            string final = string.Format("{0:N}", new_price).Replace(',', '.');
            MainMenu.ShoppingInfo.GlobalPrice[x] = final.Substring(0, final.Length - 3) + " VNĐ";
            lbl_Price.Text = MainMenu.ShoppingInfo.GlobalPrice[x];
            lbl_Quantity.Text = MainMenu.ShoppingInfo.GlobalQuantity[x].ToString();
            int q = MainMenu.ShoppingInfo.GlobalQuantity.Sum();
            Cart newform = (Cart)this.Parent.Parent;
            if (q <= 1)
            {
                newform.lbl_Quantity.Text = q.ToString() + " item";
            }
            else
            {
                newform.lbl_Quantity.Text = q.ToString() + " items";
            }
            double OriPrice = 0;
            for (int i = 0; i < MainMenu.ShoppingInfo.GlobalPrice.Count; i++)
            {
                OriPrice += Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[i].Replace(".", "").Replace(" VNĐ", ""));
            }
            MainMenu.ShoppingInfo.GlobalOriPrice = OriPrice;
            string FinalOriPrice = string.Format("{0:N}", OriPrice).Replace(',', '.');
            newform.lbl_OriginalPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " VNĐ";
            if (OriPrice >= 2000000)
            {
                MainMenu.ShoppingInfo.GlobalDelivery = 0;
                newform.lbl_Delivery.Text = "FREE";
            }
            else
            {
                double D = 10000 * q;
                MainMenu.ShoppingInfo.GlobalDelivery = D;
                string FinalD = string.Format("{0:N}", D).Replace(',', '.');
                newform.lbl_Delivery.Text = FinalD.Substring(0, FinalD.Length - 3) + " VNĐ";
            }
            MainMenu.ShoppingInfo.GlobalTotalPrice = ((MainMenu.ShoppingInfo.GlobalOriPrice + MainMenu.ShoppingInfo.GlobalDelivery) * (100 - MainMenu.ShoppingInfo.GlobalDiscount)) / 100;
            string total = string.Format("{0:N}", MainMenu.ShoppingInfo.GlobalTotalPrice).Replace(',', '.');
            newform.lbl_Total.Text = total.Substring(0, total.Length - 3) + " VNĐ";
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            int x = MainMenu.ShoppingInfo.GlobalName.IndexOf(this.ItemName);
            if (MainMenu.ShoppingInfo.GlobalQuantity[x] > 1)
            {
                double old_price = Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[x].Replace(".", "").Replace(" VNĐ", ""));
                double new_price = (old_price / MainMenu.ShoppingInfo.GlobalQuantity[x]);
                MainMenu.ShoppingInfo.GlobalQuantity[x]--;
                new_price *= MainMenu.ShoppingInfo.GlobalQuantity[x];
                string final = string.Format("{0:N}", new_price).Replace(',', '.');
                MainMenu.ShoppingInfo.GlobalPrice[x] = final.Substring(0, final.Length - 3) + " VNĐ";
                lbl_Price.Text = MainMenu.ShoppingInfo.GlobalPrice[x];
                lbl_Quantity.Text = MainMenu.ShoppingInfo.GlobalQuantity[x].ToString();
                Cart newform = (Cart)this.Parent.Parent;
                int q = MainMenu.ShoppingInfo.GlobalQuantity.Sum();
                if (q <= 1)
                {
                    newform.lbl_Quantity.Text = q.ToString() + " item";
                }
                else
                {
                    newform.lbl_Quantity.Text = q.ToString() + " items";
                }
                double OriPrice = 0;
                for (int i = 0; i < MainMenu.ShoppingInfo.GlobalPrice.Count; i++)
                {
                    OriPrice += Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[i].Replace(".", "").Replace(" VNĐ", ""));
                }
                MainMenu.ShoppingInfo.GlobalOriPrice = OriPrice;
                string FinalOriPrice = string.Format("{0:N}", OriPrice).Replace(',', '.');
                newform.lbl_OriginalPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " VNĐ";
                if (OriPrice >= 2000000)
                {
                    MainMenu.ShoppingInfo.GlobalDelivery = 0;
                    newform.lbl_Delivery.Text = "FREE";
                }
                else
                {
                    double D = 10000 * q;
                    MainMenu.ShoppingInfo.GlobalDelivery = D;
                    string FinalD = string.Format("{0:N}", D).Replace(',', '.');
                    newform.lbl_Delivery.Text = FinalD.Substring(0, FinalD.Length - 3) + " VNĐ";
                }
                MainMenu.ShoppingInfo.GlobalTotalPrice = ((MainMenu.ShoppingInfo.GlobalOriPrice + MainMenu.ShoppingInfo.GlobalDelivery) * (100 - MainMenu.ShoppingInfo.GlobalDiscount)) / 100;
                string total = string.Format("{0:N}", MainMenu.ShoppingInfo.GlobalTotalPrice).Replace(',', '.');
                newform.lbl_Total.Text = total.Substring(0, total.Length - 3) + " VNĐ";
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            int x = MainMenu.ShoppingInfo.GlobalName.IndexOf(this.ItemName);
            MainMenu.ShoppingInfo.GlobalName.RemoveAt(x);
            MainMenu.ShoppingInfo.GlobalPrice.RemoveAt(x);
            MainMenu.ShoppingInfo.GlobalQuantity.RemoveAt(x);
            int q = MainMenu.ShoppingInfo.GlobalQuantity.Sum();
            Cart newform = (Cart)this.Parent.Parent;
            if (q == 0)
            {
                newform.btn_CheckOut.Enabled = false;
            }
            if (q <= 1)
            {
                newform.lbl_Quantity.Text = q.ToString() + " item";
            }
            else
            {
                newform.lbl_Quantity.Text = q.ToString() + " items";
            }
            double OriPrice = 0;
            for (int i = 0; i < MainMenu.ShoppingInfo.GlobalPrice.Count; i++)
            {
                //OriPrice += Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[i].Replace(".", "").Replace(" VNĐ", ""));
            }
            MainMenu.ShoppingInfo.GlobalOriPrice = OriPrice;
            string FinalOriPrice = string.Format("{0:N}", OriPrice).Replace(',', '.');
            newform.lbl_OriginalPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " VNĐ";
            if (OriPrice >= 2000000)
            {
                MainMenu.ShoppingInfo.GlobalDelivery = 0;
                newform.lbl_Delivery.Text = "FREE";
            }
            else if(OriPrice == 0)
            {
                MainMenu.ShoppingInfo.GlobalDelivery = 0;
                newform.lbl_Delivery.Text = "-";
            }
            else
            {
                double D = 10000 * q;
                MainMenu.ShoppingInfo.GlobalDelivery = D;
                string FinalD = string.Format("{0:N}", D).Replace(',', '.');
                newform.lbl_Delivery.Text = FinalD.Substring(0, FinalD.Length - 3) + " VNĐ";
            }
            MainMenu.ShoppingInfo.GlobalTotalPrice = ((MainMenu.ShoppingInfo.GlobalOriPrice + MainMenu.ShoppingInfo.GlobalDelivery) * (100 - MainMenu.ShoppingInfo.GlobalDiscount)) / 100;
            string total = string.Format("{0:N}", MainMenu.ShoppingInfo.GlobalTotalPrice).Replace(',', '.');
            newform.lbl_Total.Text = total.Substring(0, total.Length - 3) + " VNĐ";
            this.Parent.Controls.Remove(this);
        }

        private void CartItem_MouseClick(object sender, MouseEventArgs e)
        {
            ShopItem X = new ShopItem();
            X.ItemName = this.ItemName;
            X.ItemPrice = this.ItemPrice;
            ItemInfo newform = new ItemInfo(X);
            newform.btn_AddToCart.Visible = false;
            newform.ptr_AddToCart.Visible = false;
            newform.ShowDialog();
            this.Show();
        }
    }
}
