using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Services
{
    public interface IExamService
    {
        Exam GetById(int id);
        //List<Exam> GetByStudentId(int studentId);
        List<Exam> GetByClassAndByTitle(string @class, string title);
        void Add(Exam exam);
    }
}
