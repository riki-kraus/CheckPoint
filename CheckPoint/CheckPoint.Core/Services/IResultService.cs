using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Services
{
    public interface IResultService
    {
        Result GetById(int id);
        List<Result> GetByExamId(int examId);
    }
}
