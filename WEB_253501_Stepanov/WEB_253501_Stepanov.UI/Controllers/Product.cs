using Microsoft.AspNetCore.Mvc;

namespace WEB_253501_Stepanov.UI.Controllers
{
    public class Product : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
