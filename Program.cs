using Station;
using Station.Interfaces;
using System;

namespace Queue_App
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueClass<int> intQueue = new QueueClass<int>(10);
            QueueClass<string> stringQueue = new QueueClass<string>(20);

            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);

            Console.WriteLine("Queue count: " + intQueue.Count);

            int dequeuedInt = intQueue.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedInt);

            stringQueue.Enqueue("hello");
            stringQueue.Enqueue("world");

            Console.WriteLine("Queue count: " + stringQueue.Count);

            string dequeuedString = stringQueue.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedString);


            IClassicVehicle dieselCar = new DieselVehicle("Audi A4");
            IClassicVehicle benzinaCar = new BenzinaVehicle("Ford Fiesta");
            IClassicVehicle gplCar = new GPLVehicle("Dacia Logan");

            QueueClass<DieselVehicle> dieselCars = new QueueClass<DieselVehicle>(3);
            dieselCars.Enqueue(new DieselVehicle("Audi A4"));
            dieselCars.Enqueue(new DieselVehicle("BMW X6"));
            dieselCars.Enqueue(new DieselVehicle("Skoda Octavia"));

            Console.WriteLine("Queue count: " + dieselCars.Count);

            var dequeuedcar = dieselCars.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedcar.GetDescriere());

            QueueClass<IElectricalVehicle> cars = new QueueClass<IElectricalVehicle>(2);
            cars.Enqueue(new ElectricVehicle("Tesla Model S"));
            cars.Enqueue(new ElectricVehicle("Toyota Prius"));

            Console.WriteLine("Queue count: " + cars.Count);

            var dequeuedElectricCar = cars.Dequeue();
            Console.WriteLine("Dequeued item: " + dequeuedElectricCar.GetDescriere());

        }
    }
}
