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
    }
}
