using NullObjectDesignPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectDesignPattern.Repository
{
    public class InvoiceRepository
    {

        public IInvoice GetInvoice(InvoiceType invoiceType)
        {

            if (invoiceType == InvoiceType.EmailInvoice)
                return new EmailInvoice();
            if (invoiceType == InvoiceType.PDFInvoice)
                return new PDFInvoice();
            if (invoiceType == InvoiceType.SMSInvoice)
                return new SMSInvoice();
            return NullInvoice.Instance;
        }

    }
}
