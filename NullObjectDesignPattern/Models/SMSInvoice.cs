using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern.Models
{
    public sealed class SMSInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("SMS Invoice Generated");
        }

        public void SendInvoice()
        {
            Console.WriteLine("SMS Invoice Sent");
        }
    }
}
