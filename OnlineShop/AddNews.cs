using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineShop.BLL;
using OnlineShop.DTO;
namespace OnlineShop
{
    public partial class AddNews : Form
    {
        public AddNews()
        {
            InitializeComponent();
        }
        NewsBLL newsBLL = new NewsBLL();
        NewsDTO newsDTO = new NewsDTO();

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() !="")
            {
                newsDTO.Name = textBox1.Text;
                newsDTO.Price = textBox2.Text;
                newsDTO.Feature = textBox3.Text;

                newsBLL.Them(newsDTO);
                MessageBox.Show("Da them bai viet thanh cong", "Thong Bao");
            }
        }

        private void btn_Shop_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
