using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyPattern.Services.InvoiceStrategy
{
    public interface IInvoice
    {
        string InvoiceText { get; set; }

        void GenerateInvoice(string fullName, int amount);

        void SendInvoice();
    }
}
