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
    public class AnswerService: IAnswerService
    {
        private readonly IAnswerRepository _answerRepository;

        public AnswerService(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }
        public Answer GetAnsById(int id)
        {
            return _answerRepository.GetAnsById(id);
        }
        //קבלת תשובה מסוימת

        public List<Answer> GetAnsByExam(int examId)
        {
            return _answerRepository.GetAnsByExam(examId);
        }
        //קבלת כל התשובות של מבחן מסוים
        public Answer GetAnsByExamAndNum(int examId, int numAns)
        {
            return _answerRepository.GetAnsByExamAndNum(examId,numAns);
        }
        //קבלת תשובה מסוימת של מבחן מסוים
    }
}
