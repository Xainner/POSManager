using BusinessLibrary.Models;
using LogicLibrary.Management;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLibrary.Utilities
{
    public class Printing
    {
        PrintDocument pdoc = null;
        int ticketNo;
        DateTime TicketDate;
        String Source, Destination, DrawnBy;
        float Amount;

        public int TicketNo
        {
            //set the person name
            set { this.ticketNo = value; }
            //get the person name 
            get { return this.ticketNo; }
        }
        public DateTime ticketDate
        {
            //set the person name
            set { this.TicketDate = value; }
            //get the person name 
            get { return this.TicketDate; }
        }


        public Printing()
        {

        }

        string storeName;
        List<ProductXQuantityModel> productXQuantityModels;
        ExternalInvoiceSaleDetailsModel externalInvoiceSaleDetailsModels;
        public Printing(int ticketNo, DateTime TicketDate, List<ProductXQuantityModel> productXQuantityModels, string storeName)
        {
            this.ticketNo = ticketNo;
            this.TicketDate = TicketDate;
            this.storeName = storeName;
            this.productXQuantityModels = productXQuantityModels;
            externalInvoiceSaleDetailsModels = ExternalInvoiceSaleManagement.SelectInvoiceById2(ticketNo);
        }
        public void print()
        {
            PrintDialog pd = new PrintDialog();
            pdoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            Font font = new Font("Courier New", 15);


            PaperSize psize = new PaperSize("Custom", 100, 200);
            //ps.DefaultPageSettings.PaperSize = psize;

            pd.Document = pdoc;
            pd.Document.DefaultPageSettings.PaperSize = psize;
            //pdoc.DefaultPageSettings.PaperSize.Height =320;
            pdoc.DefaultPageSettings.PaperSize.Height = 500;

            pdoc.DefaultPageSettings.PaperSize.Width = 520;

            pdoc.PrintPage += new PrintPageEventHandler(pdoc_PrintPage);

            DialogResult result = pd.ShowDialog();
            if (result == DialogResult.OK)
            {
                PrintPreviewDialog pp = new PrintPreviewDialog();
                pp.Document = pdoc;
                result = pp.ShowDialog();
                if (result == DialogResult.OK)
                {
                    pdoc.Print();
                }

            }


        }
        void pdoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 10);
            float fontHeight = font.GetHeight();
            int startX = 50;
            int startY = 55;
            int Offset = 40;
            
            graphics.DrawString("Distribuidora " + BusinessManagement.SelectMainBusinessName(), new Font("Courier New", 14),
                                new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Número de Factura:" + this.TicketNo,
                     new Font("Courier New", 14),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Fecha:" + this.ticketDate,
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            String underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            Offset = Offset + 20;
            graphics.DrawString("Producto    Cantidad    Precio",
                     new Font("Courier New", 12),
                     new SolidBrush(Color.Black), startX, startY + Offset);


            Offset = Offset + 20;



            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);

            foreach (ProductXQuantityModel item in productXQuantityModels)
            {
                Offset = Offset + 20;
                graphics.DrawString($"{ item.description }      { item.quantity}      { item.amount }", new Font("Courier New", 8),
                         new SolidBrush(Color.Black), startX, startY + Offset);
            }

            Offset = Offset + 20;
            

            Offset = Offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;


            graphics.DrawString("Total Descuento: " + externalInvoiceSaleDetailsModels.TotalDiscount.ToString(), new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("SubTotal: " + externalInvoiceSaleDetailsModels.SubTotal.ToString(), new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("I.V.I: " + externalInvoiceSaleDetailsModels.IviAmount.ToString(), new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;
            graphics.DrawString("Total: " + externalInvoiceSaleDetailsModels.Total.ToString(), new Font("Courier New", 10),
                     new SolidBrush(Color.Black), startX, startY + Offset);
            Offset = Offset + 20;

        }
    }
}
