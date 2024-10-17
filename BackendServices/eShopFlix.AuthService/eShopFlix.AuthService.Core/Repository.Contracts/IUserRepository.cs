using eShopFlix.AuthService.Core.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopFlix.AuthService.Core.Repository.Contracts
{
    public interface IUserRepository
    {
        User LogInUser(string email, string password);
        bool RegisterUser(User user, Role role);
    }
}
