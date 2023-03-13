using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station.Vehicles
{
    public class Tanker: ITanker
    {
        public Tanker()
        {
        }

        public string fuelType { get; set; }
        public int fuelQuantity { get; set; }

        public void LoadFuel(string fuelType, int fuelQuantity)
        {
            if (this.fuelType != null && this.fuelType != fuelType)
            {
                Console.WriteLine("Cannot load {0} fuel, tanker already loaded with {1} fuel.", fuelType, this.fuelType);
                return;
            }

            this.fuelType = fuelType;
            this.fuelQuantity += fuelQuantity;

            Console.WriteLine("Cisterna este incarcata cu {0} fuel, cantitate totala: {1}.", fuelType,fuelQuantity);
        }

        public void Refuel(IClassicVehicle vehicle, decimal quantity)
        {
            if (fuelType == null || fuelQuantity == 0)
            {
                Console.WriteLine("Cisterna este goala, nu se poate face plinul.");
                return;
            }

            if (fuelType == "diesel")
            {
                if (!(vehicle is DieselVehicle))
                {
                    Console.WriteLine("Cannot refuel {0}, vehicle type not supported.", vehicle.GetDescriere());
                    return;
                }
            }
            else
            if (fuelType == "benzina")
            {
                if (!(vehicle is BenzinaVehicle))
                {
                    Console.WriteLine("Cannot refuel {0}, vehicle type not supported.", vehicle.GetDescriere());
                    return;
                }
            }

            int actualRefuelQuantity = (int)Math.Min(quantity, fuelQuantity);

            vehicle.Fill(actualRefuelQuantity);

            fuelQuantity -= actualRefuelQuantity;

            Console.WriteLine("Refueled {0} cu {1} fuel, cantitate ramana in cisterna: {2}.", vehicle.GetDescriere(), fuelType, fuelQuantity);
        }
    }
}
