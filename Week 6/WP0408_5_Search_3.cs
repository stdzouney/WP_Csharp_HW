using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작
            int[] v = { 3, 5, 2, 7, 1 };
            PrintArray(v);

            for (int i = 4; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                    if (v[j] > v[j + 1])
                    {
                        int t = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = t;
                    }
                PrintArray(v);
            }
            stopwatch.Stop(); //시간측정 끝

            System.Console.WriteLine("time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
        }

        private static void PrintArray(int[] v)
        {
            foreach (var i in v)
                Console.Write("{0, 5}", i);
            Console.WriteLine();
        }
    }
}