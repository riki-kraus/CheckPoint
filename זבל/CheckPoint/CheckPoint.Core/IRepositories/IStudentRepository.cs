using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.IRepositories
{
    public interface IStudentRepository
    {
        List<Student> GetAll();
        Student GetById(int id);

        Student GetByName(string name);
        List<Student> GetByClass(string @class);
        void Add(Student student);
    }
}
