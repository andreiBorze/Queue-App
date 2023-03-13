using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class GPLVehicle : Vehicle, IClassicVehicle
    {

        public GPLVehicle(string model):base( model)
        {

        }

        public override string GetDescriere()
        {
            return $"La Statie se gaseste un vehicul cu GPL: {base.GetDescriere()}";
        }

        public void Fill(decimal quantity)
        {
            Console.WriteLine("Alimentare cu GPL:");
            Console.WriteLine(GetDescriere());
            Console.WriteLine("Cantitate de gaz: " + quantity + " litri");
        }

    }
}
