using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using CheckPoint.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Service
{
    public class UserService: IUserService
    {
        private  readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User>GetAll()
        {
            return _userRepository.GetAll();
        }
     

        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }
        public List<User> GetUsersByClass(string @class)
        {
            return _userRepository.GetUsersByClass(@class);
        }
        public void Add(User user)
        {
            _userRepository.Add(user);
        }
    }
}
