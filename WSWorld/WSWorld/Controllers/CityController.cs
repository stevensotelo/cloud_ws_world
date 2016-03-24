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
    public class CityController : ApiController
    {
        RepositoryCity db = new RepositoryCity();

        // GET: api/City/5
        [ResponseType(typeof(CityContract))]
        public IHttpActionResult Getcity(string country)
        {
            IQueryable<city> cities = db.byCountry(country);
            if (cities.Count() <= 0)
                return NotFound();

            return Ok(cities.Select(p => new CityContract
                                    {
                                        name = p.Name,
                                        district = p.District,
                                        population = p.Population
                                    }));
        }
    }
}
