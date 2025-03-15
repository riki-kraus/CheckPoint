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
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll();
        }
        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }
        //שליפת התוצאה לפי מזהה

        public Student GetByName(string name)
        {
            return _studentRepository.GetByName(name);
        }
        public List<Student> GetByClass(string @class)
        {
            return _studentRepository.GetByClass(@class);
        }
        
        //שליפת התוצאות לפי כיתה
        public void Add(Student student)
        {
            _studentRepository.Add(student);
        }
    }
}
