using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Examination_System
{
    class FinalExam : Exam<Question>
    {
        public override void ShowExam()
        {
            foreach (KeyValuePair<Question,AnswerList> item in base.exam)
            {
                Console.WriteLine(item.Key);
                foreach (var answer in item.Value)
                {
                    Console.WriteLine(answer);
                }
                Console.Write("enter the answer sympol (form a,b,c,d or t and f) : ");
                string ans = Console.ReadLine();
                if (item.Key.Corrans[0] == ans[0])
                {
                    Question.mark+=item.Key.Qmark;
                }
                else
                {
                    Question.mark += 0;
                }
            }
        }
    }
}
