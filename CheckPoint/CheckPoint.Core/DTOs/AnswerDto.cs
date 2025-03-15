

using CheckPoint.Core.Entities;

namespace ExamAI.Core.DTOs
{
    public class AnswerDto
    {
        //public int Id { get; set; }
        public int ExamId { get; set; }
        //public Exam Exam { get; set; }
        public int QesNumber { get; set; }
        public int Content { get; set; }
        public double Score { get; set; }


     
    }
}
