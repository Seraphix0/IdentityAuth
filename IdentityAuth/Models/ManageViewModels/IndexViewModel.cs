using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace IdentityAuth.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Salutation;
        public string FirstName;
        public string LastName;
        public DateTime Birth;
        public bool Gender;
        public DateTime JoinDate;
        public double HourPay;
        public int FreeTime;
        public string Email;

        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public string PhoneNumber { get; set; }

        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }
    }
}
