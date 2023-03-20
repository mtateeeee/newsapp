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
    public partial class frmLogin : Form
    {
        List<TaiKhoan> listTaiKhoan = Danhsachtaikhoan.Instance.ListTaiKhoan1;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(kiemtradangnhap(txtTaiKhoan.Text, txtMatKhau.Text))
            {
                MainMenu f = new MainMenu();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "Loi");
                txtTaiKhoan.Focus();
            }
            
        }
        bool kiemtradangnhap(string tentaikhoan, string matkhau)

        {
            for (int i=0;i<listTaiKhoan.Count;i++)
            {
                if (tentaikhoan == listTaiKhoan[i].TenTaiKhoan1 && matkhau == listTaiKhoan[i].MatKhau1)
                {
                    Cont.LoaiTaiKhoan = listTaiKhoan[i].LoaiTaiKhoan;
                    return true;

                }
            }
           
            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu f = new MainMenu();
            f.Show();
            this.Hide();
        }
    }
}
