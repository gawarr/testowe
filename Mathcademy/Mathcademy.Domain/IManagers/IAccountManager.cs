using System;
using System.Collections.Generic;
using System.Text;

namespace Mathcademy.Domain.IManagers
{
    public interface IAccountManager
    {
        bool SingIn(string login, string password);
    }
}
