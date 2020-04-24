using System;
using System.Collections.Generic;
using System.Text;

namespace RSI.Core.Interfaces
{
    public interface IUserService
    {
        bool Login(string login, string password);
    }
}
