using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeStyles.Models;
using LifestyleDB;
using System.Web.Security;

namespace LifeStyles.Controllers
{
    public class AccountController : Controller
    {
        LifeStyleData lsd = new LifeStyleData();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(login log)
        {
             tblUSer tbl = lsd.LsLib.tblUSers.Where(x => x.emailid.Equals(log.emailid) && x.pass.Equals(log.password)).FirstOrDefault();
            if (tbl != null)
            {
                if (tbl.usertype.Equals("Admin"))  
                    {
                    Session["username"] = tbl.Name;
                    FormsAuthentication.SetAuthCookie(tbl.Name, false);
                    return RedirectToAction("Index", "Admin/AdminHome");
                    }
                if (tbl.usertype.Equals("Client"))
                {
                    Session["username"] = tbl.Name;
                    FormsAuthentication.SetAuthCookie(tbl.Name, false);
                    return RedirectToAction("Index", "Customer/CustomerHome");
                }
            }
            return View();
        }

       

        public ActionResult register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult register(User user)
        {
            if (ModelState.IsValid)
            {
                tblUSer reg = new tblUSer();
                reg.emailid = user.emailid;
                reg.Name = user.name;
                reg.pass = user.password;
                reg.usertype = "Client";
                lsd.LsLib.tblUSers.Add(reg);
                lsd.LsLib.SaveChanges();
            }
            return View();
        }

    }
}