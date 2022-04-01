using System;
using System.Linq;

using System.Collections.Generic;

public class WPHW0325_1
{


    public static void Main()
    {
        while (true)
        {
            string InputNum;
            int Num1 = 0;
            Console.WriteLine("입력받은 배열의 모든 덧셈 경우의 수를 구해주는 프로그램입니다.");
            Console.WriteLine("콤마(,)기준으로 입력해주세요 (음수 입력시 종료)");
            InputNum = Console.ReadLine();
            string[] arrNum5 = InputNum.Split(',');

            if (arrNum5.Length > 100 || arrNum5.Length < 0) //길이가 100이상이거나 입력을 안한경우
                break;


            int[] numbers = new int[arrNum5.Length];
            for (int i = 0; i < arrNum5.Length; i++)
                numbers[i] = Int32.Parse(arrNum5[i]);


            int exCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 100 | numbers[i] < 0)
                    exCount++;

            }
            if (exCount != 0) //음수나 100이 넘는수가 배열에있을경우 
            {
                Console.WriteLine("음수 입력 프로그램을 종료");
                break;
            }





            List<int> numbers2 = numbers.ToList(); // 입력받은 배열로 리스트생성

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                //if(i==0) //배열로 리스트생성 
                //{
                //    for (int t = 0; t < numbers.Length; t++)
                //    {
                //        int s = numbers[t];
                //        numbers2.Add(s);
                //    }
                //}
               



                for (int j = i + 1; j < numbers.Length; j++) // 덧셈경우의 수 리스트에 추가
                {
                    int a = numbers[i] + numbers[j];
                    if (numbers2.Contains(a) == false)
                    {
                        Console.WriteLine("{0} = {1} + {2} 입니다.", a, numbers[i], numbers[j]);
                        numbers2.Add(a);
                    }

                }



            }
           
            numbers2.Sort(); //리스트 정렬 
            numbers2 = numbers2.Distinct().ToList(); //리스트 중복제거
            
            for (int i = 0; i < numbers2.Count; i++) //리스트 출력
            {
                if (i == numbers2.Count - 1)
                {
                    Console.Write("{0}] ", numbers2[i]);
                    Console.WriteLine();
                }
                else if (i == 0)
                    Console.Write("[{0}, ", numbers2[i]);
                else
                    Console.Write("{0}, ", numbers2[i]);
            }
        }
    }
}