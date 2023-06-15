namespace PowerMk3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ResourceStorage resourceStorage = ResourceStorage.GetInstance();
            CoalIndustry coalIndustry = new CoalIndustry(9, 2);

            resourceStorage.Fuel.coal = coalIndustry.unusedFuel();
            double storedCoal = resourceStorage.Fuel.coal;
            resourceStorage.energy += coalIndustry.energyFromFuel();

            Console.WriteLine($"Our spare supply of coal is {storedCoal} units");
            Console.WriteLine($"Produced energy is {resourceStorage.energy} units");



        }
    }
}