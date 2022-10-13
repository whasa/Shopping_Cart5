using System;
using System.Collections.Generic;

#nullable disable

namespace ShopCart.Models
{
    public partial class Pedido
    {
        public Pedido()
        {
            DetallePedidos = new HashSet<DetallePedido>();
        }

        public int FiNoPedido { get; set; }
        public DateTime? FdPedFec { get; set; }
        public decimal FnPedTotal { get; set; }
        public byte? FiPedStat { get; set; }
        public string FcUserId { get; set; }
        public string FcWs { get; set; }
        public DateTime? FdFecSurt { get; set; }
        public decimal FnPedSaldo { get; set; }

        public virtual ICollection<DetallePedido> DetallePedidos { get; set; }
    }
}
