using Messaging_System_WPF.DAL;
using Messaging_System_WPF.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_System_WPF.Controller
{
    public class ViewUserController
    {
        private UserRepository repository;

        public ViewUserController(string connectionString)
        {
            repository = new UserRepository(connectionString);
        }

        public List<User> ReadUsers()
        {
            return repository.ReadUsers();
        }
    }
}
