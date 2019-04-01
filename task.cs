using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
  public abstract class Shape
    {
       protected int dim1;
        protected int dim2;
        public virtual int Dim1
        {
            get ;
            set ;
        }

        public virtual int Dim2
        {
            get ;
            set;
        }


        public abstract float CalcArea();
        
        

        public Shape(int _dim1=1,int _dim2=1)
        {
            dim1 = _dim1;
            dim2 = _dim2;
        }

        public override string ToString()
        {
            return $"{dim1}:{dim2}";
        }
    }
}
