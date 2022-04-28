using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace InventoryOrganizingFinalProject.Controllers
{
    public class StoreController : Controller
    {
        public string Index()
        {
            return "Hello. This is the store page. \nGuitar Brands: ";
        }
        //
        // GET: /Store/Browse
        public string Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = "+ genre);

            return message;
        }
        //
        // GET: /Store/Details
        public string Details(int id)
        {
            string message = "Store.Details, ID = " + id;

            return message;
        }
    }
}
