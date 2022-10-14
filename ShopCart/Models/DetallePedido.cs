#nullable disable


namespace ShopCart.Models
{
    public partial class DetallePedido
    {
        public int FiNoPedido { get; set; }
        public int FiProdId { get; set; }
        public short FiCantArt { get; set; }
        public decimal FnCostoPdcto { get; set; }

        public virtual Pedido FiNoPedidoNavigation { get; set; }
        public virtual Producto FiProd { get; set; }
    }
}
