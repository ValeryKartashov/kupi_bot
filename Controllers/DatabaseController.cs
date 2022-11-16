using Bot.Models.ModelsDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KupiCore.Controllers
{
    public class DatabaseController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddCategory(string name, string description)
        {
            using (var db = new BotDbContext())
            {
                db.ChangeTracker.Clear();
                db.ProductCategories.Add(new ProductCategory
                {
                    Name = name,
                    Description = description
                });
                db.SaveChanges();
                return View("~/Pages/Database/Index.cshtml");
            }
        }
    }
}
