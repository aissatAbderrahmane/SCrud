using Microsoft.AspNetCore.Mvc;
using SCrud.Data;
using SCrud.Models;

namespace SCrud.Controllers
{
    public class UserController : Controller
    {

        private readonly AppDataContext context;

        public UserController(AppDataContext context)
        {
            this.context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile(int Id)
        {
            Users user = context.Users.FirstOrDefault(x => x.Id == Id);
            return View(user);
        }
    }
}
