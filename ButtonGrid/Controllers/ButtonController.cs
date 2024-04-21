using Microsoft.AspNetCore.Mvc;

namespace ButtonGrid.Controllers
{
    public class ButtonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
