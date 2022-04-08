﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smethod_StaticMethod
{
    class Methods
    {
        // using instance method
        /*
        static void Main(string[] args)
        {
          int a = 10, b = 30, c = 20;
          Methods x = new Methods();
          Console.WriteLine("가장 큰 수는{0}", x.Larger(x.Larger(a, b), c));
        }

        private int Larger(int a, int b)  // static이 아닙니다.
        {
          return (a >= b) ? a : b;
        }
        */

        // using static method
        static void Main(string[] args)
        {
            int a = 10, b = 30, c = 20;
            Console.WriteLine("a{0}, b{1}, c{2} 가장 큰 수는{3}",a,b,c, Larger(Larger(a, b), c));
        }

        private static int Larger(int a, int b)
        {
            return (a >= b) ? a : b;
        }
    }
}

