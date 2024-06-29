using Rebooot.Data;
using Rebooot.Models;
using Rebooot.Repository;

namespace Rebooot.Business
{
    public class ClienteBusiness
    {
        private readonly ClienteRepository _Repository;

        public ClienteBusiness(ReboootContext context)
        {
            _Repository = new ClienteRepository(context);
        }

        public int CrearCliente(Cliente algunCliente)
        {
            var idGeneradoDeCliente = 0;

            idGeneradoDeCliente = _Repository.CrearCliente(algunCliente);

            return idGeneradoDeCliente;
        }
        public List<Cliente> ObtenerCliente()
        {
            var clientes = _Repository.ObtenerCliente();

            return clientes;    
        }
       
    }
}
