using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LifeStyles.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        [Authorize] 
        // GET: Admin/Home
        public ActionResult Index()
        {
            if(Session["username"] != null)
            {
                ViewBag.name = Session["username"];
            }
            return View();
        }

        public ActionResult logoff()
        {
            Session.Abandon();
            Session.RemoveAll();
            FormsAuthentication.SignOut();

            return RedirectToAction("Login", "Account", new { area = "" });
        }
    }
}