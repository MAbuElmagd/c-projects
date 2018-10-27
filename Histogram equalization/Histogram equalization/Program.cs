using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
namespace Histogram_equalization
{
    class Program
    {
        static double sum(double [,]a,int n) {
            double sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum += a[i, 1];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter the no. of gray levels exist in th pic.");
            int ngl=int.Parse(Console.ReadLine());
            double[,] arr = new double[ngl, 5];
            for (int i = 0; i < ngl; i++)
            {
                arr[i, 0] = i ;
            }
            Console.WriteLine("enter the no. of original gray level ");
            for (int i = 0; i < ngl; i++)
            {
                Console.WriteLine("enter the value of "+i+"level");
                arr[i, 1] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < ngl; i++)
            {
                arr[i,2] = sum(arr, i);
            }
            double en = (ngl-1) / arr[(ngl - 1),2];
            for (int i = 0; i < ngl; i++)
            {
                arr[i,3] =Math.Round( (en * arr[i,2]),3);
                arr[i, 4] = Math.Round(arr[i, 3]);
            }
            FileStream F = new FileStream("result.txt", FileMode.Open, FileAccess.ReadWrite);
            for (int i = 0; i < ngl; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    F.WriteByte((byte)arr[i,x]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
