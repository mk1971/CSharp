using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private static List<Cliente> _clientes;

        static ClienteController()
        {
            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente() 
            { 
                Id = 1,
                Nome = "Marcelo Dias"
            });

            _clientes.Add(new Cliente()
            {
                Id = 2,
                Nome = "Fulano de tal"
            });
        }

        [HttpGet]
        public IEnumerable<Cliente> GetAll()
        {
            return _clientes.AsReadOnly();
        }

        [HttpGet("{id}", Name = "GetCliente")]
        public IActionResult GetById(int id)
        {
            var item = _clientes.Find(x => x.Id == id);

            if (item == null)
            {
                return NotFound();
            }

            return new ObjectResult(item);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Cliente item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            item.Id = (_clientes.Count + 1);

            _clientes.Add(item);

            return CreatedAtRoute("GetCliente", new { controller = "Cliente", id = item.Id }, item);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clientes.RemoveAll(n => n.Id == id);
        }
    }
}
