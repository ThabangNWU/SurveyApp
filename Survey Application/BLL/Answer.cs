using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey_Application.BLL
{
    class Answer
    {
        public string answer_text { get; set; }
        public int person_id { get; set; }
        public int question_id { get; set; }
    }
}
