using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Application;
using User.Domain;

namespace User.Infrastructure
{
    public class UserRepository : IUserRepository
    {
        private readonly UserDbContext _context;

        public UserRepository(UserDbContext context)
        {
            _context = context;
        }

        public void AddUser(Domain.User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void DeleteUser(string id)
        {
            var user = GetById(id);
            user.Status = false;
            UpdateUser(user);
        }

        public List<Domain.User> GetAllUsers()
        {
            var users = _context.Users.ToList();
            return users;
        }

        public Domain.User GetById(string id)
        {
            var user = _context.Users.SingleOrDefault(u => u.Id == id);
            return user;
        }

        public bool IsUserExist(string id)
        {
            return _context.Users.Any(user => user.Id == id);  
        }

        public void UpdateUser(Domain.User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }
    }
}
