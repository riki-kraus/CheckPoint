using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Entities
{
    public class Exam
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Class { get; set; }
        public DateTime DateCreated { get; set; }
        // בבנאי האם הכלה ומה עם מבחן של המנהל
        public List<Submission> Submissions { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
       public Exam() { }

        public Exam(int id, string title, string subject, string @class, DateTime dateCreated, List<Submission> submissions, List<Answer> answers)
        {
            Id = id;
            Title = title;
            Subject = subject;
            Class = @class;
            DateCreated = dateCreated;
            Submissions = submissions;
            Answers = answers;
        }
    }
}