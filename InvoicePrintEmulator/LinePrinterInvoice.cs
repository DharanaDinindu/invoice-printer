using System;

namespace InvoicePrintEmulator
{
    class LinePrinterInvoice : InvoicePrinter
    {
        private bool IsBlackAndWhite { get; set; }

        public LinePrinterInvoice() : base("100x200", 0.45, "line.tem") { }
        public override void print()
        {
            Console.Write("Is the invoice printed in black and white? (True/ False): ");
            string result = Console.ReadLine();

            if (result == "True" || result == "False")
            {
                IsBlackAndWhite = true;
                
                Console.WriteLine(this.Size);
                Console.WriteLine(this.PaperQuality);
                Console.WriteLine(this.TemplateName);
                Console.WriteLine(this.IsBlackAndWhite);
            }
            else
            {
                Console.WriteLine("Invalid answer!");
            }
        }
    }
}
