using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class ExamRepository: IExamRepository
    {

        private readonly DataContext _context;
        public ExamRepository(DataContext context)
        {
            _context = context;
        }


        public Exam GetById(int id)
        {
            return _context.Exams.FirstOrDefault(e => e.Id == id);
        }
        //מבחן לפי מזהה

        //public List<Exam> GetByStudentId(int studentId)
        //{
        //    return _context.exams.Where(e => e.StudentId == studentId).ToList();
        //}
        //מבחנים לפי תלמיד

        public List<Exam> GetByClassAndByTitle(string @class,string title)
        {
            return _context.Exams.Where(e=>e.Class==@class&&e.Title==title).ToList();
        }
        //מבחן לפי כיתה ולפי נושא: C, ה3
        //??
        public void Add(Exam exam)
        {
            _context.Exams.Add(exam);
        }
    }
}
