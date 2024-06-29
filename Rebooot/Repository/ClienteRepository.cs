using Rebooot.Data;
using Rebooot.Models;

namespace Rebooot.Repository
{
    public class ClienteRepository
    {
        private readonly ReboootContext _context;

        public ClienteRepository(ReboootContext context)
        {
            _context = context;
        }

        public int CrearCliente(Cliente elCLiente)
        {
            _context.Clientes.Add(elCLiente);

            _context.SaveChanges();

            return elCLiente.Id;
        }

        public List<Cliente> ObtenerCliente()
        {
            return _context.Clientes.ToList();
        }

    }
}
