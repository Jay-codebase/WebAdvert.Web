using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAdvert.Web.Models.Accounts
{
    public class ConfirmModel
    {
        [Required(ErrorMessage ="Email address is required!!")]
        [EmailAddress]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Code is required!!")]
        [Display(Name ="Code")]
        public string Code { get; set; }

    }
}
