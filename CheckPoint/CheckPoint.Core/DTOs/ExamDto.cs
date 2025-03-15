

using CheckPoint.Core.Entities;

namespace ExamAI.Core.DTOs
{
    public class ExamDto
    {
        //public int Id { get; set; }
        public string Class { get; set; }
        public string Subject { get; set; }
        public string Title { get; set; }
        public DateTime DateCreated { get; set; }

        //public List<Answer> Answers { get; set; }
        //public List<Submission> Submissions { get; set; }

    }
}
