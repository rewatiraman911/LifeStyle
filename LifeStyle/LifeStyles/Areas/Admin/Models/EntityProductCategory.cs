using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeStyles.Areas.Admin.Models
{
    public class EntityProductCategory
    {
        [Required(ErrorMessage = "Can not left blank")]
        public string Catid { get; set; }

        [Required(ErrorMessage = "Can not left blank")]
        public string CatName { get; set; }
    }

//    {
//        public List<EntityProductCategory> productcatdata { get; set; }

//        public string Catid { get; set; }

//        public string CatName { get; set; }

//    }
}