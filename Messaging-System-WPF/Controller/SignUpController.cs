using Messaging_System_WPF.DAL;
using Messaging_System_WPF.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_System_WPF.Controllers
{
    public class SignUpController
    {
        private UserRepository repository;

        public SignUpController(string connectionString)
        {
            repository = new UserRepository(connectionString);
        }

        public void CreateUser(string name, string email, string password, string profile_picture)
        {
            // Additional validation or business logic can be implemented here
             repository.CreateUser(name, email, password, profile_picture);
        }


    }
}
