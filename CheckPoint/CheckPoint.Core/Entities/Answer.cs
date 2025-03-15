using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Entities
{
    public class Answer
    {
        public int Id { get; set; }
        public int QesNumber { get; set; }
        public int Content { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }

        //הכלה?
        public double Score { get; set; }

       public Answer() { }

        public Answer(int id, int qesNumber, int content, int examId, Exam exam, double score)
        {
            Id = id;
            QesNumber = qesNumber;
            Content = content;
            ExamId = examId;
            Exam = exam;
            Score = score;
        }
    }
}
