using System;
using System.Collections.Generic;
using System.Text;

namespace OnTheWay_Models.Users
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public DateTime CreatedOnUTC { get; set; }

        public DateTime LastLoginDate { get; set; }

        public DateTime? LastPasswordChangeDate { get; set; }

        public int Age { get; set; }

        //public Address Address { get; set; }
    }
}
