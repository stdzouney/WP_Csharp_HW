using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("부모 생성");
        }
    }


    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("자식 생성");
        }
    }



    static void Main(string[] args)
    {
        Child child = new Child();
    }
    }

