using System;
using System.Collections.Generic;
using System.Linq;
public class WP0325_05
{

 
    public static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(120);
        q.Enqueue(130);
        q.Enqueue(150);


        int next;
        if (q.Contains(120) == true)
        {
            next = q.Dequeue(); // 120
            Console.WriteLine(next);
        }

        next = q.Dequeue(); // 130
        Console.WriteLine(next);

        next = q.Dequeue(); // 150
        Console.WriteLine(next);

        

    }
}
