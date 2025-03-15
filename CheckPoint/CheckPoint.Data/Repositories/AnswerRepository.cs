using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data.Repositories
{
    public class AnswerRepository: IAnswerRepository
    {
        private readonly DataContext _context;
        public AnswerRepository(DataContext context)
        {
            _context = context;
        }

        public Answer GetAnsById(int id)
        {
            return _context.Answers.FirstOrDefault(a => a.Id==id);
        }
        //קבלת תשובה מסוימת

        public List<Answer> GetAnsByExam(int examId)
        {
            return _context.Answers.Where(a=>a.ExamId== examId).ToList();
        }
        //קבלת כל התשובות של מבחן מסוים
        public Answer GetAnsByExamAndNum(int examId,int qesNumber)
        {
            return _context.Answers.FirstOrDefault(a => a.ExamId == examId&&a.QesNumber == qesNumber);
        }
        //קבלת תשובה מסוימת של מבחן מסוים
        public void Add(Answer answer)
        {
            _context.Answers.Add(answer);
        }
    }
}
