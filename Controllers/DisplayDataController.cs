using Microsoft.AspNetCore.Mvc;

namespace WeltecAdmin.Controllers
{
    public class DisplayDataController : Controller
    {
        public IActionResult GetData()
        {
            NORTHWNDContext nORTHWNDContext = new NORTHWNDContext();    

            var cat = nORTHWNDContext.Categories.ToList();
            return Json(new { data = cat });
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
