namespace Station.Interfaces
{
    public interface IElectricalVehicle
    {
        public void ConnectToCharger(decimal quantity);
        public string GetDescriere();
    }
}