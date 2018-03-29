using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace IdentityAuth.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string Salutation;
        public string FirstName;
        public string LastName;
        public string Gender;
        public DateTime JoinDate;
        public int HourPay;
        public int FreeTime;
    }
}
