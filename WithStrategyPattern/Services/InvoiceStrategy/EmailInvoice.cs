using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyPattern.Services.InvoiceStrategy
{
    public class EmailInvoice : IInvoice
    {
        public string InvoiceText { get; set; }

        public void GenerateInvoice(string fullName, int amount)
        {
            InvoiceText = $"{fullName} have to pay a total amount of {amount}";
        }

        public void SendInvoice()
        {
            Console.WriteLine($"{InvoiceText} sent via SMS");
        }
    }
}
