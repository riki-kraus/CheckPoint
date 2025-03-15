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
        public string DateCreated { get; set; }
        public string Url { get; set; }
        public int StudentId { get; set; }
        // בבנאי האם הכלה ומה עם מבחן של המנהל
        public int MyProperty { get; set; }
        public Exam(int id, string title, string subject, string @class, string dateCreated, string url)
        {
            Id = id;
            Title = title;
            Subject = subject;
            Class = @class;
            DateCreated = dateCreated;
            Url = url;

        }
    }
}