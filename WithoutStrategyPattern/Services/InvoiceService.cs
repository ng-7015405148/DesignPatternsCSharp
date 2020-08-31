using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutStrategyPattern.Services
{
    public class InvoiceService
    {
        public string InvoiceText { get; set; }

        public void GenerateInvoice(string fullName, int amount)
        {
            InvoiceText = $"{fullName} have to pay a total amount of {amount}";
        }

        public void SendInvoice(int sendInvoice)
        {
            if (sendInvoice == (int)sendInvoiceVia.sendInvoiceViaSMS)
            {
                Console.WriteLine($"{InvoiceText} sent via SMS");
            }
            else if (sendInvoice == (int)sendInvoiceVia.sendInvoiceViaEmail)
            {
                Console.WriteLine($"{InvoiceText} sent via Email");
            }
        }

    }

    public enum sendInvoiceVia
    {
        sendInvoiceViaSMS = 1,
        sendInvoiceViaEmail = 2
    }
}
