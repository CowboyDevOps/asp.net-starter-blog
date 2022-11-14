using BlogAppWeb.Data;
using BlogAppWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogAppWeb.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;

        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Users> showObjs = _db.Users;
            return View(showObjs);
        }
    }
}
