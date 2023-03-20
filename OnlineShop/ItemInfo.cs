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
    public partial class ItemInfo : Form
    {
        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        ShopItem X;
        public ItemInfo(ShopItem item)
        {
            InitializeComponent();
            X = item;
            
            ptr_Item.BackgroundImage = Image.FromFile(@"..\\..\\EarPhone\" + item.ItemName + ".jpg");
            xmlDoc.Load(@"..\\..\\XML\EarPhone.xml");
            nodeList = xmlDoc.SelectNodes("/Earphones" + "/Earphone");
            int i = 0;
            while(i < nodeList.Count)
            {
                if (item.ItemName == nodeList[i].SelectSingleNode("Name").InnerText.Trim())
                {
                    break;
                }
                i++;
            }

            lbl_Name.Text = item.ItemName;
            lbl_Price.Text = item.ItemPrice;
            lbl_Feature.Text = nodeList[i].SelectSingleNode("Feature").InnerText.Trim();
            lbl_Brand.Text = item.ItemName.Substring(0, item.ItemName.IndexOf(""));
        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < MainMenu.ShoppingInfo.GlobalPrice.Count; i++)
                lbl_Test3.Text += MainMenu.ShoppingInfo.GlobalPrice[i] + "\n\n";*/
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cart newform = new Cart();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_AddToCart_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void ItemInfo_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void rjButton1_MouseMove(object sender, MouseEventArgs e)
        {
            ptr_AddToCart.BackColor = Color.FromArgb(229, 120, 170);
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (MainMenu.ShoppingInfo.GlobalName.Contains(X.ItemName) == false)
            {
                MainMenu.ShoppingInfo.GlobalName.Add(X.ItemName);
                MainMenu.ShoppingInfo.GlobalPrice.Add(X.ItemPrice);
                MainMenu.ShoppingInfo.GlobalQuantity.Add(1);


            }
            else
            {
                int x = MainMenu.ShoppingInfo.GlobalName.IndexOf(X.ItemName);
                double old_price = Convert.ToDouble(MainMenu.ShoppingInfo.GlobalPrice[x].Replace(".", "").Replace(" VNĐ", ""));
                double new_price = (old_price / MainMenu.ShoppingInfo.GlobalQuantity[x]);
                MainMenu.ShoppingInfo.GlobalQuantity[x]++;
                new_price *= MainMenu.ShoppingInfo.GlobalQuantity[x];
                string final = string.Format("{0:N}", new_price).Replace(',', '.');
                MainMenu.ShoppingInfo.GlobalPrice[x] = final.Substring(0, final.Length - 3) + " VNĐ";
            }
        }

        private void btn_AddToCart_MouseLeave(object sender, EventArgs e)
        {
            ptr_AddToCart.BackColor = Color.FromArgb(255, 134, 189);
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            int q = Convert.ToInt32(lbl_Quantity.Text);
            q++;
            ItemInfo newform = (ItemInfo)this.Parent.Parent;
            newform.lbl_Quantity.Text = q.ToString();
        }

        private void lb_Click(object sender, EventArgs e)
        {

        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
             label12.Text= textBox1.Text;
            label12.Visible = true;
            rjButton2.Visible = true;
        }
    }
}
