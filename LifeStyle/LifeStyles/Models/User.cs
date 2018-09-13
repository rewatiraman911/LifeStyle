using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace LifeStyles.Models
{
    public class User
    {
        [Key]

        [Required(ErrorMessage ="Can not left blank")]
        public string emailid { get; set; }

        [Required(ErrorMessage = "Can not left blank")]
        public string name { get; set; }

        [Required(ErrorMessage = "Can not left blank")]
        public string password { get; set; }
        public string usertype { get; set; }
    }

    public class login
    {
        [Required(ErrorMessage = "Can not left blank")]
        public string emailid { get; set; }

        [Required(ErrorMessage = "Can not left blank")]
        public string password { get; set; }

        public string usertype { get; set; }

    }  
}