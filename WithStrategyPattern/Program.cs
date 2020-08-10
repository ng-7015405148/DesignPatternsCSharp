using System;
using WithStrategyPattern.Services.InvoiceStrategy;

namespace WithStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How you would like to get your invoice 1-2");
            var userInput = Console.ReadLine();

            int userInputInt;
            var userInputBool = int.TryParse(userInput, out userInputInt);

            if (!userInputBool)
            {
                throw new Exception("Please select the right Send Invoice method");
            }


            IInvoice invoiceService;

            if (userInputInt == (int)sendInvoiceViaEnum.sendInvoiceViaSMS)
            {
                invoiceService = new SMSInvoice();
                invoiceService.GenerateInvoice("Naveen Goyal", 1000);
                invoiceService.SendInvoice();

            }
            else if (userInputInt == (int)sendInvoiceViaEnum.sendInvoiceViaEmail)
            {
                invoiceService = new EmailInvoice();
                invoiceService.GenerateInvoice("Naveen Goyal", 1000);
                invoiceService.SendInvoice();
            }

            Console.ReadLine();
        }
    }
}
