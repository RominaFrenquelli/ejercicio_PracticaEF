using Rebooot.Data;
using Rebooot.Models;
using Rebooot.Repository;

namespace Rebooot.Business
{
    public class PedidoBusiness
    {
        
        private readonly PedidoRepository _PedidoRepository;

        public PedidoBusiness(ReboootContext context)
        {
            _PedidoRepository = new PedidoRepository(context);
        }
        public Pedido ObtenerPedido(int IdPedido)
        {
            Pedido elPedido = _PedidoRepository.ObtenerPedido(IdPedido);

            return elPedido;
        }
    }
}
