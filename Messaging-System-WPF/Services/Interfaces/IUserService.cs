using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messaging_System_WPF.DTO;

namespace Messaging_System_WPF.Services.Interfaces
{
    public interface IUserService
    {
        List<UserDTO> GetUsers();
        void CreateUser(UserDTO user);
        bool ValidateUserCredentials(string email, string password);
    }
}
