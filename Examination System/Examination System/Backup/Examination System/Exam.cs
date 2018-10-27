using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Examination_System
{
    class Exam<t> where t:Question
    {
        protected int time;
        protected int noq;
        public Dictionary<Question, AnswerList> exam ;
        public Exam() : this(1)
        {

        }
        public Exam(int _time) : this(_time, 1)
        {
            time = _time;
        }
        public Exam(int _time, int _noq) 
        {
            time = _time;
            noq = _noq;
        }
        public int Time { get; set; }
        public int Noq { get; set; }
        public override string ToString()
        {
            return noq +":"+ time;
        }
        public virtual void ShowExam()
        { 
            
        }
    }
}
