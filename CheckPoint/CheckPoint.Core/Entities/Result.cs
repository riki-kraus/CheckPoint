using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.Core.Entities
{
    public class Result
    {
        public int Id { get; set; }
        public int ExamId { get; set; }
        public int Mark { get; set; }
        public string UrlFidbek { get; set; }

        public Result(int id, int examId, int mark, string urlFidbek)
        {
            Id = id;
            ExamId = examId;
            Mark = mark;
            UrlFidbek = urlFidbek;
        }
    }

}
