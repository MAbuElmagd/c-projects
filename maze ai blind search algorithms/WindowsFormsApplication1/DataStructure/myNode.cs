using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DataStructure
{
    class myNode
    {
        int x;
        int y;
        myNode next1;
        myNode next2;
        myNode next3;
        myNode next4;
        public bool Visited { get; set; }
        public myNode(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public myNode Parent { get; set; }
        public int level { get; set; }
        public int cost { get; set; }
        public myNode expand(List<myNode> exNodes)
        {
            next1 = exNodes[0];
            next2 = exNodes[1];
            next3 = exNodes[2];
            next4 = exNodes[3];

            if (next1 != null)
            {
                return next1;
            }
            else if (next2 != null)
            {
                return next2;
            }
            else if (next3 != null)
            {
                return next3;
            }
            else if (next4 != null)
            {
                return next4;
            }
            else return Parent;
        }
    }
}
