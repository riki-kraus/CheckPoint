using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.IRepositories
{
    public interface IResultRepository
    {
        Result GetById(int id);
        List<Result> GetByExamId(int examId);
    }
}
