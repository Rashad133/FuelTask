using Fuel_Task_17._10.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuel_Task_17._10.Models
{
    internal class Car : IVehicle
    {
        public double MileAge { get;private  set; }
        public double Fuel { get;private  set; }
        public double FuelConsumption { get; private set; }
        public double TankCapacity { get; private set; }

        public Car(double fuel=20,double fuelConsumption=10,double tankCapacity=40)
        {
            
            Fuel = fuel;
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }

        public bool Drive(double kilometr)
        {
            double fullNeeded = kilometr / FuelConsumption;
            if(Fuel >= fullNeeded)
            {
                Fuel -= fullNeeded;
                MileAge += kilometr;
                return true;
            }
            return false;
        }

        public bool Refuel(double amount)
        {
            if(Fuel + amount <= TankCapacity)
            {
                Fuel += amount;
                return true;
            }
            return false;
        }
    }
}
