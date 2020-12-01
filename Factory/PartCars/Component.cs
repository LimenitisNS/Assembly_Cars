using System;
using System.Collections.Generic;

namespace AssemblyCars.Factory.PartCars
{
    abstract class Component
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public float weight { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"{name}: Quanity = {quantity} weight = {weight}");
        }

        public virtual float GetWeight()
        {
            return weight;
        }
    }
}
