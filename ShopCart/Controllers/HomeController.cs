using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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

        public IActionResult Buy(string id)
        {

            return View();
        }
        //public IActionResult Index()
        //{
        //    var cart = SessionHelper.GetObjectFromJson<List<Producto>>(HttpContext.Session, "cart");
        //    //ViewBag.cart = cart;
        //    //ViewBag.total = cart.Sum(item => item.FnProdPrecio);
        //    return View();
        //}
        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}
