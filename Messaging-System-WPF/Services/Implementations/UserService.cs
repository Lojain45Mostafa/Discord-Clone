using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// UserService.cs
using Messaging_System_WPF.DAL.Interfaces;
using Messaging_System_WPF.DTO;
using Messaging_System_WPF.Services.Interfaces;
using System.Collections.Generic;

namespace Messaging_System_WPF.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<UserDTO> GetUsers()
        {
            // Additional logic or transformations can be performed here
            return userRepository.ReadUsers();
        }

        public void CreateUser(UserDTO user)
        {
            // Additional validation or business logic can be implemented here
            userRepository.CreateUser(user);
        }

        public bool ValidateUserCredentials(string email, string password)
        {
            // Additional logic or transformations can be performed here
            return userRepository.ValidateUserCredentials(email, password);
        }
    }
}
