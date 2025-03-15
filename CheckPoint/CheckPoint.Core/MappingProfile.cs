using AutoMapper;
using CheckPoint.Core.Entities;
using ExamAI.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Exam, ExamDto>().ReverseMap();
            CreateMap<Answer, AnswerDto>().ReverseMap();
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Submission, SubmissionDto>().ReverseMap();
            CreateMap<Manager, ManagerDto>().ReverseMap();
        }
    }
}
