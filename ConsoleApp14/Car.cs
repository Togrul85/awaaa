using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp14
{

    class Car:Vehicle
    {
        public string Brand;
        public string Model;
        public double FuelCapacity;
        public double FuelFor1Km;
        public double CurrentFuel;
        public double PossibleWay;

        public Car(double fuelCapacity,double fuelFor1Km,double currentFuel, int year):base(year){
           
            FuelCapacity = fuelCapacity;
            FuelFor1Km = fuelFor1Km;
            CurrentFuel = currentFuel;
        }

        public void ShowInfo()
        {
         
        }

        public void Drive(int Kilometer)
        {
            PossibleWay = CurrentFuel / FuelFor1Km;
            if (PossibleWay<Kilometer)
            {
                Console.WriteLine("Yeterli Benzin Yoxdur");
            }
            else
            {
                CurrentFuel = CurrentFuel - (Kilometer*FuelFor1Km);
                Console.WriteLine($"Gedisiniz tamamlandi.Qalan yanacaq {CurrentFuel}");
            }
        }

    }

    
}
