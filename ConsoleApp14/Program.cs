using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(85.5,1,75,2015);
            car.Brand = "Audio";
            car.Model = "A6";
            car.Color = "red";
            car.Drive(50);
        }
    }
}
