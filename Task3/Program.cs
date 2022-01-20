using System;

namespace Task3
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var car = new Car()
            {
                x = 10,
                y = 10,
                price = 1000,
                releaseYear = new DateTime(2000, 1, 1),
                speed = 100
            };
            var plane = new Plane()
            {
                x = 20,
                y = 20,
                price = 2000,
                releaseYear = new DateTime(1999, 1, 1),
                speed = 700,
                height = 8000,
                countPasengers = 80
            };

            var ship = new Ship()
            {
                x = 30,
                y = 30,
                price = 3000,
                releaseYear = new DateTime(1980, 1, 1),
                speed = 200,
                countPasengers = 80,
                port = "Qingdao"
            };

            car.PrintInfo();
            ship.PrintInfo();
            plane.PrintInfo();
        }
    }
}
