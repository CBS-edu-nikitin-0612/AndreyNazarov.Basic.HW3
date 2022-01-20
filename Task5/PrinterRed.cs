using System;

namespace Task5
{
    internal class PrinterRed : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
