using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using System.Text;
using LifeStyles.Areas.Admin.Models;
using LifestyleDB;

namespace LifeStyles.Areas.Admin.Controllers
{
    public class AddImageController : Controller
    {
        // GET: Admin/AddImage
        
        public ActionResult Index()
        {
            GetSetImageData getset = new GetSetImageData();
            EntityAddImage objentity = new EntityAddImage();
            objentity = getset.GetAllData(objentity);
            return View(objentity);
        }
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if( file!=null && file.ContentLength>0)
            {
                string filename = Path.GetFileName(file.FileName);
                string target = Path.Combine(Server.MapPath("~/img"), filename);
                file.SaveAs(target);
                ViewBag.msg = "Image Saved!!!";
            }
            else
            {
                ViewBag.msg = "Image not saved!!!";
            }
            return View();
        }
        public ActionResult ProductJSON(string idd)
        {

            if (idd.ToString() == "Select")
            {
                idd = "0";

            }
            DairyHubEntities objEntity = new DairyHubEntities();

            IEnumerable<SelectListItem> DDLList = new List<SelectListItem>();
            string id = idd;
            DDLList = (from objP in objEntity.Products where objP.Catid == id select objP).AsEnumerable().Select(p => new SelectListItem() { Text = p.ProductName, Value = p.Proid.ToString() }).OrderBy(b => b.Text);

            return Json(DDLList);
        }

    }
}