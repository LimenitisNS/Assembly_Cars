using System;
using System.Collections.Generic;

namespace AssemblyCars.Factory.PartCars
{
    abstract class Component
    {
        public string name { get; set; }
        public int quantity { get; set; }
        public float weight { get; set; }

        public List<Component> detail = new List<Component> { };

        public void GetInfo()
        {
            Console.WriteLine($"{name}: Quanity = {quantity} weight = {weight}");
        }
    }
}
