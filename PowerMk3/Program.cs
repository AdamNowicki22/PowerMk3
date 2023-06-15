namespace PowerMk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourceStorage resourceStorage = ResourceStorage.GetInstance();

            CoalIndustry coalIndustry = new CoalIndustry(10, 2);

            resourceStorage.Fuel.coal = coalIndustry.mineFuel();

            double storedCoal=resourceStorage.giveFuel(coalIndustry.fuelConsumptionTotal());
            resourceStorage.energy += coalIndustry.energyFromFuel();
            


            Console.WriteLine(storedCoal);
            Console.WriteLine(resourceStorage.energy);



        }
    }
}