using System;
using System.Collections.Generic;
using System.Text;

namespace Station.Interfaces
{
    public interface IElectricalStation
    {
        public void ConnectToCharger(IElectricalVehicle vehicle, decimal quantity);
    }
}
