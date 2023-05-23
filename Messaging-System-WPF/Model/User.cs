using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_System_WPF.model
{
    public class User
    {
        public User(string name, string email, string password, string profile_picture)
        {
            Name = name;
            Email = email;
            Password = password;
            this.profile_picture = profile_picture;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string profile_picture { get; set; }
    }
}
