using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Services
{
    public interface IStudentService
    {
        List<Student> GetAll();
        Student GetById(int id);
        Student GetByName(string name);
        void Add(Student student);
        List<Student> GetByClass(string @class);
    }
}
