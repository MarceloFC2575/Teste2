using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    public class ClienteController : Controller
    {
        // GET: api/cliente
        [HttpGet]
        public IEnumerable<Cliente> Get()
        {

            using (ClienteDb db = new ClienteDb())
            {
                return db.Cliente.ToList();
            }
            
        }

        // GET api/cliente/5
        [HttpGet("{id}")]
        public Cliente Get(int id)
        {
            using (ClienteDb db = new ClienteDb())
            {
                return db.Cliente.First(t => t.Id == id);
            }
        }

        // POST api/cliente
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/cliente/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/cliente/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
