using Microsoft.AspNetCore.Mvc;
using ShopCart.Helpers;
using ShopCart.Models;
using ShopCart.Services;
using System.Collections.Generic;
using System.Linq;

namespace ShopCart.Controllers
{
    public class CartController : Controller
    {
        private readonly IBuyRepository _buyRepository;
        public CartController(IBuyRepository buyRepository)
        {
            buyRepository = _buyRepository;
        }

        public IActionResult Index()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Producto>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;
            ViewBag.total = cart.Sum(item => item.FnProdPrecio);
            return View();
        }


    }
}

