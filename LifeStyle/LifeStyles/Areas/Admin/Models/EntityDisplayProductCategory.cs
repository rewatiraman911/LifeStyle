using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LifeStyles.Areas.Admin.Models;

namespace LifeStyles.Areas.Admin.Models
{
    public class EntityDisplayProductCategory
    {
        public string Catid { get; set; }
              

        public List<EntityProductCategory> productcatdata { get; set; }
    }
}