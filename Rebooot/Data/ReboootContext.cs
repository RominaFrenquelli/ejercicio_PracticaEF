using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rebooot.Models;

namespace Rebooot.Data
{
    public class ReboootContext : DbContext
    {
        public ReboootContext (DbContextOptions<ReboootContext> options)
            : base(options)
        {
        }

        public DbSet<Rebooot.Models.ArticuloFerreteria> ArticuloFerreteria { get; set; } = default!;

        public DbSet<Rebooot.Models.Cliente> Clientes { get; set; } = default!;
        public DbSet<Rebooot.Models.Pedido> Pedidos { get; set; } = default!;
        public DbSet<Rebooot.Models.DetalleDelPedido> DetalleDelPedido { get; set; } = default!;
    }
}
