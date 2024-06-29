using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rebooot.Data;
using Rebooot.Models;

namespace Rebooot.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ArticulosController : ControllerBase
    {
        private readonly ReboootContext _context;

        public ArticulosController(ReboootContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "ObtenerArticulos")]
        public IActionResult ObtenerArticulos()
        {
            List<ArticuloFerreteria> listado = new List<ArticuloFerreteria>();

            listado = _context.ArticuloFerreteria.ToList(); 

            return Ok(listado);

        }

        
    }
}
