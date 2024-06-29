using System.ComponentModel.DataAnnotations.Schema;

namespace Rebooot.Models
{
    public class DetalleDelPedido : miClaseBase
    {
        public int ArticuloFerreteriaId { get; set; }
        public int Cantidad { get; set; }
        public int IdDelPedido { get; set; }
        public string Notas { get; set; }

        [NotMapped]
        public ArticuloFerreteria ArticuloFerreteria { get; set; }
        
        

    }
}
