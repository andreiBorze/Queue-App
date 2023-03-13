using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class HybridVehicle : Vehicle, IHybridVehicle
    {

        public HybridVehicle(string model):base(model)
        {

        }

        public override string GetDescriere()
        {
            return $"La Statie se gaseste un vehicul hibrid: {base.GetDescriere()}";
        }
        public void Fill(decimal quantity)
        {
            Console.WriteLine("Alimentare cu benzina:");
            Console.WriteLine(GetDescriere());
            Console.WriteLine("Cantitate de benzina: " + quantity + " litri");
        }


        public void ConnectToCharger(decimal quantity)
        {
            Console.WriteLine("Conectare masina la statia de alimentare:");
            Console.WriteLine(GetDescriere());
            Console.WriteLine("Cantitate de curent: " + quantity / 1000 + "kW");
        }
    }
}
