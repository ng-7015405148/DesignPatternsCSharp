using System;
using WithoutStrategyPattern.Services;

namespace WithoutStrategyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("How you would like to get your invoice 1-2");
            var userInput = Console.ReadLine();

            int userInputInt;
            var userInputBool = int.TryParse(userInput, out userInputInt);

            if (!userInputBool)
            {
                throw new Exception("Please select the right Send Invoice method");
            }

            InvoiceService invoiceService = new InvoiceService();
            invoiceService.GenerateInvoice("Naveen Goyal", 2000);
            if (userInputBool)
            {
                invoiceService.SendInvoice(userInputInt);
            }
            Console.ReadLine();

        }
    }
}
