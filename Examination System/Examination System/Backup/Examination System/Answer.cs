using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Examination_System
{
    class Answer
    {
        protected string body;
        public Answer() : this("")
        {

        }
        public Answer(string _body)
        {
            body = _body;
        }
        public string Body { get; set; }
        public override string ToString()
        {
            return body+"";
        }
    }
}
