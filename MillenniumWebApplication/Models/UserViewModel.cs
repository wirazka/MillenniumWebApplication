using System.ComponentModel.DataAnnotations;

namespace MillenniumWebApplication.Models
{
    public class UserViewModel
    {
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Only letters are allowed")]
        [StringLength(30, ErrorMessage = "Nickname should contain max 30 characters")]
        [Display(Name = "Nickname")]
        public string Nickname { get; set; }
        
        [EmailAddress]
        [Display(Name = "E-mail address ")]
        public string EmailAddress { get; set; }
    }
}