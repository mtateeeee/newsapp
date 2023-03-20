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
    public partial class PlaceOrderComplete : Form
    {
        public PlaceOrderComplete()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
/*            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(label1.Text + lblTotalPrice.Text, QRCoder.QRCodeGenerator.ECCLevel.H);
            var code = new QRCoder.QRCode(MyData);
            pictureBox2.Image = code.GetGraphic(50);
            label1.Text = textBox1.Text + lblTotalPrice.Text + lblTotalPrice.Text;
            button2.Enabled = false;*/
        }
    }
}
