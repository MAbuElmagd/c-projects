using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace Examination_System
{
    class Question:IComparable
    {
        protected int qmark;
        public static int mark;
        protected string body;
        protected string header;
        protected string corrans;
        public Question() : this(1)
        {

        }
        public Question(int _qmark) : this(_qmark, "")
        {
            qmark = _qmark;
        }
        public Question(int _qmark, string _body) : this(_qmark, _body, "")
        {
            qmark = _qmark;
            body = _body;
        }
        public Question(int _qmark, string _body, string _header) : this(_qmark, _body, _header, "")
        {
            qmark = _qmark;
            body = _body;
            header = _header;
        }
        public Question(int _qmark, string _body, string _header, string _corrans)
        {
            qmark = _qmark;
            body = _body;
            header = _header;
            corrans = _corrans;
        }
        public int Qmark { get; set; }
        public string Body { get; set; }
        public string Header { get; set; }
        public string Corrans { get; set; }

        public int CompareTo(object obj)
        {
            Question q = obj as Question;
            return body.CompareTo(q.body);
        }

        public override string ToString()
        {
            Console.WriteLine(this.header+this.qmark);
            return body+"";
        }
        
    }
}