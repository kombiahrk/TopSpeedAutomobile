using Microsoft.AspNetCore.Mvc;

namespace TopSpeed.Web.Controllers
{
    public class BrandController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
