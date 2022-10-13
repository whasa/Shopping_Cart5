using System;
using System.Collections.Generic;
using ShopCart.Models;

namespace ShopCart.Services
{
    public interface IShopRepository
    {
        IEnumerable<Producto> getProductos();
    }
}

