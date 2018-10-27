using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Examination_System
{
    class AnswerList : List<Answer>
    {
        public new void Add(Answer A)
        {
            base.Add(A);
        }
    }
}
