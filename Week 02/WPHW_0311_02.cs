using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string InputNum;
            int Inum = 0;
            Console.WriteLine("1~1000까지 x의 갯수를 세는 프로그램입니다 x를 입력하세요 (1~9까지) \n");
            InputNum = Console.ReadLine();
            Inum = Int32.Parse(InputNum);
            int CNT_NUM = 0;
            for (int i = 1; i < 1001; i++)
            {
                if (i % 10 == Inum)
                    CNT_NUM++;
                if (i / 100 == Inum)
                    CNT_NUM++;
                if ((i / 10) / 10 == Inum)
                    CNT_NUM++;
                if (i / 1000 == Inum)
                    CNT_NUM++;

            }

            Console.WriteLine("1~1000에서 {0}은 {1}개 있습니다", Inum, CNT_NUM);
        }
    }



        }



