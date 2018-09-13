using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LifestyleDB;
using System.Web.Mvc;

namespace LifeStyles.Areas.Admin.Models
{
    public class GetSetImageData
    {
        public EntityAddImage GetAllData(EntityAddImage objadd)
        {
            using (DairyHubEntities lifstylobjdb = new DairyHubEntities())
            {
                objadd.DDLCategory = new List<SelectListItem>();
                objadd.DDLProduct =  new List<SelectListItem>();

                var cat = from objcat in lifstylobjdb.ProductCategories
                          select new
                          {
                              objcat.Catid,
                              objcat.CatName
                          };

                objadd.DDLCategory.Add(new SelectListItem
                {
                    Text = "Select",
                    Value = "0",
                    Selected = true
                });
                if (cat != null && cat.ToList().Count > 0)
                {


                    for (int i = 0; i < cat.ToList().Count; i++)
                    {
                        objadd.DDLCategory.Add(new SelectListItem
                        {
                            Text = cat.ToList()[i].CatName.ToString(),
                            Value = cat.ToList()[i].Catid.ToString()
                        });
                    }
                }
                objadd.DDLProduct.Add(new SelectListItem
                {
                    Text = "Select",
                    Value = "0",
                    Selected = true
                });

            }
            return objadd;
        }
        public string[] AddUpdateProductCat(EntityAddImage Entaddimg)
        {
            string[] returnValues = new string[2];
            using (DairyHubEntities db = new DairyHubEntities())
            {
                Product objtblpro = new Product();
                objtblpro.Catid = Entaddimg.Catid;
                objtblpro.ProductName = Entaddimg.ProductName;
                db.Products.Add(objtblpro);
                string savevalue = db.SaveChanges().ToString();
                returnValues[0] = "Insert";
                returnValues[1] = objtblpro.Catid.ToString();
            }

            return returnValues;

        }


    }
}