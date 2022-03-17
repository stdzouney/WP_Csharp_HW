using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class WPHW_0311_01
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("입력받은 수를 정렬해주는 프로그램입니다 (홀짝 수가 맞게 입력해주세요). \n");
            bool c = true;
            string InputListsize; // 리스트의 크기
            int Listsize = 0;

            while (c)
            {
                Console.WriteLine("입력할 숫자의 갯수는? ");

                InputListsize = Console.ReadLine();
                Listsize = Convert.ToInt32(InputListsize); // 자료형변경
                if (Listsize % 2 == 0)
                    break;
                else
                    Console.WriteLine("짝수를 입력해주세요\n");
            }
            //홀짝 리스트 구분
            List<int> odd = new List<int>();
            List<int> even = new List<int>();

            for (int i = 0; i<Listsize;i++ ) // 입력받은 리스트의 크기만큼 반복
            {


                
                string Inputnum; 
                int Inum = 0;
                Console.WriteLine("숫자를 입력하세요 ");
                Inputnum = Console.ReadLine();
                Inum = Convert.ToInt32(Inputnum);


                //리스트에 추가
                if (Inum % 2 == 1)
                    odd.Add(Inum);
                else
                    even.Add(Inum);

                odd.Sort();
                even.Sort();
                even.Reverse();

                if(i==(Listsize-1))
                {
                    if (odd.Count == even.Count)
                    {
                        for (int j = 0; j < odd.Count; j++)
                        {
                            Console.Write(odd[j] + " ");
                            Console.Write(even[j] + " ");
                        }
                    }
                    else //예외처리
                    {
                        i = -1;
                        Console.WriteLine("홀수의 개수{0} 와 짝수의 개수{1} 가 같지않습니다. 처음부터 다시 입력해주세요\n",(odd.Count),(even.Count));
                        odd.Clear();
                        even.Clear();
                    }
                }
                
            }
            

            


           
            }
            
            

           
        }
    }

