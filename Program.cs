using System;
using AssemblyCars.Factory;

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
