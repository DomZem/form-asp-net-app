using form_asp_net_app.Models;
using Microsoft.AspNetCore.Mvc;

namespace form_asp_net_app.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (!ModelState.IsValid)
            {
                return View(user);
            }

            return View("Result", user);
        }

        public IActionResult Result(User user)
        {
            return View(user);
        }
    }
}
