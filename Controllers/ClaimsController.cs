using Microsoft.AspNetCore.Mvc;

namespace CMCS.Controllers
{
    public class ClaimsController : Controller
    {
        public IActionResult Index() => View();
        public IActionResult Submit() => View();
        public IActionResult Approvals() => View(); // admin view
    }
}
