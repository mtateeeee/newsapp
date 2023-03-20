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
    public partial class OrderItem : UserControl
    {
        public OrderItem()
        {
            InitializeComponent();
        }

        public Image OrderItemImage
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

        public string OrderItemName
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

        public string OrderItemPrice
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

        public string OrderItemQuantity
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
    }
}
