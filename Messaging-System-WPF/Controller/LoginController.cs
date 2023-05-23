using Messaging_System_WPF.DAL;
using Messaging_System_WPF.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging_System_WPF.controller
{
    public class LoginController
    {
        private UserRepository userRepository;

        public LoginController(string connectionString)
        {
            userRepository = new UserRepository(connectionString);
        }

        //public void CreateUser(User user)
        //{
        //    userRepository.CreateUser(user);
        //}

        public bool LoginUser(string email, string password)
        {
            return userRepository.ValidateUserCredentials(email, password);
        }
    }

}
