using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> x = new List<int>();
            for (int i = 1; i <= 1000; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        x.Add(j);
                }
                if(x.Sum()==i)
                    Console.WriteLine(i);
                x.Clear();
            }
            Console.ReadKey();
        }
    }
}
