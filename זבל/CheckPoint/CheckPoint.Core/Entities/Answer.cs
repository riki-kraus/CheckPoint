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
        public int NumAns { get; set; }
        public int Content { get; set; }
        public int ExamId { get; set; }
        //הכלה?
        public double Score { get; set; }

        public Answer(int id, int numAns, int content, int examId, double score)
        {
            Id = id;
            NumAns = numAns;
            Content = content;
            ExamId = examId;
            Score = score;
        }
    }
}
