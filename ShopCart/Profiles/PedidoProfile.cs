using System;
using AutoMapper;
using ShopCart.Models;

namespace ShopCart.Profiles
{
    public class PedidoProfile : Profile
    {
        public PedidoProfile()
        {
            CreateMap<Pedido, PedidoForCreationDTO>();
                
        }
    }
}

