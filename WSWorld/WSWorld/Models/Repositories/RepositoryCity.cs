using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSWorld.Models.Repositories
{
    public class RepositoryCity
    {
        private WSWorldEntities db { get; set; }

        public RepositoryCity()
        {
            db = new WSWorldEntities();
            db.Configuration.LazyLoadingEnabled = false;
        }

        public IQueryable<city> byCountry(string code)
        {
            return db.city.Where(p => p.CountryCode.Equals(code));
        }
    }
}
