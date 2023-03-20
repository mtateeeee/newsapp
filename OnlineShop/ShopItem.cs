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
    public partial class ShopItem : UserControl
    {
        public ShopItem()
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

        private void ShopItem_Load(object sender, EventArgs e)
        {

        }

        private void ShopItem_Click(object sender, EventArgs e)
        {
            ItemInfo newform = new ItemInfo(this);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Buy_Click(object sender, EventArgs e)
        {
            if (MainMenu.ShoppingInfo.GlobalName.Contains(this.ItemName)==false)
            {
                MainMenu.ShoppingInfo.GlobalName.Add(this.ItemName);
                MainMenu.ShoppingInfo.GlobalPrice.Add(this.ItemPrice);
                MainMenu.ShoppingInfo.GlobalQuantity.Add(1);
            }
            else
            {
                int x = MainMenu.ShoppingInfo.GlobalName.IndexOf(this.ItemName);
                double old_price = Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[x].Replace(".", "").Replace(" VNĐ", ""));
                double new_price = (old_price / MainMenu.ShoppingInfo.GlobalQuantity[x]);
                MainMenu.ShoppingInfo.GlobalQuantity[x]++;
                new_price *= MainMenu.ShoppingInfo.GlobalQuantity[x];
                string final = string.Format("{0:N}", new_price).Replace(',', '.');
                MainMenu.ShoppingInfo.GlobalPrice[x] = final.Substring(0, final.Length - 3) + " VNĐ";
            }
            btn_Buy.Enabled = false;
        }

       
    }
}
