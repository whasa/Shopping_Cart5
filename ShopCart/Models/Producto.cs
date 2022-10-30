#nullable disable


using System.Collections.Generic;
using System.ComponentModel;

namespace ShopCart.Models
{
    public partial class Producto
    {
        public Producto()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }
        [DisplayName("FiProdId")]
        public int FiProdId { get; set; }
        [DisplayName("FcProdDesc")]
        public string FcProdDesc { get; set; }
        [DisplayName("FnProdPrecio")]
        public decimal? FnProdPrecio { get; set; }
        public int? FiDepto { get; set; }
        public int? FiSubDepto { get; set; }
        public int? FiClase { get; set; }
        public int? FiSubClase { get; set; }

        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
