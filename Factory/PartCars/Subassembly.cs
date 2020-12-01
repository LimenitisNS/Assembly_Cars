using System;
using System.Collections.Generic;

namespace AssemblyCars.Factory.PartCars
{
    class Subassembly : Component
    {

        public List<Component> detail = new List<Component> { };

        public void Add(Component component)
        {
            for (int i = component.quantity; i > 0; --i)
            {
                detail.Add(component);
            }
        }

        public void CalculateWeight()
        {
            float newWeight = 0;
            Component past = null;

            foreach (Component component in detail)
            {
                if (past == component)
                {
                    continue;
                }
                else
                {
                    past = component;
                    newWeight += component.weight;
                }
            }

            weight = newWeight * quantity;
        }

        public override float GetWeight()
        {

            for (int i = 0; i < detail.Count; i++)
            {
                weight += detail[i].weight;
            }

            return weight;
        }

        public override void Display()
        {
            List<Component> subassembly = new List<Component> { };
            Component past = null;

            Console.WriteLine($"{name} weight = {weight}");

            foreach (Component component in detail)
            {
                if(past == component)
                {
                    continue;
                }
                else
                {
                    past = component;
                }

                if (component.GetType() == typeof(Subassembly))
                {
                    Console.WriteLine($"{component.name}: Quanity = {component.quantity} weight = {component.weight}");
                    subassembly.Add(component);
                }
                else
                {
                    component.Display();
                }
            }

            for (int i = 0; i < subassembly.Count; i++)
            {
                Console.WriteLine();
                subassembly[i].Display();
            }
        }
    }
}
