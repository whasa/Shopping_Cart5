#nullable disable


using System.Collections.Generic;

namespace ShopCart.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int FiProdId { get; set; }
        public string FcProdDesc { get; set; }
        public decimal? FnProdPrecio { get; set; }
        public int? FiDepto { get; set; }
        public int? FiSubDepto { get; set; }
        public int? FiClase { get; set; }
        public int? FiSubClase { get; set; }

        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
