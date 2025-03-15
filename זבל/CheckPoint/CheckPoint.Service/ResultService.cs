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
    public class ResultService: IResultService
    {
        private readonly IResultRepository _resultRepository;

        public ResultService(IResultRepository resultRepository)
        {
            _resultRepository = resultRepository;
        }
        public Result GetById(int id)
        {
            return _resultRepository.GetById(id);
        }
        //שליפת התוצאה לפי מזהה

        public List<Result> GetByExamId(int examId)
        {
            return _resultRepository.GetByExamId(examId);
        }
        //שליפת התוצאות לפי כיתה
        public void Add(Result result)
        {
            _resultRepository.Add(result);
        }
    }
}
