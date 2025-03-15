using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetUserById(int id);
        List<User> GetUsersByClass(string @class);
       void Add(User user);
    }
}
