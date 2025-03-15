using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }
        public List<Student> GetAll()
        {
            return _context.students.ToList();
        }
        public Student GetById(int id)
        {
            return _context.students.FirstOrDefault(r => r.Id == id);
        }
        //שליפת התוצאה לפי מזהה

        public Student GetByName(string name)
        {
            return _context.students.FirstOrDefault(r => r.UserName == name);
        }
        //שליפת התוצאות לפי כיתה
        public List<Student> GetByClass(string @class)
        {
            return _context.students.Where(s => s.Class == @class).ToList();
        }
        public void Add(Student student)
        {
            _context.students.Add(student);
        }

    }
}
