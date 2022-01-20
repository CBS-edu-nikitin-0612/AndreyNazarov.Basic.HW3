using System;

namespace Task5
{
    internal class PrinterWhite : PrinterRed
    {
        public new void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
