using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounselorClient.Models
{
    class User
    {
        public int RoleId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Majore { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
