using System;
using System.Collections.Generic;
using System.Text;

namespace Station.Interfaces
{
    public interface IClassicVehicle
    {
        public void Fill(decimal quantity);
        public string GetDescriere();
    }
}
