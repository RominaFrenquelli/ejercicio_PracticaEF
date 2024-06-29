using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rebooot.Business;
using Rebooot.Data;
using Rebooot.Models;

namespace Rebooot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClienteBusiness _Business;

        public ClientesController(ReboootContext context)
        {
            _Business = new ClienteBusiness(context);
        }

        [HttpPost(Name = "CrearCliente")]
        public IActionResult CrearClientes(Cliente elCLienteDelHtml)
        {
            // 1 - Crear clientes
            var idDelCLiente = _Business.CrearCliente(elCLienteDelHtml);

            // 2 - Retornar ok
            return Ok(idDelCLiente);
        }

        [HttpGet(Name = "ObtenerCliente")]
        public IActionResult ObtenerCliente()
        {

            var cliente = _Business.ObtenerCliente();

            if (cliente.Count == 0)
            {
                return NotFound();
            }
            else
            {
                return Ok(cliente);
            }

        }
    }
}
