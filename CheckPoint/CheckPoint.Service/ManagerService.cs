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
    public class ManagerService: IManagerService
    {
        private readonly IManagerRepository _managerRepository;
      private readonly  IRepositoryManager _repositoryManager;
        public ManagerService(IManagerRepository managerRepository, IRepositoryManager repositoryManager)
        {
            _managerRepository = managerRepository;
            _repositoryManager = repositoryManager;
        }
        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }
        public Manager GetById(int id)
        {
            return _managerRepository.GetById(id);
        }
        //שליפת התוצאה לפי מזהה



        public void Add(Manager manager)
        {
            _managerRepository.Add(manager);
            _repositoryManager.Save();

        }

    }
}
