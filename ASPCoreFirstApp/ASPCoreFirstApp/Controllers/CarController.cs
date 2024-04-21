using ASPCoreFirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPCoreFirstApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            List<CarModel> productList = new List<CarModel>();

            productList.Add(new CarModel(1, "Ford Mustang", 59000.00m, "American Muscle Car"));

            return View(productList);
        }
    }
}
