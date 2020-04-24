using RSI.Core.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace RSI.Core.Services
{
    class UserService : IUserService
    {
        private readonly IList<User> users = new List<User>
        {
           new User{Login = "admin", Password ="admin" },
            new User{Login = "user", Password ="user" }
        };


        public bool Login(string login, string password)
        {
            return users.Any(x => x.Login == login && x.Password == password);
        }
    }

    class User
    {
        public string Login { get; set; }

        public string Password { get; set; }
    }
}
