using System;
using System.Collections.Generic;
using AssemblyCars.Factory.PartCars;

namespace AssemblyCars.Factory
{
    class AssemblyCar
    {
        public Subassembly car = new Subassembly() { name = "Car", quantity = 1};

        public AssemblyCar()
        {
            Subassembly engineV6 = new Subassembly() { name = "Engine V6", quantity = 1};
            Subassembly pistonSystem = new Subassembly() { name = "Piston system", quantity = 1};
            Subassembly valueSystem = new Subassembly() { name = "Value system", quantity = 1};
            Subassembly wheel = new Subassembly() { name = "Wheel", quantity = 4};
            Subassembly door = new Subassembly() { name = "Door", quantity = 4};
            Subassembly differential = new Subassembly() { name = "Differential", quantity = 2};

            Detail transmission = new Detail() { name = "Transmission", quantity = 1, weight = 25 };
            Detail gasTank = new Detail() { name = "Gas tank", quantity = 1, weight = 27 };
            Detail intakeManifold = new Detail() { name = "Intake manifold", quantity = 1, weight = 12 };
            Detail exhaustManifold = new Detail() { name = "Exhaust Manifold", quantity = 2, weight =  6};
            Detail radiator = new Detail() { name = "Radiator", quantity = 1, weight = 8 };
            Detail piston = new Detail() { name = "Piston", quantity = 4, weight = 1 };
            Detail crankshaft = new Detail() { name = "Crankshaft", quantity = 1, weight = 19};
            Detail link = new Detail() { name = "Link", quantity = 4, weight = 0.3f};
            Detail gasket = new Detail() { name = "Gasket", quantity = 1, weight = 0.1f };
            Detail value = new Detail() { name = "Value", quantity = 24, weight = 0.1f };
            Detail camshaft = new Detail() { name = "Camshaft", quantity = 2, weight = 4.52f};
            Detail disk = new Detail() { name = "Disk", quantity = 1, weight = 6.5f};
            Detail tire = new Detail() { name = "Tire", quantity = 1, weight = 5.2f};
            Detail glass = new Detail() { name = "Glass", quantity = 1, weight = 15 };
            Detail doorCard = new Detail() { name = "Door kard", quantity = 1, weight = 5};
            Detail gears = new Detail() { name = "Gears", quantity = 5, weight = 0.6f};
            Detail bearling = new Detail() { name = "Bearling", quantity = 3, weight = 0.13f};
            Detail shank = new Detail() { name = "Shank", quantity = 1, weight = 0.32f};

            car.Add(engineV6);
            car.Add(wheel);
            car.Add(transmission);
            car.Add(differential);
            car.Add(door);
            car.Add(gasTank);

            engineV6.Add(pistonSystem);
            engineV6.Add(valueSystem);
            engineV6.Add(intakeManifold);
            engineV6.Add(exhaustManifold);
            engineV6.Add(radiator);

            pistonSystem.Add(piston);
            pistonSystem.Add(crankshaft);
            pistonSystem.Add(link);
            pistonSystem.Add(gasket);

            valueSystem.Add(value);
            valueSystem.Add(camshaft);

            wheel.Add(disk);
            wheel.Add(tire);

            door.Add(glass);
            door.Add(doorCard);

            differential.Add(gears);
            differential.Add(bearling);
            differential.Add(shank);

            differential.CalculateWeight();
            door.CalculateWeight();
            wheel.CalculateWeight();
            valueSystem.CalculateWeight();
            pistonSystem.CalculateWeight();
            engineV6.CalculateWeight();
            car.CalculateWeight();
        }

        public void GetInfo()
        {
            car.Display();
        }
    }
}
