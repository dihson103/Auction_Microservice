using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Application
{
    public interface IUserRepository
    {
        List<User.Domain.User> GetAllUsers();
        User.Domain.User GetById(string id);
        void AddUser (User.Domain.User user);
        void UpdateUser (User.Domain.User user); 
        void DeleteUser (string id);
        bool IsUserExist(string id);
    }
}
