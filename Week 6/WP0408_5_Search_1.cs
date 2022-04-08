using System;
using System.Diagnostics;


namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] v = new int[100];

            for (int i = 0; i <100; i++)
                v[i] = r.Next(10000);
            PrintArray("정렬 전", v);

            // (1) 정렬
            Stopwatch stopwatch = new Stopwatch(); //객체 선언
            stopwatch.Start(); // 시간측정 시작
            Array.Sort(v);
            PrintArray("정렬 후", v);
            stopwatch.Stop(); //시간측정 끝
            System.Console.WriteLine("time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
            System.Console.WriteLine("time : " +
                               stopwatch.Elapsed.ToString());


            Console.Write("=> 검색할 숫자를 입력하세요: ");
            int key = int.Parse(Console.ReadLine());
            int count = 0;  // 비교횟수  
            Console.WriteLine();




            // (2) 선형탐색
            stopwatch.Reset();
            stopwatch.Start(); // 시간측정 시작
            for (int i = 0; i < v.Length ; i++)
            {
                count++;
                if (v[i] == key)
                {
                    //Console.WriteLine("v[{0}] = {1}", i, key);
                    Console.WriteLine("선형탐색의 비교횟수는 {0}회 입니다.", count);
                    break;
                }
            }
            stopwatch.Stop(); //시간측정 끝
            
            System.Console.WriteLine("time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
            System.Console.WriteLine("time : " +
                               stopwatch.Elapsed.ToString() );
            Console.WriteLine();
            // (3) 이진탐색



            count = 0;
            int low = 0;
            int high = v.Length - 1;

            stopwatch.Reset();
            stopwatch.Start();//객체 선언
            while (low <= high)
            {
                count++;
                int mid = (low + high) / 2;
                if (key == v[mid])
                {
                    Console.WriteLine("v[{0}] = {1}", mid, key);
                    Console.WriteLine("이진탐색의 비교횟수는 {0}회 입니다.", count);
                    break;
                }
                else if (key > v[mid])
                    low = mid + 1;
                else
                    high = mid - 1;
            }
            stopwatch.Stop(); //시간측정 끝
            System.Console.WriteLine("time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
            System.Console.WriteLine("time : " +
                               stopwatch.Elapsed.ToString() );
            Console.WriteLine();


            // (4) Array Search
            stopwatch.Reset();
            stopwatch.Start();//객체 선언
            for (int i = 0; i < v.Length; i++)
            {
                
                if (v[i] == key)
                {
                    System.Console.WriteLine("Array Search {0}회 입니다",i+1);
                    break;
                }
            }
            stopwatch.Stop(); //시간측정 끝
            System.Console.WriteLine("time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
            System.Console.WriteLine("time : " +
                               stopwatch.Elapsed.ToString());

            stopwatch.Reset();
            stopwatch.Start();//객체 선언
            for (int i = 0; i < v.Length; i++)
            {

                if (v[i] == key)
                {
                    System.Console.WriteLine("Array Search {0}회 입니다", i + 1);
                    break;
                }
            }
            stopwatch.Stop(); //시간측정 끝
            System.Console.WriteLine("time : " +
                               stopwatch.ElapsedMilliseconds + "ms");
            System.Console.WriteLine("time : " +
                               stopwatch.Elapsed.ToString());

        }

        private static void PrintArray(string s, int[] v)
        {
            Console.WriteLine(s);
            for (int i = 0; i < v.Length; i++)
                Console.Write("{0,5}{1}", v[i], (i % 10 == 9) ? "\n" : "");
        }
    }
}
