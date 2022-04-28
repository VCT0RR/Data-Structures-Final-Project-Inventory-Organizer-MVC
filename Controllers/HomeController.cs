using Microsoft.AspNetCore.Mvc;
using InventoryOrganizingFinalProject.Models;

namespace InventoryOrganizingFinalProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
        }
    }
}
