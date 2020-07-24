using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DealerAPI.Domain;
using DealerAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DealerAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DealerController : ControllerBase
    {
        private readonly DealerRepository _dealerRepository;

        public DealerController(DealerRepository dealerRepository)
        {
            _dealerRepository = dealerRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Dealer>>> GetAll()
        {
            return await _dealerRepository.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Dealer>> GetById(int id)
        {
            var dealer = await _dealerRepository.GetById(id);
            if (dealer == null)
            {
                return NotFound();
            }

            return dealer;
        }
        
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Dealer>>> Add(Dealer dealer)
        {
            await _dealerRepository.Add(dealer);
            return CreatedAtAction("GetById", new { id = dealer.Id }, dealer);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Dealer>> Delete(int id)
        {
            var dealer = await _dealerRepository.Delete(id);
            if (dealer == null)
            {
                return NotFound();
            }

            return dealer;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Dealer>> Update(int id, Dealer dealer)
        {
            if (id != dealer.Id)
            {
                return BadRequest();
            }

            await _dealerRepository.Update(dealer);
            return NoContent();
        }
    }
}