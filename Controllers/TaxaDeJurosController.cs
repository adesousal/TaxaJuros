using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TaxaJuros.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxaDeJurosController : ControllerBase
    {
        // GET: api/<TaxaDeJurosController>
        [HttpGet]
        public double Get()
        {
            return 0.01;
        }

        // GET api/<TaxaDeJurosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TaxaDeJurosController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TaxaDeJurosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TaxaDeJurosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
