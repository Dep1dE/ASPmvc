using Microsoft.AspNetCore.Mvc;

namespace WEB_253501_Stepanov.UI.Controllers
{
    public class Account : Controller
    {
        public IActionResult LogOut()
        {
            return View();
        }
    }
}
