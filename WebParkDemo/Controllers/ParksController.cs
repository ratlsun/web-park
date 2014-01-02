using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebParkDemo.Models;

namespace WebParkDemo.Controllers
{
    public class ParksController : ApiController
    {
        Park[] parks = new Park[] 
        { 
            new Park { Id = 1, Name = "停车场1", Price = 10, Character = "地上", PlaceCount = 55, OpeningTime = "9:00-23:00" }, 
            new Park { Id = 2, Name = "停车场2", Price = 15, Character = "地下共3层", PlaceCount = 99, OpeningTime = "24小时" }, 
            new Park { Id = 3, Name = "露天停车场", Price = 5, Character = "地上", PlaceCount = 0, OpeningTime = "24小时" } 
        };

        // GET api/parks
        public IEnumerable<Park> Get()
        {
            return parks;
        }

        // GET api/parks/5
        public IHttpActionResult Get(int id)
        {
            var park = parks.FirstOrDefault((p) => p.Id == id);
            if (park == null)
            {
                return NotFound();
            }
            return Ok(park);
        }

        // POST api/parks
        public void Post([FromBody]string value)
        {
        }

        // PUT api/parks/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/parks/5
        public void Delete(int id)
        {
        }
    }
}
