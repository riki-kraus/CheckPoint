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
    public class ExamService: IExamService
    {
        private readonly IExamRepository _examRepository;
        private readonly IRepositoryManager _repositoryManager;

        public ExamService(IExamRepository examRepository, IRepositoryManager repositoryManager) 
        {_examRepository = examRepository;
            _repositoryManager = repositoryManager;
        }

       
        public Exam GetById(int id)
        {
            return _examRepository.GetById(id);
        }
        //מבחן לפי מזהה

        //public List<Exam> GetByStudentId(int studentId)
        //{
        //    return _examRepository.GetByStudentId(studentId);
        //}
        //מבחנים לפי תלמיד

        public List<Exam> GetByClassAndByTitle(string @class, string title)
        {
            return _examRepository.GetByClassAndByTitle(@class,title);
        }
        //מבחן לפי כיתה ולפי נושא: C, ה3
        //??
        public void Add(Exam exam)
        {
            _examRepository.Add(exam);
            _repositoryManager.Save();

        }
    }
}
