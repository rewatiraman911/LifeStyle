using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeStyles.Areas.Customer.Controllers
{
    public class CustomerHomeController : Controller
    {
        // GET: Customer/CustomerHome
        public ActionResult Index()
        {

            if (Session["username"] != null)
            {
                ViewBag.name = Session["username"];
            }
            return View();
        }
    }
}