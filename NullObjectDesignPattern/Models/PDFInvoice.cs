using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern.Models
{
    public sealed class PDFInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Pdf Invoice Generated");
        }

        public void SendInvoice()
        {
            Console.WriteLine("Pdf Invoice Sent");
        }
    }
}
