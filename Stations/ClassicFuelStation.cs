using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class ClassicFuelStation : Station, IClassicStation
    {
        public void Fill(IClassicVehicle vehicle, decimal quantity)
        {
            vehicle.Fill(quantity);
        }
    }
}
