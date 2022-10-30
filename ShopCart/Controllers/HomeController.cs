using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ShopCart.Models;
using ShopCart.Services;

namespace ShopCart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IShopRepository _shopRepository;

        public HomeController(ILogger<HomeController> logger, IShopRepository shopRepository)
        {
            _logger = logger;
            _shopRepository = shopRepository;
        }

        public IActionResult Index()
        {
            return View(_shopRepository.getProductos());
        }

        //public IActionResult AddToCart(string id)
        //{

        //    return new EmptyResult();
        //}

        //public RedirectToActionResult AddToCart(string id, string returnUrl)
        //{
        //    string emp = string.Empty;
        //    return RedirectToAction("Index", new { returnUrl });
        //}

        public ActionResult AddToCart(ProductoRequestDTO item)
        {
            //var cart = sessionhelper.getobjectfromjson<list<producto>>(httpcontext.session, "cart");
            //viewbag.cart = cart;
            //viewbag.total = cart.sum(item => item.fnprodprecio);
            return new EmptyResult();
        }
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
