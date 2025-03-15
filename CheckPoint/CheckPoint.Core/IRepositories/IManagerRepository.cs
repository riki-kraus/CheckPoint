using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.IRepositories
{
    public interface IManagerRepository
    {
        List<Manager> GetAll();
        Manager GetById(int id);
        void Add(Manager manager);
    }
}
