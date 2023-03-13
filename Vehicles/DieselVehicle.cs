using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class DieselVehicle : Vehicle, IClassicVehicle
    {

        public DieselVehicle( string model):base(model)
        {

        }

        public override string GetDescriere()
        {
            return $"La Statie se gaseste un vehicul Diesel: {base.GetDescriere()}";
        }

        public void Fill(decimal quantity)
        {
            Console.WriteLine("Alimentare cu diesel:");
            Console.WriteLine(GetDescriere());
            Console.WriteLine("Cantitate de motorina: " + quantity + " litri");
        }
    }
}
