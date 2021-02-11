using System;

namespace InvoicePrintEmulator
{
    class MobileInvoice : InvoicePrinter
    {
        private string MobilePlatform { get; set; }

        public MobileInvoice() : base("200x600", 0.7, "mob.tem"){}
        public override void print()
        {
            Console.Write("Enter Mobile Platform (Android/ iOS): "); 
            string platform = Console.ReadLine();

            if (platform == "Android" || platform == "iOS")
            {
                MobilePlatform = platform;
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
            
            Console.WriteLine(this.Size);
            Console.WriteLine(this.PaperQuality);
            Console.WriteLine(this.TemplateName);
            Console.WriteLine(this.MobilePlatform);
        }
    }
}
