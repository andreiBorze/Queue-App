using Station.Interfaces;

namespace Station.Vehicles
{
    public interface ITanker
    {
        void LoadFuel(string fuelType, int fuelQuantity);
        void Refuel(IClassicVehicle vehicle, decimal quantity);
    }
}