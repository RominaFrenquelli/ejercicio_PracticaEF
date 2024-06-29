using Rebooot.Data;
using Rebooot.Models;

namespace Rebooot.Repository
{
    public class PedidoRepository
    {
        private readonly ReboootContext _context;

        public PedidoRepository(ReboootContext context)
        {
            _context = context;
        }
        public Pedido ObtenerPedido(int IdPedido)
        {
            Pedido elPedido = _context.Pedidos.Where(miPedido => miPedido.Id == IdPedido).FirstOrDefault();
            if (elPedido == null)
            {
                elPedido.DetalleDelPedido = _context.DetalleDelPedido.Where(dp => dp.IdDelPedido == IdPedido).ToList();

                elPedido.ClienteDelPedido = _context.Clientes.Where(Cli => Cli.Id == elPedido.ClienteId).FirstOrDefault();

            }


            return elPedido;
        }
    }
}
