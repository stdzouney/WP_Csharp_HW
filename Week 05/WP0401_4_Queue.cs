using System;
using System.Collections.Generic;
using System.Collections;

namespace Q_Queue
{
    class WP0401_4_Queue
    {
        static void Main(string[] args)
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("Tiger");
            que.Enqueue("Lion");
            que.Enqueue("Zebra");
            que.Enqueue("Cow");
            que.Enqueue("Rabbit");
            PrintQueue("que: ", que);


            Console.WriteLine("Dequeuing '{0}'", que.Dequeue());
            Console.WriteLine("Peek '{0}'", que.Peek());

            Queue<string> que2 = new Queue<string>(que.ToArray());
            PrintQueue("que2 : ", que2);

            string[] array = new string[que.Count];
            que.CopyTo(array, 0);
            Queue<string> que3 = new Queue<string>(array);
            PrintQueue("que3 : ", que3);

            Console.WriteLine("que.Contains(Lion) = {0}", que.Contains("Lion"));
            que3.Clear();
            Console.WriteLine("Count = {0}, {1} ,{2}", que.Count, que2.Count, que3.Count);

            // 제네릭이 아닌 queue
            Queue myQ = new Queue();
            myQ.Enqueue("one");
            myQ.Enqueue("two");
            myQ.Enqueue("three");

            Console.WriteLine("myQ");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintValues(myQ);

        }

        private static void PrintQueue(string s, Queue<string> que)
        {
            Console.Write("{0,-8}", s);
            foreach(var item in que)
                Console.Write("{0,-8}", item);
            Console.WriteLine();
        }
        private static void PrintValues(Queue myQ)
        {
            foreach (string v in myQ)
                Console.Write("{0}", v);
            Console.WriteLine();
        }

        private static void PrintValues(IEnumerable myCollection)
        {
            Console.Write("{0,-8", myCollection);
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
       


    }
}
