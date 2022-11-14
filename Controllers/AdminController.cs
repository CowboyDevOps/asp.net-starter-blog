using Microsoft.AspNetCore.Mvc;

namespace BlogAppWeb.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
