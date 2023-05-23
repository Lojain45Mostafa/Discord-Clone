using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messaging_System_WPF.DTO;
using Messaging_System_WPF.model;

namespace Messaging_System_WPF.Controllers.Interfaces
{
    public interface ISignUpController
    {
        void CreateUser(UserDTO userDTO);
    }
}

