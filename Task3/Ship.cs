using System;

namespace Task3
{
    partial class Program
    {
        class Ship : Vehicle
        {
            public uint countPasengers { get; set; }
            public string port { get; set; }

            public override void PrintInfo()
            {
                base.PrintInfo();
                Console.WriteLine($"Port: {port}\n" +
                     $"Pasengers count: {countPasengers}");
            }
        }
    }
}
