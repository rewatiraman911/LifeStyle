using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeStyles.Models;
using LifestyleDB;

namespace LifeStyles.Areas.Admin.Controllers
{
    public class AdminJobController : Controller
    {
        LifeStyleData dbData = new LifeStyleData();

        public ActionResult Index()
        {
            var tblstate = from temp in dbData.LsLib.ProductCategories
                          select temp;
            List<CategoryData> category_list = new List<CategoryData>(); 
            foreach(var data in tblstate)
            {
                category_list.Add(new CategoryData { Catid = data.Catid, CatName = data.CatName });
            }
            return View(category_list);
        }







        // GET: Admin/AdminJob
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(CategoryData category)
        {
            if (ModelState.IsValid)
            {
                ProductCategory procat = new ProductCategory();
                procat.Catid = category.Catid;
                procat.CatName = category.CatName;
                dbData.LsLib.ProductCategories.Add(procat);
                dbData.LsLib.SaveChanges();
                return RedirectToAction("Index", "AdminJob", new { Area = "Admin" });
            }
            return View();
        }
    }
}