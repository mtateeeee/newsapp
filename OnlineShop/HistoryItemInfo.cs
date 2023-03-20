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
    public partial class HistoryItemInfo : Form
    {
        HistoryItem item = new HistoryItem();
        public HistoryItemInfo(HistoryItem x)
        {
            InitializeComponent();
            item = x;
        }

        private void HistoryItemInfo_Load(object sender, EventArgs e)
        {
            int x = 0;
            for(int i=0; i<MainMenu.History.Count; i++)
            {
                if(MainMenu.History[i].HistoryCode == item.HistoryOrderID)
                {
                    x = i;
                    break;
                }
            }
            lbl_OrderID.Text = MainMenu.History[x].HistoryCode;
            lbl_CustomerName.Text = MainMenu.History[x].HistoryCustomerName;
            lbl_PhoneNumber.Text = MainMenu.History[x].HistoryPhoneNumber;
            lbl_Email.Text = MainMenu.History[x].HistoryEmail;
            lbl_DeliveryAddress.Text = MainMenu.History[x].HistoryShippingAddress;

            for(int i=0; i<MainMenu.History[x].HistoryName.Count; i++)
            {
                OrderItem oi = new OrderItem();
                oi.OrderItemImage = Image.FromFile(@"..\\..\\EarPhone\" + MainMenu.History[x].HistoryName[i] + ".jpg");
                oi.OrderItemName = MainMenu.History[x].HistoryName[i];
                oi.OrderItemQuantity = MainMenu.History[x].HistoryQuantity[i].ToString();
                oi.OrderItemPrice = MainMenu.History[x].HistoryPrice[i];
                flowLayoutPanel.Controls.Add(oi);
            }

            int q = MainMenu.History[x].HistoryQuantity.Sum();
            if (q <= 1)
            {
                lbl_Quantity.Text = q.ToString() + " item";
            }
            else
            {
                lbl_Quantity.Text = q.ToString() + " items";
            }

            string FinalOriPrice = string.Format("{0:N}", MainMenu.History[x].HistoryOriPrice).Replace(',', '.');
            lbl_OriginalPrice.Text = FinalOriPrice.Substring(0, FinalOriPrice.Length - 3) + " VNĐ";

            lbl_Sale.Text = MainMenu.History[x].HistoryDiscount.ToString() + "%";

            if(MainMenu.History[x].HistoryDelivery == 0)
            {
                lbl_Delivery.Text = "FREE";
            }
            else
            {
                string FinalD = string.Format("{0:N}", MainMenu.History[x].HistoryDelivery).Replace(',', '.');
                lbl_Delivery.Text = FinalD.Substring(0, FinalD.Length - 3) + " VNĐ";
            }

            string total = string.Format("{0:N}", MainMenu.History[x].HistoryTotalPrice).Replace(',', '.');
            lbl_Total.Text = total.Substring(0, total.Length - 3) + " VNĐ";
        }
    }
}
