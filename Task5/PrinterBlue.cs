using System;

namespace Task5
{
    internal class PrinterBlue : Printer
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
