using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicePrintEmulator
{
    class DesktopInvoice : InvoicePrinter
    {
        public DesktopInvoice() : base("1000x800", 0.8575, "desk.tem") { }
        public override void print()
        {
            Console.WriteLine(this.Size);
            Console.WriteLine(this.PaperQuality);
            Console.WriteLine(this.TemplateName);
        }
    }
}
