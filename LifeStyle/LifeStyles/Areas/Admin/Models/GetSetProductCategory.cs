using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LifestyleDB;


namespace LifeStyles.Areas.Admin.Models
{
    public class GetSetProductCategory
    {
        //data display
        public EntityDisplayProductCategory GetallProCat(EntityDisplayProductCategory Objdisplayent)
        {
            using (DairyHubEntities db = new DairyHubEntities())
            {
                //WRITE QUERY FOR FETCHING DATA OF PRODUCT CATEGORY
                var data = (from x in db.ProductCategories
                            select new
                            {
                                x.Catid,
                                x.CatName

                            });





                bool isrecordcontain = data.ToList().Any();
                Objdisplayent.productcatdata = new List<EntityProductCategory>();
                if (isrecordcontain && data.ToList().Count > 0)
                {

                    for (int i = 0; i < data.ToList().Count; i++)
                    {
                        EntityProductCategory OBJENT = new EntityProductCategory();
                        OBJENT.Catid = data.ToList()[i].Catid.ToString();
                        OBJENT.CatName = data.ToList()[i].CatName.ToString();
                        Objdisplayent.productcatdata.Add(OBJENT);


                    }
                }

               
            }

            return Objdisplayent;
        }

        //data insert
        public string[] AddUpdateProductCat(EntityProductCategory EntProCat)
        {
            string[] returnValues = new string[2];
            using (DairyHubEntities db = new DairyHubEntities())
            {
                ProductCategory objtblprocat = new ProductCategory();
                objtblprocat.Catid = EntProCat.Catid;
                objtblprocat.CatName = EntProCat.CatName;
                db.ProductCategories.Add(objtblprocat);
                string savevalue = db.SaveChanges().ToString();
                returnValues[0] = "Insert";
                returnValues[1] = objtblprocat.Catid.ToString();
            }

            return returnValues;

        }

    }
}