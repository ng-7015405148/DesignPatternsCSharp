using NullObjectDesignPattern.Models;
using NullObjectDesignPattern.Repository;
using System;

namespace NullObjectDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            InvoiceRepository invoiceRepository = new InvoiceRepository();

            IInvoice emailInvoice = invoiceRepository.GetInvoice(Models.InvoiceType.EmailInvoice);
            emailInvoice.GenerateInvoice();
            emailInvoice.SendInvoice();
            emailInvoice = invoiceRepository.GetInvoice(Models.InvoiceType.DefaultInvoice);
            emailInvoice.GenerateInvoice();
            emailInvoice.SendInvoice();
        }
    }
}
