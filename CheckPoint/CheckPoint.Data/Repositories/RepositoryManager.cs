using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public IAnswerRepository Answers { get; }
        public IExamRepository Exams { get; }
        public ISubmissionRepository Submissions { get; }
        public IManagerRepository Managers { get; }
        public IStudentRepository Students { get; }

        public RepositoryManager(DataContext context, IAnswerRepository answerRepository, IExamRepository examRepository,
          ISubmissionRepository SubmissionRepository, IManagerRepository managerRepository, IStudentRepository studentRepository)
        {
            _context = context;
            Answers = answerRepository;
            Exams = examRepository;
            Submissions = SubmissionRepository;
            Managers = managerRepository;
            Students = studentRepository;

        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
