using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSWorld.Models.Repositories
{
    public class RepositoryCountry
    {
        private WSWorldEntities db { get; set; }

        public RepositoryCountry()
        {
            db = new WSWorldEntities();
            db.Configuration.LazyLoadingEnabled = false;            
        }

        public IQueryable<country> list()
        {
            return db.country;
        }

        public country byISO3(string code)
        {
            return db.country.SingleOrDefault(p => p.Code.Equals(code));
        }
    }
}
