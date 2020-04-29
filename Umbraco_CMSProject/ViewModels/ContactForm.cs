using  System;
using  System.Collections.Generic;
using  System.Web;
using System.Linq;
using System.ComponentModel.DataAnnotations;


namespace Umbraco_CMSProject.ViewModels
{
    public class ContactForm
    {
        [Required(ErrorMessage = "*Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "*Please enter your e-mail")]
        [Display(Name = "Email")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$", ErrorMessage = "*Please enter a correct e-mail address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "*Please enter a subject")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "*Please enter a message")]
        public string Message { get; set; }

    }

}
