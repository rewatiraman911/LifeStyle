using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeStyles.Areas.Admin.Models
{
    public class EntityAddImage
    {
        public int id { get; set; }
        public string filename { get; set; }
        public string Proid { get; set; }
        public string ProductName { get; set; }
        public string Catid{ get; set; }
        public string CategoryName { get; set; }
        public List<SelectListItem> DDLProduct { get; set; }

        public List<SelectListItem> DDLCategory { get; set; }
    }
}