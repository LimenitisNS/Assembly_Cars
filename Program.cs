using System;
using AssemblyCars.Factory;
using AssemblyCars.Factory.PartCars;

namespace AssemblyCars
{
    class Program
    {
        static void Main(string[] args)
        {
            AssemblyCar assembly = new AssemblyCar();
            assembly.GetInfo();
            Console.ReadKey();
        }
    }
}
