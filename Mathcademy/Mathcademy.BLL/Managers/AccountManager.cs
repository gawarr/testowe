using Mathcademy.Domain.IHelpers;
using Mathcademy.Domain.IManagers;
using Mathcademy.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mathcademy.BLL.Managers
{
    public class AccountManager : IAccountManager
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IAccountHelper _accountHelper;

        public AccountManager(IAccountRepository accountRepository, IAccountHelper accountHelper)
        {
            _accountRepository = accountRepository;
            _accountHelper = accountHelper;
        }

        public bool SingIn(string login, string password)
        {
            return _accountRepository.SingIn(login, password);
        }
    }
}
