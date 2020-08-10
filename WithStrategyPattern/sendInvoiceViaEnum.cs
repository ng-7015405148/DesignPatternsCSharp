using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithStrategyPattern.Services.InvoiceStrategy
{
    public enum sendInvoiceViaEnum
    {
        sendInvoiceViaSMS = 1,
        sendInvoiceViaEmail = 2
    }
}
