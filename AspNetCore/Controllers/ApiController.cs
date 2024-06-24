using AspNetCore.Views.Game;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public class ApiController : Controller
    {
        private readonly IProfile _profile;

        public ApiController(IProfile profile)
        {
            _profile = profile;
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            if (_profile.ValidatePassword(username, password))
            {
                return RedirectToAction("Success");
            }
            else
            {
                return RedirectToAction("Failure");
            }
        }

        public IActionResult Success()
        {
            return View();
        }

        public IActionResult Failure()
        {
            return View();
        }
    }
}
