using System;

namespace InvoicePrintEmulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string invoiceType = getUserInput();
            printInvoice(invoiceType);
        }

        //Getting the user choice of invoice type
        public static string getUserInput()
        {
            Console.Write("Welcome to Invoice Printer: " +
                "\n > Mobile Invoice - 1" +
                "\n > Line Printer Invoice - 2" +
                "\n > Desktop Invoice - 3 " +
                "\nEnter Your choice here: ");
            string invoiceType = Console.ReadLine();
            return invoiceType;
        }

        //printing the invoice 
        public static void printInvoice(string invoiceType)
        {
            switch (invoiceType)
            {
                case "1":
                    MobileInvoice mobileInvoice = new MobileInvoice();
                    mobileInvoice.print();
                    break;
                case "2":
                    LinePrinterInvoice linePrinterInvoice = new LinePrinterInvoice();
                    linePrinterInvoice.print();
                    break;
                case "3":
                    DesktopInvoice desktopInvoice = new DesktopInvoice();
                    desktopInvoice.print();
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }
    }
}
