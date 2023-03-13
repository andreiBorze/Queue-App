using Station.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class HybridFuelStation : Station, IHybridStation
    {
        public void ConnectToCharger(IElectricalVehicle vehicle, decimal quantity)
        {
            vehicle.ConnectToCharger(quantity);
        }

        public void Fill(IClassicVehicle vehicle, decimal quantity)
        {
            vehicle.Fill(quantity);
        }
    }
}
