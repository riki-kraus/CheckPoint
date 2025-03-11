using CheckPoint.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Data
{
    public class DataContext

    {
        public List<User> users { get; set; }= new List<User>();
        public List<Exam> exams { get; set; } = new List<Exam>();
        public List<Result> results { get; set; } = new List<Result>();
        public List<Answer> answers { get; set; }=new List<Answer>();


    }
}

