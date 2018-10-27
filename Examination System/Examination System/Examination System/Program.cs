using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Examination_System
{
    class Program
    {
        static void Main(string[] args)
        {
            AnswerList al1 = new AnswerList();
            al1.Add(new Answer("a answer 1"));
            al1.Add(new Answer("b answer 2"));
            al1.Add(new Answer("c answer 3"));
            al1.Add(new Answer("d answer 4"));
            AnswerList al2 = new AnswerList();
            al2.Add(new Answer("t answer true"));
            al2.Add(new Answer("f answer false"));
            Question q1 = new Question(1, "quest1", "co", "a");
            Question q2 = new Question(1, "quest1", "tf", "t");
            Exam<Question> e1=new Exam<Question>();
            e1.exam.Add(q1, al1);
            e1.exam.Add(q2, al2);
            FinalExam f1 =new FinalExam();
            f1.ShowExam();
            Console.ReadKey();
        }
    }
}
