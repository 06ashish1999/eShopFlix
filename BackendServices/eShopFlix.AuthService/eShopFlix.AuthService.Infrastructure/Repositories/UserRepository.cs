using eShopFlix.AuthService.Core.Database.Entities;
using eShopFlix.AuthService.Core.Repository.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopFlix.AuthService.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User LogInUser(string email, string password)
        {
            throw new NotImplementedException();
        }

        public bool RegisterUser(User user, Role role)
        {
            throw new NotImplementedException();
        }
    }
}
