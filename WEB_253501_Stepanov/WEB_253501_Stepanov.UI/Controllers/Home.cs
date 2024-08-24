using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WEB_253501_Stepanov.UI.Models;

namespace WEB_253501_Stepanov.UI.Controllers
{
    public class Home : Controller
    {
        [ViewData]
        public string LabName { get; set; } = string.Empty;
        public IActionResult Index()
        {
            LabName = "Лабораторная работа №2";
            var items = new List<ListDemo>
            {
            new ListDemo { Id = 1, Name = "Item 1" },
            new ListDemo { Id = 2, Name = "Item 2" },
            new ListDemo { Id = 3, Name = "Item 3" }
            };
            var selectList = new SelectList(items, "Id", "Name");
            ViewBag.Items = selectList;
            return View();
        }
    }
}
