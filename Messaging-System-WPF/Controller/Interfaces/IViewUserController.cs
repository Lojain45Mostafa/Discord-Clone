using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messaging_System_WPF.model;
using System.Collections.Generic;

namespace Messaging_System_WPF.Controllers.Interfaces
{
    public interface IViewUserController
    {
        List<User> ReadUsers();
    }
}

