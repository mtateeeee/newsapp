using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop
{
    public class ShoppingHistory
    {
        public List<string> Name = new List<string>();
        public List<string> Price = new List<string>();
        public List<int> Quantity = new List<int>();
        public string Code;
        public string CustomerName;
        public string PhoneNumber;
        public string Email;
        public string ShippingAddress;
        public double OriPrice = 0;
        public double TotalPrice = 0;
        public double Delivery = 0;
        public float Discount = 0;


        public ShoppingHistory(List<string> name, List<string> price, List<int> quantity, double totalprice, string code, string customername, string phonenumber, string email, string shippingaddress, double oriprice, double delivery, float discount)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            TotalPrice = totalprice;
            Code = code;
            CustomerName = customername;
            PhoneNumber = phonenumber;
            Email = email;
            ShippingAddress = shippingaddress;
            OriPrice = oriprice;
            Delivery = delivery;
            Discount = discount;
        }
        public List<string> HistoryName
        {
            get
            {
                return Name;
            }
            set
            {
                Name.Add(value.ToString());
            }
        }

        public List<string> HistoryPrice
        {
            get
            {
                return Price;
            }
            set
            {
                Price.Add(value.ToString());
            }
        }

        public List<int> HistoryQuantity
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity.Add(Int32.Parse(value.ToString()));
            }
        }

        public double HistoryTotalPrice
        {
            get
            {
                return TotalPrice;
            }
            set
            {
                TotalPrice = value;
            }
        }

        public string HistoryCode
        {
            get
            {
                return Code;
            }
            set
            {
                Code = value;
            }
        }

        public string HistoryCustomerName
        {
            get
            {
                return CustomerName;
            }
            set
            {
                CustomerName = value;
            }
        }

        public string HistoryPhoneNumber
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }
        }

        public string HistoryEmail
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }

        public string HistoryShippingAddress
        {
            get
            {
                return ShippingAddress;
            }
            set
            {
                ShippingAddress = value;
            }
        }

        public double HistoryOriPrice
        {
            get
            {
                return OriPrice;
            }
            set
            {
                OriPrice = value;
            }
        }

        public double HistoryDelivery
        {
            get
            {
                return Delivery;
            }
            set
            {
                Delivery = value;
            }
        }

        public float HistoryDiscount
        {
            get
            {
                return Discount;
            }
            set
            {
                Discount = value;
            }
        }
    }
}
