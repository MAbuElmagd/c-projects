using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.DataStructure
{
    class myTree
    {
        myNode root;

        public List<myNode> nodes = new List<myNode>();
        public myTree(myNode root)
        {
            this.root = root;
            nodes.Add(root);
            
        }
        public myNode CurrentNode { get; set; }
    }
}
