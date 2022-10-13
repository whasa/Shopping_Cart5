﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ShopCart.Models;
using System.Linq;


namespace ShopCart.Services
{
    public class ShopRepository : IShopRepository
    {
        private readonly CoppelMxContext _CoppelMxcontext;
        public ShopRepository(CoppelMxContext CoppelMxcontext)
        {
            _CoppelMxcontext = CoppelMxcontext;
        }

        public IEnumerable<Producto> getProductos()
        {
            return _CoppelMxcontext.Productos
                .Take(20)
                .OrderByDescending(x => x.FiProdId).ToList();
        }
    }
}

