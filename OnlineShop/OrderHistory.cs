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
    public partial class OrderHistory : Form
    {
        public OrderHistory()
        {
            InitializeComponent();
        }

        private void OrderHistory_Load(object sender, EventArgs e)
        {
            btn_History.BackColor = Color.DeepPink;
            for(int i=0; i<MainMenu.History.Count; i++)
            {
                HistoryItem x = new HistoryItem();
                x.HistoryOrderID = MainMenu.History[i].HistoryCode;
                x.HistoryCustomerName = MainMenu.History[i].HistoryCustomerName;
                string TotalCharge = string.Format("{0:N}", MainMenu.History[i].HistoryTotalPrice).Replace(',', '.');
                x.HistoryTotalCharge = TotalCharge.Substring(0, TotalCharge.Length - 3) + " VNĐ";
                flowLayoutPanel.Controls.Add(x);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Cart_Click(object sender, EventArgs e)
        {
            Cart newform = new Cart();
            this.Hide();
            newform.ShowDialog();
            this.DialogResult = DialogResult.OK;
        }
    }
}
