using Microsoft.AspNetCore.Mvc;

namespace Mypay.web.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
