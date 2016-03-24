using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSWorld.Models;

namespace WSWorld.Contracts
{
    public class CityContract
    {
        public string name { get; set; }
        public string district { get; set; }
        public int population { get; set; }

        public CityContract()
        {
            name = string.Empty;
            district = string.Empty;
            population = 0;
        }

        public CityContract(city model)
        {
            name = model.Name;
            district = model.District;
            population = model.Population;
        }
    }
}
