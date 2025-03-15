using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class SubmissionRepository: ISubmissionRepository
    {
        private readonly DataContext _context;

        public SubmissionRepository(DataContext context)
        {
            _context = context;
        }

        public Submission GetById(int id)
        {
            return _context.Submissions.FirstOrDefault(r=>r.Id==id);
        }

        //שליפת התוצאה לפי מזהה

        public List<Submission> GetByExamId(int examId)
        {
            return _context.Submissions.Where(r => r.ExamId == examId).ToList();
        }
        //שליפת התוצאות לפי כיתה

        public void Add(Submission res)
        {
            _context.Submissions.Add(res);
        }
    }
}
