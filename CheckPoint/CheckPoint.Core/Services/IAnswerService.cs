using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Services
{
    public interface IAnswerService
    {
        Answer GetAnsById(int id);
        List<Answer> GetAnsByExam(int examId);
        Answer GetAnsByExamAndNum(int examId, int numAns);
    }
}
