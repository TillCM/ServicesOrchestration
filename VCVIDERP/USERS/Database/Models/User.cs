using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace USERS.Database.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastNme  { get; set; }
        public string  Faculty { get; set; }

        public string Role { get; set; }
    }
}
