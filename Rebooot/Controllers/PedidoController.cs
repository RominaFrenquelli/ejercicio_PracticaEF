using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rebooot.Business;
using Rebooot.Data;

namespace Rebooot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly PedidoBusiness _PedidoBusiness;

        public PedidoController(ReboootContext context)
        {
            _PedidoBusiness = new PedidoBusiness(context);
        }
        [HttpGet(Name = "ObtenerPedido")]
        public IActionResult ObtenerPedido(int IdPedido)
        {
            var Pedido = _PedidoBusiness.ObtenerPedido(IdPedido);

            return Ok(Pedido);
        }
    }    
}
