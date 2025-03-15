using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class ManagerRepository: IManagerRepository
    {
        private readonly DataContext _context;
        public ManagerRepository(DataContext context)
        {
            _context = context;
        }

        public List<Manager>GetAll()
        {
            return _context.managers.ToList();
        }
        public Manager GetById(int id)
        {
            return _context.managers.FirstOrDefault(r => r.Id == id);
        }
        //שליפת התוצאה לפי מזהה

       

        public void Add(Manager manager)
        {
            _context.managers.Add(manager);
        }

    }
}
