using System.Runtime.Serialization;

namespace ShopCart.Models
{
    [DataContract]
    public class ProductoRequestDTO
    {
        [DataMember]
        public string ProductoId { get; set; }
    }
}
