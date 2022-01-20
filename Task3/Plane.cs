using System;

namespace Task3
{
    partial class Program
    {
        class Plane : Vehicle
        {
            public int height { get; set; }
            public uint countPasengers { get; set; }
            public override void PrintInfo()
            {
                base.PrintInfo();
                Console.WriteLine($"Height: {height}\n" +
                    $"Pasengers count: {countPasengers}");
            }

        }
    }
}
