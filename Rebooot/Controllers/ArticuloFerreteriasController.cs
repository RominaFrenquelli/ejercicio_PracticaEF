﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Rebooot.Data;
using Rebooot.Models;

namespace Rebooot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticuloFerreteriasController : ControllerBase
    {
        private readonly ReboootContext _context;

        public ArticuloFerreteriasController(ReboootContext context)
        {
            _context = context;
        }

        // GET: api/ArticuloFerreterias
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ArticuloFerreteria>>> GetArticuloFerreteria()
        {
          if (_context.ArticuloFerreteria == null)
          {
              return NotFound();
          }
            return await _context.ArticuloFerreteria.ToListAsync();
        }

        // GET: api/ArticuloFerreterias/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ArticuloFerreteria>> GetArticuloFerreteria(int id)
        {
          if (_context.ArticuloFerreteria == null)
          {
              return NotFound();
          }
            var articuloFerreteria = await _context.ArticuloFerreteria.FindAsync(id);

            if (articuloFerreteria == null)
            {
                return NotFound();
            }

            return articuloFerreteria;
        }

        [HttpGet("{texto}")]
        public async Task<ActionResult<List<ArticuloFerreteria>>> BuscarArticulos(string texto)
        {
            var articulosEncontrados = _context
                .ArticuloFerreteria
                .Where(x => x.NombreArticulo.Contains(texto))
                .ToList();

            return articulosEncontrados;
        }

        // PUT: api/ArticuloFerreterias/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArticuloFerreteria(int id, ArticuloFerreteria articuloFerreteria)
        {
            if (id != articuloFerreteria.Id)
            {
                return BadRequest();
            }

            _context.Entry(articuloFerreteria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ArticuloFerreteriaExists(id))
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

        // POST: api/ArticuloFerreterias
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ArticuloFerreteria>> PostArticuloFerreteria(ArticuloFerreteria articuloFerreteria)
        {
          if (_context.ArticuloFerreteria == null)
          {
              return Problem("Entity set 'ReboootContext.ArticuloFerreteria'  is null.");
          }
            _context.ArticuloFerreteria.Add(articuloFerreteria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetArticuloFerreteria", new { id = articuloFerreteria.Id }, articuloFerreteria);
        }

        // DELETE: api/ArticuloFerreterias/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArticuloFerreteria(int id)
        {
            if (_context.ArticuloFerreteria == null)
            {
                return NotFound();
            }
            var articuloFerreteria = await _context.ArticuloFerreteria.FindAsync(id);
            if (articuloFerreteria == null)
            {
                return NotFound();
            }

            _context.ArticuloFerreteria.Remove(articuloFerreteria);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ArticuloFerreteriaExists(int id)
        {
            return (_context.ArticuloFerreteria?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
