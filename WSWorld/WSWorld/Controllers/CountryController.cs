using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WSWorld.Contracts;
using WSWorld.Models;
using WSWorld.Models.Repositories;

namespace WSWorld.Controllers
{
    public class CountryController : ApiController
    {
        RepositoryCountry db = new RepositoryCountry();

        // GET: api/Country
        public IEnumerable<CountryContract> Getcountry()
        {
            return db.list().Select(p => new CountryContract
            {
                code = p.Code,
                name = p.Name,
                continent = p.Continent,
                region = p.Region,
                surfaceArea = (double)p.SurfaceArea,
                population = p.Population
            });
        }

        // GET: api/Country/5
        [ResponseType(typeof(CountryContract))]
        public IHttpActionResult Getcountry(string id)
        {
            country entity = db.byISO3(id);
            if (entity == null)
                return NotFound();
            return Ok(new CountryContract(entity));
        }
    }
}
