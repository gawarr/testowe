using System;
using System.Collections.Generic;
using System.Text;

namespace Mathcademy.Domain.IRepositories
{
    public interface IAccountRepository
    {
        bool SingIn(string login, string password);
    }
}
