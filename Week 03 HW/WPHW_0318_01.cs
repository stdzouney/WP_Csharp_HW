using System;
using System.Collections.Generic;
using System.Text;

namespace WP_week2
{
    class WPHW_0318_01
    {
        static int SumWithoutNum (int[] number)
        {
            int a = 0;

            for (int i = 0; i < number.Length; i++)
            {
                a += number[i];
            }
            return (45-a);
        }
        static void Main(string[] args)
        {
            int[] arrNum1 = new int[] { 1, 2, 3, 4, 5, 6 };
            int[] arrNum2 = new int[] { 0,2,4,6,8 };
            int[] arrNum3 = new int[] { 1,3,5,7,9 };
            int[] arrNum4 = new int[] {1,2 };
            Console.WriteLine(SumWithoutNum(arrNum1));
            Console.WriteLine(SumWithoutNum(arrNum2));
            Console.WriteLine(SumWithoutNum(arrNum3));
            Console.WriteLine(SumWithoutNum(arrNum4));


        }
    }
}
