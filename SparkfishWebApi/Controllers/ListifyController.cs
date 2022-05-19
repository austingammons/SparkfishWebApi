using SparkfishWebApi.Models;
using SparkfishWebApi.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SparkfishWebApi.Controllers
{
    public class ListifyController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get([FromBody] string value)
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>
        public string Get(int min, int max, int index)
        {
            int result = new Listify<int>().IndexOfRange(Enumerable.Range(min, max), index);
            return result.ToString();
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}