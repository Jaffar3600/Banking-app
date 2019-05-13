using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Banking.Models
{
    public class User
    {
        public int UserId { get; set; }
        public int UserName { get; set; }
        public int Password { get; set; }
        public int Role { get; set; }
    }
}