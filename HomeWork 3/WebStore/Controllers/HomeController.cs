using Microsoft.AspNetCore.Mvc;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Blog() => View();

        public IActionResult BlogSingle() => View();

        public IActionResult Cart() => View();

        public IActionResult CheckOut() => View();

        public IActionResult ContactUs() => View();

        public IActionResult Login() => View();

        public IActionResult Products() => View();

        public IActionResult ProductDetails() => View();

        public IActionResult Shop() => View();

        public IActionResult ErrorPage404() =>
            RedirectToAction("HttpStatusCodeHandler", "Error", new {statusCode = 404});
    }
}