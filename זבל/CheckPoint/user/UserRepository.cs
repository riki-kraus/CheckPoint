using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public  UserRepository(DataContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.users;
        }

        public User GetUserById(int id)
        {
            return _context.users.FirstOrDefault(u => u.Id == id);
        }
        public List<User> GetUsersByClass(string @class)
        {
            return _context.users.Where(u => u.Class == @class).ToList();
        }
        
        public void Add(User user)
        {
            _context.users.Add(user);
        }
    }
}
