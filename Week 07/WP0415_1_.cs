using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsageOfHidding
{
    // 코드 7-28: 하이딩
    class Program
    {
        class Animal
        {
            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }
        }

        class Dog : Animal
        {
            new public void Eat()
            {
                Console.WriteLine("강아지 사료를 먹습니다.");
            }
        }

        class Cat: Animal
        {
            new public void Eat()
            {
                Console.WriteLine("고양이 사료를 먹습니다.");
            }
        }

        static void Main(string[] args)
        {
            List<Animal> Animal = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animal)
            {
                item.Eat();
            }
            Console.WriteLine();
            new Dog().Eat();
            new Cat().Eat();
            new Animal().Eat();
        }
    }
}

// Cat 과 Dog 끼리도 가능하다 
