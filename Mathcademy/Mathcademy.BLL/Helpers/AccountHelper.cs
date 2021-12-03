using Mathcademy.Domain.IHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mathcademy.BLL.Helpers
{
    public class AccountHelper : IAccountHelper
    {
        public string EncodeThePasword(string password)
        {
            return "true";
        }
    }
}
