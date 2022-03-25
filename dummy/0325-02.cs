using System;

public class Hello1
{
    public static void Main()
    {
        string a,b;
        int x = 0, y = 0 ;
        while (true)
        {
            Console.WriteLine("x의 y승을 계산합니다");
            Console.WriteLine("x를 입력하세요 -1 입력시 종료");
            a = Console.ReadLine();
            x = Int32.Parse(a);
            if (x == -1) break;
            Console.WriteLine("y를 입력하세요");
            b = Console.ReadLine();
            y = Int32.Parse(b);

            int pow = 1;
           
            for (int i = 0; i < y; i++)
            {
                pow *= x;
            }
            Console.WriteLine("{0}의 {1}승은 {2}입니다",x,y,pow);
            Console.WriteLine("");

        }

    }
}
