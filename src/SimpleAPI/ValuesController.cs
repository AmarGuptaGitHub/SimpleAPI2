using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET: api/values
        public IEnumerable<string> GetItem()
        {
            return new string[] { "Amar", "Amar2","Amar3","Amar4" };
        }

        // GET: api/values/5
        public string Get(int id)
        {
           
           List<string> obj=  GetItem().ToList();
            return obj[id].ToString();
        }

        // POST: api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/values/5
        public void Delete(int id)
        {
        }
    }
}