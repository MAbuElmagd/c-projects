using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter of rows");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("please enter of cols");
            int y = int.Parse(Console.ReadLine());
            jordon j = new jordon(x, y);
            j.Calc();


        }
    }
}
class jordon
{
    int[,] arr;
    int rows;
    int cols;
    public jordon(int ro, int col)
    {
        rows = ro;
        cols = col;
        arr = new int[ro, col];
    }

    public void Calc()
    {
        Console.WriteLine("enter the value");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("[{0},{1}]=", i, j);
                arr[i, j] = int.Parse((Console.ReadLine()));

            }

        }
        Console.WriteLine("The Matrix");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }
        Console.WriteLine("                                          ");
        for (int i = 0; i < rows; i++)
        {
            int temp = arr[i, i];

            for (int j = 0; j < cols; j++)
            {
                if(temp!=0)
                arr[i, j] = arr[i, j] / temp;
            }

            Console.WriteLine("The Steps");
            for (int q = 0; q < rows; q++)
            {
                for (int x = 0; x < cols; x++)
                {
                    Console.Write("{0}\t", arr[q, x]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("                                        ");

            for (int k = 0; k < rows; k++)
            {
                temp = arr[k, i];
                if (i != k)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        arr[k, j] = arr[k, j] - (temp * arr[i, j]);
                    }
                }
            }

            for (int t = 0; t < rows; t++)
            {
                for (int h = 0; h < cols; h++)
                {
                    Console.Write("{0}\t", arr[t, h]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("                                      ");

        }
        Console.WriteLine("The solution");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("{0}\t", arr[i, j]);
            }
            Console.WriteLine();
        }
    }
}
