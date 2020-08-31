using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace NullObjectDesignPattern.Models
{
    public sealed class EmailInvoice : IInvoice
    {
        public void GenerateInvoice()
        {
            Console.WriteLine("Email Invoice Generaeted");
        }

        public void SendInvoice()
        {
            Console.WriteLine("Email Invoice Sent");
        }
    }
}
