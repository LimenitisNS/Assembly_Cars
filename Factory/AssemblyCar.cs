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

            car.detail.Add(engineV6);
            car.detail.Add(wheel);
            car.detail.Add(transmission);
            car.detail.Add(differential);
            car.detail.Add(door);
            car.detail.Add(gasTank);

            engineV6.detail.Add(pistonSystem);
            engineV6.detail.Add(valueSystem);
            engineV6.detail.Add(intakeManifold);
            engineV6.detail.Add(exhaustManifold);
            engineV6.detail.Add(radiator);

            pistonSystem.detail.Add(piston);
            pistonSystem.detail.Add(crankshaft);
            pistonSystem.detail.Add(link);
            pistonSystem.detail.Add(gasket);

            valueSystem.detail.Add(value);
            valueSystem.detail.Add(camshaft);

            wheel.detail.Add(disk);
            wheel.detail.Add(tire);

            door.detail.Add(glass);
            door.detail.Add(doorCard);

            differential.detail.Add(gears);
            differential.detail.Add(bearling);
            differential.detail.Add(shank);

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
            GetInfoComponent(car);
        }

        private void GetInfoComponent(Component component)
        {
            Console.WriteLine($"\t     {component.name}");
            List<Component> subassembly = new List<Component> { };
            component.GetInfo();
            Console.WriteLine();

            for (int i = 0; i < component.detail.Count; i++)
            {
                if (component.detail[i].GetType() == typeof(Subassembly))
                {
                    component.detail[i].GetInfo();
                    subassembly.Add(component.detail[i]);
                }
                else
                {
                    component.detail[i].GetInfo();
                }
            }

            for (int i = 0; i < subassembly.Count; i++)
            {
                Console.WriteLine();
                GetInfoComponent(subassembly[i]);
            }
        }
    }
}
