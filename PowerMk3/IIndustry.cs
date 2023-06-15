using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerMk3
{
    public interface IIndustry
    {
        //double energyPerPlantPerDay { get; set; }
        //double productionPerMinePerDay { get; set; }
        //double consumptionPerPlantPerDay { get; set; }

        int qtyMines { get; set; }
        int qtyPowePlants { get; set; }

        public double mineFuel(int days = 30);

        public double fuelConsumptionTotal(int days = 30);
        public int energyFromFuel(int days = 30);
    }
}
