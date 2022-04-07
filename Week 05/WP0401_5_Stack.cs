using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace S_Stack
{
    class WP0401_5_Stack
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("계산할 수식을 Polish 표기법으로 입력하세요 : (a입력시 종료)");
                String[] token = Console.ReadLine().Split();

                foreach (var i in token)
                    Console.Write("{0}", i);
                Console.WriteLine(" = ");

                Stack<double> nStack = new Stack<double>();

                foreach (var s in token)
                {
                    if (s == "a")
                    {
                        Console.WriteLine("a 입력 프로그램을 종료합니다.");
                        return;
                    }
                        
                    if (isOperator(s))
                    {
                        switch (s)
                        {
                            case "+":
                                nStack.Push(nStack.Pop() + nStack.Pop());
                                break;
                            case "-":
                                nStack.Push(nStack.Pop() - nStack.Pop());
                                break;
                            case "*":
                                nStack.Push(nStack.Pop() * nStack.Pop());
                                break;
                            case "/":
                                nStack.Push(nStack.Pop() / nStack.Pop());
                                break;

                        }
                    }
                    else
                    {
                        nStack.Push(double.Parse(s));
                    }
                }
                    Console.WriteLine("결과는 {0}", nStack.Pop());
                }
            }




            private static bool isOperator(string s)
            {
                if (s == "+" || s == "-" || s == "*" || s == "/")
                    return true;
                else
                    return false;
            }

            private static bool isNumber(string s)
            {
                if (Double.TryParse(s, out double number))
                    return true;
                else
                    return false;
            }










        }

       
       


    }

