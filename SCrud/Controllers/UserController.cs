using Microsoft.AspNetCore.Mvc;

namespace SCrud.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
