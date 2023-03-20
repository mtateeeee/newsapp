using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{

   public class TaiKhoan
    {
        private string TenTaiKhoan;

        public string TenTaiKhoan1 
        { 
            get => TenTaiKhoan; 
            set => TenTaiKhoan = value; 
        }

        private string MatKhau;
        public string MatKhau1 
        { 
            get => MatKhau; 
            set => MatKhau = value; 
        }

        private bool loaiTaiKhoan;
        public bool LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }

        public TaiKhoan(string tentaikhoan,string matkhau,bool loaitaikhoan)
        {
            this.TenTaiKhoan = tentaikhoan;
            this.MatKhau = matkhau;
            this.LoaiTaiKhoan = loaitaikhoan;
        }
    }
}
