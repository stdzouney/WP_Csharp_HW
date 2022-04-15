using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    
    class Parent
    {
        public virtual void Method()
        {
            Console.WriteLine("부모의 메서드");
        }
    }

    class  Child : Parent
    {
        public override void Method()
        {
            Console.WriteLine("자식의 메서드");
        }
    }

    static void Main(string[] args)
    {
        Child child = new Child();
        child.Method();
        ((Parent)child).Method();
    }
}

// 이미 오버라이딩 되었기 때문에
// 캐스팅을 해줘도 자식의 메서드가 출력된다
       