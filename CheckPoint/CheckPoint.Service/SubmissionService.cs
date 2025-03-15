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
    public class SubmissionService: ISubmissionService
    {
        private readonly ISubmissionRepository _SubmissionRepository;
        private readonly IRepositoryManager _repositoryManager;

        public SubmissionService(ISubmissionRepository SubmissionRepository, IRepositoryManager repositoryManager)
        {
            _SubmissionRepository = SubmissionRepository;
            _repositoryManager = repositoryManager;
        }
        public Submission GetById(int id)
        {
            return _SubmissionRepository.GetById(id);
        }
        //שליפת התוצאה לפי מזהה

        public List<Submission> GetByExamId(int examId)
        {
            return _SubmissionRepository.GetByExamId(examId);
        }
        //שליפת התוצאות לפי כיתה
        public void Add(Submission Submission)
        {
            _SubmissionRepository.Add(Submission);
            _repositoryManager.Save();

        }
    }
}
