using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerMk3
{
    public class ResourceStorage
    {
        public Fuel Fuel { get; set; }



        public int energy;

        private static ResourceStorage _instance;
        private ResourceStorage()
        {
            Fuel = new Fuel();
        }

        public static ResourceStorage GetInstance() //Singleton <3
        { 
            if (_instance == null)
            {
                _instance = new ResourceStorage();
            }
            return _instance;
        }

    }
}
