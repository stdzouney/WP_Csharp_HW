using System;
using System.Collections.Generic;
using System.Text;

namespace WP_week2
{
    class WPHW_0318_02
    {
        static string MiddleAlpabet(string s)
        {

            string ab = null;

            if (s.Length % 2 == 0) //문자열이 길이가 짝수
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == s.Length / 2)
                    {
                        ab += s[i - 1];
                    }
                    else if (i == s.Length / 2 + 1)
                    {
                        ab += s[i - 1];
                    }
                }
            }
            else //문자열이 길이가 홀수
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i == s.Length / 2 + 1)
                    {
                        ab += s[i - 1];
                    }
                }
            }
            return ab;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Hello,world!" + " \"{0}\"", MiddleAlpabet("Hello,world!"));
            Console.WriteLine("Software" + " \"{0}\"", MiddleAlpabet("Software"));
            Console.WriteLine("ComputerScience" + " \"{0}\"", MiddleAlpabet("ComputerScience"));

            string InputString;
            Console.WriteLine("입력하신 문자열의 중간값을 구하는 프로그램입니다. 문자열을 입력하세요");
            InputString = Console.ReadLine();
            Console.WriteLine(MiddleAlpabet(InputString));


        }
    }
}
