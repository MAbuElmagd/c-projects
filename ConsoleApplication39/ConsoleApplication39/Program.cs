using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the column number:");
            int b = int.Parse(Console.ReadLine());
            double[,] x = new double[a, b];
            for (int i = 0; i < a; i++)
                for (int z = 0; z < b; z++)
                {
                    Console.WriteLine("enter the element[a" + (i + 1) + (z + 1) + "]:");
                    x[i, z] = double.Parse(Console.ReadLine());
                }
            Console.WriteLine("the augmanted matrix is:");
            matrix(a, b, x);
            Console.WriteLine("the system is :");
            for (int i = 0; i < a; i++)
            {
                for (int z = 0; z < b; z++)
                {
                    if (z == b - 1)
                        Console.Write("=" + x[i, z]);
                    else if (x[i, z] == 0)
                        Console.Write("");
                    else if (x[i, z] < 0)
                        Console.Write(x[i, z] + "x" + (z + 1));
                    else if (z != 0)
                    {
                        if (x[i, z] == 1)
                            Console.Write("+ x" + (z + 1));
                        else if (x[i, z] > 0)
                            Console.Write("+" + x[i, z] + "x" + (z + 1));
                    }
                    else if (z == 0)
                    {
                        if (x[i, z] == 1)
                            Console.Write("x" + (z + 1));
                        else if (x[i, z] > 0)
                            Console.Write(x[i, z] + "x" + (z + 1));
                    }
                }
                Console.WriteLine();
            }
            double r = 0; double e = 0; double[] arr = new double[b];
            Console.WriteLine("the solution is :");
            for (int j = b - 2; j >= 0; j--)
            {
                for (int i = a - 1; i <= 0; i--)
                {
                    if (i == j)
                    {
                        if (x[i, j] == 1)
                        {
                            for (int q = 0; q < b; q++)
                                arr[q] = x[i, q];
                        }
                    }
                    else if (i > j)
                    {
                        if (x[i, j] == 0) { continue; }
                        else if (x[i, j] < 0)
                        {
                            r = x[i, j];
                            Console.WriteLine("R" + (i + 1) + "=" + "R" + (i + 1) + "+" + x[i, j] + "R" + (e + 1));
                            for (int q = 0; q < b; q++)
                            {
                                arr[q] *= x[i, j];
                                x[i, q] += arr[q];
                            }
                            matrix(a, b, x);
                        }
                        else if (x[i, j] > 0)
                        {
                            r = x[i, j];
                            Console.WriteLine("R" + (i + 1) + "=" + "R" + (i + 1) + "-" + x[i, j] + "R" + (e + 1));
                            for (int q = 0; q < b; q++)
                            {
                                arr[q] *= r;
                                x[i, q] -= arr[q];
                            }
                            matrix(a, b, x);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        static void matrix(int a, int b, double[,] x)
        {
            for (int i = 0; i < a; i++)
            {
                for (int z = 0; z < b; z++)
                    Console.Write("   " + x[i, z] + "   ");
                Console.WriteLine();
            }
        }
    }
}
