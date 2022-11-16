using Microsoft.AspNetCore.Mvc;

namespace KupiCore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RunBot()
        {
            Bot.BotRunner.Main();
            return new OkResult();
        }
    }
}
