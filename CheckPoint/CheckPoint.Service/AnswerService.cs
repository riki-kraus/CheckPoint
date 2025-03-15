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
        private readonly IRepositoryManager _repositoryManager;

        public AnswerService(IAnswerRepository answerRepository, IRepositoryManager repositoryManager) 
        {    _answerRepository = answerRepository;
            _repositoryManager = repositoryManager;
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
        public void Add(Answer answer)
        {
            _answerRepository.Add(answer);
            _repositoryManager.Save();

        }
    }
}
