using System.ComponentModel.DataAnnotations;

namespace Rebooot.Models
{
    public class ArticuloFerreteria : miClaseBase
    {
        
        public string NombreArticulo { get; set; }
        public int PrecioVenta { get; set; }
        public int PrecioCosto { get; set; }
    }
}
