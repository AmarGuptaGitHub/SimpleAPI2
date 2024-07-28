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
       
       [HttpGet("item")]
        public IEnumerable<string> GetItem()
        {
            return new string[] { "Amar","Amar1", "Amar2","Amar3","Amar4","Amar5" };
        }
//commented on 2807 4
        // GET: api/values/5
         [HttpGet("getlist")]
        public string GetName(int id)
        {
           
           List<string> obj=  GetItem().ToList();
            return obj[id].ToString();
        }
    }
}