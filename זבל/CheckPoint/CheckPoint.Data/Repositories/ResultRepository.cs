using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class ResultRepository: IResultRepository
    {
        private readonly DataContext _context;
        public ResultRepository(DataContext context)
        {
            _context = context;
        }

        public Result GetById(int id)
        {
            return _context.results.FirstOrDefault(r=>r.Id==id);
        }
        //שליפת התוצאה לפי מזהה

        public List<Result> GetByExamId(int examId)
        {
            return _context.results.Where(r => r.ExamId == examId).ToList();
        }
        //שליפת התוצאות לפי כיתה

        public void Add(Result res)
        {
            _context.results.Add(res);
        }
    }
}
