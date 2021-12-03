using Mathcademy.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mathcademy.DAL.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public bool SingIn(string login, string password)
        {
            return true;
        }
    }
}
