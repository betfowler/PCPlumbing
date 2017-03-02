using PCPlumbing.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PCPlumbing.Models
{
    public class AdminModel
    {
        private PCPlumbingContext db = new PCPlumbingContext();

        public bool login(string email, string password)
        {
            var getPassword = db.Admins.SingleOrDefault(acc => acc.Username.Equals(email));
            return Hashing.ValidatePassword(password, getPassword.Password);
        }
    }
}