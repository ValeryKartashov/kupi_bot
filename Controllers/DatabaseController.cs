using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KupiCore.Controllers
{
    public class DatabaseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
