using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User.Domain;

namespace User.Application
{
    public interface IUserService
    {
        List<UserResponse> GetUsers();
        UserResponse GetUser(string id);
        void AddUser(UserRequest userRequest);
        void UpdateUser(UserUpdateRequest userRequest);
        void DeleteUser(string id);
        void ChangePassword(ChangePasswordRequest changePasswordRequest);
    }
}
