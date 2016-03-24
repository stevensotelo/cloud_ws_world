using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WSWorld.Models;

namespace WSWorld.Contracts
{
    public class CountryContract
    {
        public string code { get; set; }
        public string name { get; set; }
        public string continent { get; set; }
        public string region { get; set; }
        public double surfaceArea { get; set; }
        public int population { get; set; }

        public CountryContract()
        {
            code = string.Empty;
            name = string.Empty;
            continent = string.Empty;
            region = string.Empty;
            surfaceArea = 0.0;
            population = 0; 
        }

        public CountryContract(country model)
        {
            code = model.Code;
            name = model.Name;
            continent = model.Continent;
            region = model.Region;
            surfaceArea = (double)model.SurfaceArea;
            population = model.Population;
        }
    }
}
