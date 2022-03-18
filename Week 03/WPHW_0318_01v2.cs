using System;
using System.Collections.Generic;
using System.Text;

namespace WP_week2
{
    class WPHW_0318_01
    {
        static int SumWithoutNum (string[] number)
        {
            int a = 0;

            for (int i = 0; i < number.Length; i++)
            {
                a += Int32.Parse(number[i]);
            }
            return (45-a);
        }
        static void Main(string[] args)
        {
            string InputNum;
            int Num1 = 0;
            Console.WriteLine("입력받은 배열에서 없는숫자의 합을 구해주는 프로그램입니다.");
            Console.WriteLine("콤마(,)기준으로 입력해주세요 (범위0~9)");
            InputNum = Console.ReadLine();

            //Num1 = Int32.Parse(InputNum);

            /*int[] arrNum1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arrNum2 = new int[] { 0,2,4,6,8 };
            int[] arrNum3 = new int[] { 1,3,5,7,9 };
            int[] arrNum4 = new int[] {1,2 };
            
            
            Console.WriteLine(SumWithoutNum(arrNum1));
            Console.WriteLine(SumWithoutNum(arrNum2));
            Console.WriteLine(SumWithoutNum(arrNum3));
            Console.WriteLine(SumWithoutNum(arrNum4));*/

            string[] arrNum5 = InputNum.Split(',');
            Console.WriteLine(SumWithoutNum(arrNum5));
        }
    }
}
