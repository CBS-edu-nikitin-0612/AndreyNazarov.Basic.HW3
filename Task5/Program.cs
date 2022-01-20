using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "Text";
            var printer = new Printer();
            var printerBlue = new PrinterBlue();
            var printerRed = new PrinterRed();
            var printerWhite = new PrinterWhite(); ;

            Console.WriteLine(" - ");
            printer.Print(text);
            printerBlue.Print(text);
            printerRed.Print(text);
            printerWhite.Print(text);

            Console.WriteLine(" - ");
            ((Printer)printerBlue).Print(text);
            ((Printer)printerRed).Print(text);
            ((Printer)printerWhite).Print(text);

            Console.WriteLine(" - ");
            ((PrinterRed)printerWhite).Print(text);
        }
    }
}
