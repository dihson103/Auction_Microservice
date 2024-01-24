using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using User.Application.Exceptions;
using User.Domain;

namespace User.Application
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public void AddUser(UserRequest userRequest)
        {
            var isUserExist = _userRepository.IsUserExist(userRequest.Id);

            if(isUserExist) throw new UserException((int)HttpStatusCode.BadRequest, $"User has id: {userRequest.Id} is already exist!");

            var user = _mapper.Map<Domain.User>(userRequest);
            user.Role = Role.USER;

            _userRepository.AddUser(user);
        }

        public void ChangePassword(ChangePasswordRequest changePasswordRequest)
        {
            checkUserExist(changePasswordRequest.id);

            // send mail
        }

        public void DeleteUser(string id)
        {
            checkUserExist(id);

            _userRepository.DeleteUser(id);
        }

        public UserResponse GetUser(string id)
        {
            checkUserExist(id);

            var user = _userRepository.GetById(id);
            return _mapper.Map<UserResponse>(user);
        }

        public List<UserResponse> GetUsers()
        {
            var users = _userRepository.GetAllUsers();

            if (users == null || users.Count == 0) throw new UserException((int) HttpStatusCode.NotFound, "Users is empty.");

            var userResponses = _mapper.Map<List<UserResponse>>(users);
            return userResponses;
        }

        public void UpdateUser(UserUpdateRequest userRequest)
        {
            checkUserExist(userRequest.Id);

            var user = _userRepository.GetById(userRequest.Id);
            user.Address = userRequest.Address;
            user.Email = userRequest.Email;
            user.PhoneNumber = userRequest.PhoneNumber;
            _userRepository.UpdateUser(user);
        }

        private void checkUserExist(string id)
        {
            var isUserExist = _userRepository.IsUserExist(id);

            if (isUserExist == false) throw new UserException((int)HttpStatusCode.NotFound, $"User has id: {id} is not found!");
        }
    }
}
