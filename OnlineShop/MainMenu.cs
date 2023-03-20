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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            customizeDesing();
        }

        XmlDocument xmlDoc = new XmlDocument();
        XmlNodeList nodeList = null;
        string name = "";
        string price = "";
        bool isChecked = false;
        bool isCheckedPrice = false;

        public static List<ShoppingHistory> History = new List<ShoppingHistory>();

        private void MainMenu_Load(object sender, EventArgs e)
        {
            PhanQuyen();
            btn_Shop.BackColor = Color.DeepPink;
            txt_Search.Focus();
            xmlDoc.Load(@"..\\..\\XML\EarPhone.xml");
            nodeList = xmlDoc.SelectNodes("/Earphones" + "/Earphone");

            for(int i=0; i<nodeList.Count; i++)
            {
                name = nodeList[i].SelectSingleNode("Name").InnerText.Trim();
                price = nodeList[i].SelectSingleNode("Price").InnerText.Trim();
                ShopItem x = new ShopItem();
                x.ItemImage = Image.FromFile(@"..\\..\\EarPhone\" + name + ".jpg");
                x.ItemName = name;
                x.ItemPrice = price + " ";
                flowLayoutPanel.Controls.Add(x);
            }
            //for (int i = 0; i < nodeList.Count; i++)
            {
                name = nodeList[nodeList.Count-1].SelectSingleNode("Name").InnerText.Trim();
                price = nodeList[nodeList.Count-1].SelectSingleNode("Price").InnerText.Trim();
                ShopItem x = new ShopItem();
                x.ItemImage = Image.FromFile(@"..\\..\\EarPhone\" + name + ".jpg");
                x.ItemName = name;
                x.ItemPrice = price + " ";
                panel2.Controls.Add(x);
            }



        }

        public static class ShoppingInfo
        {
            private static List<string> Name = new List<string>();
            private static List<string> Price = new List<string>();
            private static List<int> Quantity = new List<int>();
            private static double OriPrice;
            private static double TotalPrice;
            private static double Delivery = 0;
            private static float Discount = 0;

            public static List<string> GlobalName
            {
                get
                {
                    return Name;
                }
                set
                {
                    Name.Add(value.ToString());
                }
            }

            public static List<string> GlobalPrice
            {
                get
                {
                    return Price;
                }
                set
                {
                    Price.Add(value.ToString());
                }
            }

            public static List<int> GlobalQuantity
            {
                get
                {
                    return Quantity;
                }
                set
                {
                    Quantity.Add(Int32.Parse(value.ToString()));
                }
            }

            public static double GlobalOriPrice
            {
                get
                {
                    return OriPrice;
                }
                set
                {
                    OriPrice = value;
                }
            }

            public static double GlobalTotalPrice
            {
                get
                {
                    return TotalPrice;
                }
                set
                {
                    TotalPrice = value;
                }
            }

            public static double GlobalDelivery
            {
                get
                {
                    return Delivery;
                }
                set
                {
                    Delivery = value;
                }
            }

            public static float GlobalDiscount
            {
                get
                {
                    return Discount;
                }
                set
                {
                    Discount = value;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Cart newform = new Cart();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void customizeDesing()
        {
            panel_ThuongHieu.Visible = false;
            panel_Price.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void btn_ThuongHieu_Click(object sender, EventArgs e)
        {
            showSubMenu(panel_ThuongHieu);
            if(panel_ThuongHieu.Visible == true)
            {
                ptr_Brand.BackgroundImage = Image.FromFile(@"..//..//Icon/downarrow.png");
            }
            else
            {
                ptr_Brand.BackgroundImage = Image.FromFile(@"..//..//Icon/rightarrow.png");
            }
        }

        private void ShowAll()
        {
            foreach (ShopItem x in flowLayoutPanel.Controls)
            {
                x.Visible = true;
            }
        }

        private void FilterRdbtn(string Name)
        {
            foreach (ShopItem x in flowLayoutPanel.Controls)
            {
                x.Visible = x.ItemName.ToLower().Contains(Name.ToLower());
            }
        }

        private void guna2RadioButton5_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbtn_SoundMAGIC.Checked && !isChecked)
                rdbtn_SoundMAGIC.Checked = false;
            else
            {
                rdbtn_SoundMAGIC.Checked = true;
                FilterRdbtn(rdbtn_SoundMAGIC.Text);
                isChecked = false;
            }
        }

        private void rdbtn_SoundMAGIC_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdbtn_SoundMAGIC.Checked;
            if (rdbtn_SoundMAGIC.Checked == false)
            {
                ShowAll();
            }
        }

        private void rdbtn_64Audio_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdbtn_64Audio.Checked;
            if (rdbtn_64Audio.Checked == false)
            {
                ShowAll();
            }
        }

        private void rdbtn_7Hz_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdbtn_7Hz.Checked;
            if (rdbtn_7Hz.Checked == false)
            {
                ShowAll();
            }
        }

        private void rdbtn_Sony_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdbtn_Sony.Checked;
            if (rdbtn_Sony.Checked == false)
            {
                ShowAll();
            }
        }

        private void rdbtn_HiFiMan_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = rdbtn_HiFiMan.Checked;
            if (rdbtn_HiFiMan.Checked == false)
            {
                ShowAll();
            }
        }

        private void rdbtn_64Audio_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbtn_64Audio.Checked && !isChecked)
                rdbtn_64Audio.Checked = false;
            else
            {
                rdbtn_64Audio.Checked = true;
                FilterRdbtn(rdbtn_64Audio.Text);
                isChecked = false;
            }
        }

        private void rdbtn_7Hz_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbtn_7Hz.Checked && !isChecked)
                rdbtn_7Hz.Checked = false;
            else
            {
                rdbtn_7Hz.Checked = true;
                FilterRdbtn(rdbtn_7Hz.Text);
                isChecked = false;
            }
        }

        private void rdbtn_Sony_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbtn_Sony.Checked && !isChecked)
                rdbtn_Sony.Checked = false;
            else
            {
                rdbtn_Sony.Checked = true;
                FilterRdbtn(rdbtn_Sony.Text);
                isChecked = false;
            }
        }

        private void rdbtn_HiFiMan_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdbtn_HiFiMan.Checked && !isChecked)
                rdbtn_HiFiMan.Checked = false;
            else
            {
                rdbtn_HiFiMan.Checked = true;
                FilterRdbtn(rdbtn_HiFiMan.Text);
                isChecked = false;
            }
        }

        private void btn_ThuongHieu_MouseMove(object sender, MouseEventArgs e)
        {
            ptr_Brand.BackColor = Color.FromArgb(229, 115, 115);
        }

        private void btn_ThuongHieu_MouseLeave(object sender, EventArgs e)
        {
            ptr_Brand.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void btn_Price_MouseMove(object sender, MouseEventArgs e)
        {
            ptr_Price.BackColor = Color.FromArgb(229, 115, 115);
        }

        private void btn_Price_MouseLeave(object sender, EventArgs e)
        {
            ptr_Price.BackColor = Color.FromArgb(255, 128, 128);
        }

        

        public double Price(string x)
        {
            return Convert.ToDouble(x.Replace(".", "").Replace(" ", ""));
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter || txt_Search.Text.Length == 0)
            {
                rdbtn_All.Checked = true;
                foreach(ShopItem item in flowLayoutPanel.Controls)
                {
                    item.Visible = item.ItemName.ToLower().Contains(txt_Search.Text.ToLower());
                }
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Cart newform = new Cart();
            this.Hide();
            newform.ShowDialog();
            this.Show();
        }

        private void btn_History_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderHistory newform = new OrderHistory();
            newform.ShowDialog();
            this.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            string f = "C:/Users/Administrator/Downloads/OnlineShop/OnlineShop/OnlineShop/EarPhone/y2meta.com-At least 29 killed during arrest of El Chapo's son in Mexico - BBC News-(480p).mp4";
            axWindowsMediaPlayer1.URL = f;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        void PhanQuyen()
        {
            if (Cont.LoaiTaiKhoan == false)
            {
                rjButton2.Enabled = false;
            }
        }
        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click_1(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AddNews f = new AddNews();
            f.Show();
            this.Hide();
        }

        private void ptr_Price_Click(object sender, EventArgs e)
        {

        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            AddNews f = new AddNews();
            f.Show();
            this.Hide();
        }
    }
}
