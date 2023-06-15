namespace PowerMk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourceStorage resourceStorage = ResourceStorage.GetInstance();

            CoalIndustry coalIndustry = new CoalIndustry(10, 2);
            resourceStorage.Fuel.coal = coalIndustry.mineFuel();
            resourceStorage.Fuel.coal -= coalIndustry.fuelConsumptionTotal();

            Console.WriteLine(resourceStorage.Fuel.coal);



        }
    }
}