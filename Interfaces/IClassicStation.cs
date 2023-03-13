using System;
using System.Collections.Generic;
using System.Text;

namespace Station.Interfaces
{
    public interface IClassicStation
    {
        public void Fill(IClassicVehicle vehicle, decimal quantity);
    }
}
