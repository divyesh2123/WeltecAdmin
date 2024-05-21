using Microsoft.AspNetCore.Mvc;

namespace WeltecAdmin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
