using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class Danhsachtaikhoan
    {
        private static Danhsachtaikhoan instance;
        public static Danhsachtaikhoan Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new Danhsachtaikhoan();
                return instance; 
            } 
            set => instance = value; 
        }

        List<TaiKhoan> ListTaiKhoan;

        public List<TaiKhoan> ListTaiKhoan1 
        { 
            get => ListTaiKhoan; 
            set => ListTaiKhoan = value; 
        }

        Danhsachtaikhoan()
        {
            ListTaiKhoan = new List<TaiKhoan>();
            ListTaiKhoan.Add(new TaiKhoan("123", "456",true));
            ListTaiKhoan.Add(new TaiKhoan("1234", "4567",false));
            ListTaiKhoan.Add(new TaiKhoan("12345", "45689",false));
        }
    }
}
