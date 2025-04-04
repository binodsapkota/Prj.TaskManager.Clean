using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManager.Core.DTOs;
using TaskManager.Core.Interfaces;

namespace TaskManager.Application.Services
{
    public class UserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<bool> Authenticate(string username, string password)
        {
            throw new NotImplementedException();
        }
        public Task<bool> Register(RegisterDTO dTO)
        {
            throw new NotImplementedException();
        }
    }
}
