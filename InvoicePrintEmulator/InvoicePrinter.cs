using System;
using System.Collections.Generic;
using System.Text;

namespace InvoicePrintEmulator
{
    abstract class InvoicePrinter
    {
        protected string Size { get; set; }
        protected double PaperQuality { get; set; }
        protected string TemplateName { get; set; }

        public InvoicePrinter(string size, double paperQuality, string templateName)
        {
            Size = size;
            PaperQuality = paperQuality;
            TemplateName = templateName;
        }

        public abstract void print();
    }
}
