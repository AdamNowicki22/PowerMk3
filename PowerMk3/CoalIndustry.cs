using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerMk3
{
    public class CoalIndustry: IIndustry
    {
        int energyPerPlantPerDay = 7;
        double productionPerMinePerDay = 40;
        public double consumptionPerPlantPerDay = 100;

        public int qtyMines { get; set; }
        public int qtyPowePlants { get; set; }
        public CoalIndustry(int qtyMines, int qtyPowePlants)
        {
            this.qtyMines = qtyMines;
            this.qtyPowePlants = qtyPowePlants;
        }
        public double mineFuel(int days = 30)
        {
            return productionPerMinePerDay*qtyMines*days;
        }
        public double fuelConsumptionTotal(int days = 30)
        {
            return consumptionPerPlantPerDay*qtyPowePlants*days;
        }
        public int energyFromFuel(int days = 30)
        {
            return energyPerPlantPerDay*qtyPowePlants*days;
        }




    }
}
