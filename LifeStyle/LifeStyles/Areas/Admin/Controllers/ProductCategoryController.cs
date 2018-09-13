using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeStyles.Areas.Admin.Models;

namespace LifeStyles.Areas.Admin.Controllers
{
    public class ProductCategoryController : Controller
    {
        // GET: Admin/ProductCategory
        public ActionResult Display()
        {
            GetSetProductCategory getsetprocat = new GetSetProductCategory();
            EntityDisplayProductCategory objentprocat = new EntityDisplayProductCategory();

            objentprocat = getsetprocat.GetallProCat(objentprocat);

            return View(objentprocat);
        }
        [HttpPost]
        public ActionResult Display( string Catid)
        {
            return View();
        }



        public ActionResult Manage(string Catid)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Manage(EntityProductCategory EnProductCat)
        {
            GetSetProductCategory getsetprocat = new GetSetProductCategory();
            if(ModelState.IsValid)
            {
                string[] Returnvalue = new string[2];

                Returnvalue = getsetprocat.AddUpdateProductCat(EnProductCat);
                if(Returnvalue[0]=="Insert")
                {
                    ViewBag.Message = "Record has been successfully submitted!";
                }


            }

            return View();
        }
    }
}