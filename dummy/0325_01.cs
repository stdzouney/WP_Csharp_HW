using System;

public class Hello1
{
    public static void Main()
    {
        string a;
        int x = 0;
        while (true)
        {
            Console.WriteLine("구구단 몇단을 알고싶으신가요? (-1입력시 종료)");
            a = Console.ReadLine();
            x = Int32.Parse(a);
            if (x == -1) break;
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", x, i, (x * i));
            }
        }

    }
}
