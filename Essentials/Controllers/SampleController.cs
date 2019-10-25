using Microsoft.AspNetCore.Mvc;

namespace Essentials.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}