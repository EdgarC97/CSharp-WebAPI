using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api_1.Data;
using api_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly AppDbContext _context;

        // Constructor que inyecta el DbContext
        public PlayersController(AppDbContext context)
        {
            _context = context;
        }

        // GET players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> Get()
        {
            var players = await _context.Players.ToListAsync();
            return Ok(players);
        }

        // GET players/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> Get(int id)
        {
            var player = await _context.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound();
            }

            return Ok(player);
        }

        // POST: players
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {
            // Agregar el nuevo jugador al contexto
            _context.Players.Add(player);

            // Guardar los cambios en la base de datos
            await _context.SaveChangesAsync();

            // Devolver una respuesta con el URI del nuevo recurso
            return CreatedAtAction(nameof(Get), new { id = player.Id }, player);
        }

        // DELETE api/players/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var player = await _context.Players.FindAsync(id);
            if (player == null)
            {
                return NotFound();
            }

            _context.Players.Remove(player);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        //PUT api/players/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlayer(int id, Player player)
        {
            if (id != player.Id)
            {
                return BadRequest();
            }

            _context.Entry(player).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PlayerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool PlayerExists(int id)
        {
            return _context.Players.Any(e => e.Id == id);
        }
    }
}
