using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace OnlineShop
{
    public partial class ReportForm : Form
    {
        CheckOut newform = new CheckOut();
        public ReportForm(CheckOut form)
        {
            InitializeComponent();
            newform = form;
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {
            LoadReport();
            this.reportViewer_Reciept.RefreshReport();
        }

        public void LoadReport()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID", typeof(string));
            dt.Columns.Add("Product", typeof(string));
            dt.Columns.Add("Quantity", typeof(string));
            dt.Columns.Add("Price", typeof(string));

            for(int i=0; i<MainMenu.ShoppingInfo.GlobalName.Count; i++)
            {
                dt.Rows.Add(i + 1, MainMenu.ShoppingInfo.GlobalName[i], MainMenu.ShoppingInfo.GlobalQuantity[i], MainMenu.ShoppingInfo.GlobalPrice[i]);
            }

            reportViewer_Reciept.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            reportViewer_Reciept.LocalReport.ReportPath = "..//..//Receipt.rdlc";

            ReportDataSource dts = new ReportDataSource();
            dts.Name = "DataSet1"; //Đặt đúng tên khi đặt trong report -- có tên mặc định là DataSet1
            dts.Value = dt;
            reportViewer_Reciept.LocalReport.DataSources.Clear();
            reportViewer_Reciept.LocalReport.DataSources.Add(dts);

            DataTable dt2 = new DataTable();
            dt2.Columns.Add("Total", typeof(string));
            string final = string.Format("{0:N}", MainMenu.ShoppingInfo.GlobalTotalPrice).Replace(',', '.');
            dt2.Rows.Add(final.Substring(0, final.Length - 3) + " VNĐ");
            ReportDataSource dts2 = new ReportDataSource();
            dts2.Name = "DataSet2";
            dts2.Value = dt2;
            reportViewer_Reciept.LocalReport.DataSources.Add(dts2);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "CustomerName"; //Đặt đúng tên khi đặt trong report
            para1.Values.Add(newform.CustomerFullName);
            ReportParameter para2 = new ReportParameter();
            para2.Name = "ShippingAddress";
            para2.Values.Add(newform.CustomerDeliveryAddress);
            ReportParameter para3 = new ReportParameter();
            para3.Name = "Email";
            para3.Values.Add(newform.CustomerEmail);
            ReportParameter para4 = new ReportParameter();
            para4.Name = "PhoneNumber";
            para4.Values.Add(newform.CustomerPhoneNumber);
            ReportParameter para5 = new ReportParameter();
            para5.Name = "OrderID";
            para5.Values.Add(newform.getOrderID);
            reportViewer_Reciept.LocalReport.SetParameters(new ReportParameter[] { para1, para2, para3, para4, para5 });

            MainMenu.ShoppingInfo.GlobalName.Clear();
            MainMenu.ShoppingInfo.GlobalPrice.Clear();
            MainMenu.ShoppingInfo.GlobalQuantity.Clear();
            MainMenu.ShoppingInfo.GlobalOriPrice = 0;
            MainMenu.ShoppingInfo.GlobalTotalPrice = 0;
            MainMenu.ShoppingInfo.GlobalDelivery = 0;
            MainMenu.ShoppingInfo.GlobalDiscount = 0;

/*            Bitmap bmp = new Bitmap(this.Width, this.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            this.DrawToBitmap(bmp, this.ClientRectangle);
            bmp.Save("image.png");*/
        }
    }
}
