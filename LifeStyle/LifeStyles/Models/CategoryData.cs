using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LifeStyles.Models
{
    public class CategoryData
    {
        [Required(ErrorMessage ="Can not left blank.")]
        [Display(Name ="CategoryId")]
        public string Catid { get; set; }
        [Required(ErrorMessage="Can not left blank.")]
        [Display(Name ="CategoryName")]
        public string CatName { get; set; }

    }
    
    public class Product
    {
        public string Proid { get; set; }
        public string Catid { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public Nullable<int> Quantity { get; set; }
        public int isActive { get; set; }
    }

}