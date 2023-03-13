using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class ElectricVehicle : Vehicle, IElectricalVehicle
    {

        public ElectricVehicle(string model):base(model)
        {

        }

        public override string GetDescriere()
        {
            return $"La Statie se gaseste un vehicul electric: {base.GetDescriere()}";
        }

        public void ConnectToCharger(decimal quantity)
        {
            Console.WriteLine("Charging the electric vehicle:");
            Console.WriteLine(GetDescriere());
            Console.WriteLine($"Charged with {quantity} kWh.");
        }
    }
}
