using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System.Business_Layer
{
    internal class PrintBtnLogic
    {
        static Bitmap memorying;
        static PrintDocument printDocument1 = new PrintDocument();
        static Guna2Panel Printpanel;
        static PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();

        public static void print(Guna2Panel panel)
        {
            PrinterSettings ps = new PrinterSettings();
            Printpanel = panel;
            getPrintArea(panel);
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument_printpage);
            PrintPreviewDialog1.Document = printDocument1;
            PrintPreviewDialog1.ShowDialog();
        }

        static void getPrintArea(Guna2Panel panel)
        {
            // This method should define what area of the panel to print
            // For simplicity, let's assume printing the entire panel
            memorying = new Bitmap(panel.Width, panel.Height);
            panel.DrawToBitmap(memorying, new Rectangle(0, 0, panel.Width, panel.Height));
        }

        static void printDocument_printpage(object sender, PrintPageEventArgs e)
        {
            // This method handles printing the page
            e.Graphics.DrawImage(memorying, 0, 0);
        }
    }
}
