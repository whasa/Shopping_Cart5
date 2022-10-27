
using AutoMapper;
using ShopCart.Models;

namespace ShopCart.Profiles
{
    public class DetallePedidoProfile : Profile
    {
        public DetallePedidoProfile()
        {
            CreateMap<DetallePedido, DetallePedidoForCreationDTO>();
        }
    }
}

