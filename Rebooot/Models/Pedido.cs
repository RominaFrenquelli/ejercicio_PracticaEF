using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rebooot.Models
{
    public class Pedido : miClaseBase
    {
        
        public DateTime FechaDelPedido { get; set; }
        public int ClienteId { get; set; }
       


        [NotMapped]
        public List<DetalleDelPedido> DetalleDelPedido { get; set; }

        [NotMapped]
        public Cliente ClienteDelPedido { get; set; }

        
    }
}
