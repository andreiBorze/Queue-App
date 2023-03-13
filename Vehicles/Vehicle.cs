using System;
using System.Collections.Generic;
using System.Text;

namespace Station
{
    public class Vehicle
    {
        public Guid Id { get; protected set; }
        public string Model { get; protected set; }
        public Vehicle(string model)
        {
            Id = new Guid();
            Model = model;
        }

        public virtual string GetDescriere()
        {
           return $"Modelul: {Model} cu Id: {Id}";
        }
    }
}
