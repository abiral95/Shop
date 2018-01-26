using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public string Index()
        {
            return "Hello from Index";
        }
        public string Browse(string category)
        {
            string message = HttpUtility.HtmlEncode("showing category " + category);
            return message;
        }
        public ActionResult Details(int id)
        {
            var Item = new Item { Title = "Item" + id };
            return View(Item);
        }
    }
}