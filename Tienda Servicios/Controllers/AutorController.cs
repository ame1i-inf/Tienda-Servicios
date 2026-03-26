using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Tienda_Servicios.Controllers
{
    public class AutorController : ApiController
    {
        // GET: api/Autor
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Autor/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Autor
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Autor/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Autor/5
        public void Delete(int id)
        {
        }
    }
}
