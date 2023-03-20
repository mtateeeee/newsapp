using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using OnlineShop.DTO;

namespace OnlineShop.BLL

{
    public class NewsBLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"C:\Users\Administrator\Desktop\OnlineShop\OnlineShop\OnlineShop\XML\EarPhone.xml";
        
        public NewsBLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public void Them(NewsDTO NewsAdd)
        {
            XmlElement Earphone = doc.CreateElement("Earphone");
            XmlElement Name = doc.CreateElement("Name");
            Name.InnerText = NewsAdd.Name;
            Earphone.AppendChild(Name);

            XmlElement Price = doc.CreateElement("Price");
            Price.InnerText = NewsAdd.Price;
            Earphone.AppendChild(Price);

            XmlElement Feature = doc.CreateElement("Feature");
            Feature.InnerText = NewsAdd.Feature;
            Earphone.AppendChild(Feature);

            root.AppendChild(Earphone);
            doc.Save(fileName);


        }


    }
}
