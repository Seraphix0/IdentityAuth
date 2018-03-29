using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityAuth.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Salutation")]
        public string Salutation { get; set; }

        [Required]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "LastName")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public bool Gender { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birth")]
        public DateTime Birth { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "JoinDate")]
        public bool JoinDate { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "JoinDate")]
        public int HourPay { get; set; }

        [Required]
        [Display(Name = "FreeTime")]
        public int FreeTime { get; set; }
    }
}
