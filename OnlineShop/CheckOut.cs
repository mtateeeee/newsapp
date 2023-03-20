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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        public static string code;

        private void btn_PlaceOrder_MouseMove(object sender, MouseEventArgs e)
        {
            ptr_PlaceOrder.BackColor = Color.FromArgb(229, 94, 161);
        }

        private void btn_PlaceOrder_MouseLeave(object sender, EventArgs e)
        {
            ptr_PlaceOrder.BackColor = Color.HotPink;
        }

        private string Trans(double x)
        {
            string Result = string.Format("{0:N}", x).Replace(',', '.');
            return Result.Substring(0, Result.Length - 3) + " VNĐ";
        }

        private void CheckOut_Load(object sender, EventArgs e)
        {
            btn_Cart.BackColor = Color.DeepPink;
            for (int i = 0; i < MainMenu.ShoppingInfo.GlobalName.Count; i++)
            {
                CheckOutItem x = new CheckOutItem();
                x.ItemImage = Image.FromFile(@"..\\..\\EarPhone\" + MainMenu.ShoppingInfo.GlobalName[i] + ".jpg");
                x.ItemName = MainMenu.ShoppingInfo.GlobalName[i];
                x.ItemPrice = MainMenu.ShoppingInfo.GlobalPrice[i];
                x.ItemQuantity = MainMenu.ShoppingInfo.GlobalQuantity[i].ToString();
                flowLayoutPanel.Controls.Add(x);
            }
            int q = MainMenu.ShoppingInfo.GlobalQuantity.Sum();
            if (q <= 1)
            {
                lbl_Quantity.Text = q.ToString() + " item";
            }
            else
            {
                lbl_Quantity.Text = q.ToString() + " items";
            }
            lbl_OriginalPrice.Text = Trans(MainMenu.ShoppingInfo.GlobalOriPrice);
            lbl_Sale.Text = MainMenu.ShoppingInfo.GlobalDiscount.ToString() + "%";
            if (MainMenu.ShoppingInfo.GlobalDelivery == 0)
            {
                lbl_Delivery.Text = "FREE";
            }
            else
            {
                lbl_Delivery.Text = Trans(MainMenu.ShoppingInfo.GlobalDelivery);
            }
            
            lbl_Total.Text = Trans(MainMenu.ShoppingInfo.GlobalTotalPrice);
        }

        public string CustomerEmail
        {
            get
            {
                return txt_Email.Text;
            }
        }

        public string CustomerFullName
        {
            get
            {
                return txt_FullName.Text;
            }
        }

        public string CustomerDeliveryAddress
        {
            get
            {
                return txt_DeliveryAddress.Text;
            }
        }

        public string CustomerPhoneNumber
        {
            get
            {
                return txt_PhoneNumber.Text;
            }
        }

        public string getOrderID
        {
            get
            {
                return code;
            }
        }

        private void btn_PlaceOrder_Click(object sender, EventArgs e)
        {
            code = "SKR";
            
            for (int i = 0; i < this.CustomerFullName.Length; i++)
            {
                if ((int)this.CustomerFullName[i] < 91)
                {
                    code += this.CustomerFullName[i];
                }
            }
            Random rd = new Random();
            int numb = rd.Next(100, 999);
            code += numb.ToString();
            code = code.Replace(" ", "");

            List<string> Name = new List<string>();
            MainMenu.ShoppingInfo.GlobalName.ForEach((item) => {
                Name.Add((string)item.Clone());
            });

            List<string> Price = new List<string>();
            MainMenu.ShoppingInfo.GlobalPrice.ForEach((item) => {
                Price.Add((string)item.Clone());
            });

            List<int> Quantity = new List<int>();
            MainMenu.ShoppingInfo.GlobalQuantity.ForEach((item) => {
                Quantity.Add(item);
            });

            ShoppingHistory h = new ShoppingHistory(Name, 
                                                    Price,
                                                    Quantity, 
                                                    MainMenu.ShoppingInfo.GlobalTotalPrice, 
                                                    code, 
                                                    this.CustomerFullName, 
                                                    this.CustomerPhoneNumber, 
                                                    this.CustomerEmail, 
                                                    this.CustomerDeliveryAddress, 
                                                    MainMenu.ShoppingInfo.GlobalOriPrice, 
                                                    MainMenu.ShoppingInfo.GlobalDelivery, 
                                                    MainMenu.ShoppingInfo.GlobalDiscount);
            MainMenu.History.Add(h);

            panel_ThankYou.Visible = true;
            panel_ThankYou.Dock = DockStyle.Fill;
            panel_ThankYou.BringToFront();
            btn_Shop.Visible = false;
            btn_History.Visible = false;
            btn_Cart.Visible = false;
            btn_Call.Visible = false;
            btn_Profile.Visible = false;


            this.Hide();
            ReportForm newform = new ReportForm(this);
            newform.ShowDialog();
            this.Show();
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_ContinueShopping_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public Image Modiptr_QR
        {
            set
            {
                ptr_QR.BackgroundImage = value;
            }
        }
    }
}
