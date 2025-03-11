﻿using CheckPoint.Core.Entities;
using CheckPoint.Core.IRepositories;
using CheckPoint.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Service
{
    public class ExamService: IExamService
    {
        private readonly IExamRepository _examRepository;

        public ExamService(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }
        public Exam GetById(int id)
        {
            return _examRepository.GetById(id);
        }
        //מבחן לפי מזהה

        public List<Exam> GetByStudentId(int studentId)
        {
            return _examRepository.GetByStudentId(studentId);
        }
        //מבחנים לפי תלמיד

        public List<Exam> GetByClassAndByTitle(string @class, string title)
        {
            return _examRepository.GetByClassAndByTitle(@class,title);
        }
        //מבחן לפי כיתה ולפי נושא: C, ה3
        //??
    }
}
