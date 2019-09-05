using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreBank.Api.Models;

namespace AspNetCoreBank.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ClientController : ControllerBase
    {
        private readonly ClientContext _context;

        public ClientController(ClientContext context)
        {
            _context = context;

            if (_context.Client.Count() == 0)
            {
                // Create a new Client if collection is empty,
                // which means you can't delete all Clients.
                _context.Client.Add(new Client { Id= 1, Name = "Jury",Lastname = "Umanchuk", Date = DateTime.Now});
                _context.SaveChanges();
            }

 
        }

                       // GET: api/Client
                [HttpGet]
                public async Task<ActionResult<IEnumerable<Client>>> GetClient()
                {
                    return await _context.Client.ToListAsync();
                }

                // GET: api/Todo/5
                [HttpGet("{id}")]
                public async Task<ActionResult<Client>> GetClient(long id)
                {
                    var client = await _context.Client.FindAsync(id);

                    if (client == null)
                    {
                        return NotFound();
                    }

                    return client;
                }
                
    }
}