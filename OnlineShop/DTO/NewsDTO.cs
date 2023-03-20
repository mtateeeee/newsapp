using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.DTO
{
    public class NewsDTO
    {
        private string _Name;
        private string _Price;
        private string _Feature;

        public string Name 
        {
            get { return _Name; }
            set { _Name = value; } 
        }

        public string Price 
        {
            get { return _Price; }
            set { _Price = value; } 
        }

        public string Feature 
        {
            get { return _Feature; }
            set { _Feature = value; } 
        }
    }
}
