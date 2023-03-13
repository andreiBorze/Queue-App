using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class BenzinaVehicle : Vehicle, IClassicVehicle
    {

        public BenzinaVehicle(string model):base( model)
        {

        }

        public override string GetDescriere()
        {
            return $"La Statie se gaseste un vehicul pe benzina: {base.GetDescriere()}";
        }

        public void Fill(decimal quantity)
        {
            Console.WriteLine("Alimentare cu benzina:");
            Console.WriteLine(GetDescriere());
            Console.WriteLine("Cantitate de benzina: " + quantity + " litri");
        }
    }
}
