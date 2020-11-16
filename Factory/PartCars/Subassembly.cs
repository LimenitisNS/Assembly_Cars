namespace AssemblyCars.Factory.PartCars
{
    class Subassembly : Component
    {
        public void CalculateWeight()
        {
            float newWeight = 0;

            for(int i = 0; i < detail.Count; i++)
            {
                newWeight += detail[i].weight;
            }

            weight = newWeight * quantity;
        }
    }
}
