using System;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityAuth.Models.AccountViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityAuth.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        //        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        //        {
        //            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
        //            var userIdentity = await manager.AddClaimAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
        //            // Add custom user claims here => this.OrganizationId is a value stored in database against the user
        //            userIdentity.AddClaim(new Claim("OrganizationId", this.OrganizationId.ToString()));
        //
        //            return userIdentity;
        //        }

        public string Salutation { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public bool Gender { get; set; }
        public DateTime JoinDate { get; set; }
        public double HourPay { get; set; }
        public int FreeTime { get; set; }

        public ApplicationUser()
        {
            //Empty constructor
        }

        public ApplicationUser(RegisterViewModel model)
        {
            Salutation = model.Salutation;
            FirstName = model.FirstName;
            LastName = model.LastName;
            Birth = model.Birth;
            Gender = model.Gender;
            JoinDate = DateTime.Now;
            HourPay = model.HourPay;
            FreeTime = model.FreeTime;
            //van IdentityUser class
            UserName = model.Email;
            Email = model.Email;
        }
    }
}
