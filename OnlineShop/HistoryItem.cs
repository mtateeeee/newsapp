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
    public partial class HistoryItem : UserControl
    {
        public HistoryItem()
        {
            InitializeComponent();
        }

        public string HistoryOrderID
        {
            get
            {
                return lbl_OrderID.Text;
            }
            set
            {
                lbl_OrderID.Text = value;
            }
        }

        public string HistoryCustomerName
        {
            get
            {
                return lbl_CustomerName.Text;
            }
            set
            {
                lbl_CustomerName.Text = value;
            }
        }

        public string HistoryTotalCharge
        {
            get
            {
                return lbl_TotalCharge.Text;
            }
            set
            {
                lbl_TotalCharge.Text = value;
            }
        }

        private void HistoryItem_MouseClick(object sender, MouseEventArgs e)
        {
            HistoryItemInfo newform = new HistoryItemInfo(this);
            newform.ShowDialog();
            this.Show();
        }
    }
}
