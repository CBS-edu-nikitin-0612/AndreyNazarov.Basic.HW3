using System;

namespace Task3
{
    partial class Program
    {
        class Vehicle
        {
            public int x { get; set; }
            public int y { get; set; }
            public decimal price { get; set; }
            public int speed { get; set; }
            public DateTime releaseYear { get; set; }
            public virtual void PrintInfo()
            {
                Console.WriteLine($"Type: {GetType()}\n" +
                    $"X: {x}\n" +
                    $"Y: {y}\n" +
                    $"Price: {price}\n" +
                    $"Speed: {speed}\n" +
                    $"Release Year: {releaseYear.Year}");
            }

        }
    }
}
