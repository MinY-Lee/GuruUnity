using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int hp;

            hp = 100;

            Console.WriteLine("Hello World! {0}", hp);

            // byte(1바이트 0~255), short(2바이트 -3만~3만), int(4바이트 -21억~21억), long(8바이트)
            // sbyte(1바이트 -128~127), ushort(2바이트 0~6만), uint(4바이트 0~43억), ulong(8바이트)

            // 1바이트(참/거짓)
            bool b;
            b = true;
            b = false;

            // 소수
            // 4바이트
            float f = 3.14f;
            // 8바이트
            double d = 3.14;

            // 2바이트
            char c = 'a';
            string str = "Hello World";

            Console.WriteLine(str);

            // 형식변환
            // 1. 바구니 크기가 다른 경우
            short bb = 100;
            int a = bb;

            // 2. 바구니 크기는 같긴 한데, 부호가 다른 경우
            byte cc = 255;
            sbyte sb = (sbyte)cc;

            // 데이터 연산
            int id = 123;
            int key = 401; 

            int e = id ^ key;

            int ff = e ^ key;

            Console.WriteLine(e);
            Console.WriteLine(ff);
            // key를 알지 못하면 id를 알 수 없기 때문에 암호학에서 주로 사용
            */

            // if와 else
            /*int hp = 100;
            bool isDead = (hp <= 0);

            if (isDead)
                Console.WriteLine("You are dead!");
            else
                Console.WriteLine("You are alive!");*/

           // int choice = 0;// 0:가위, 1:바위, 2:보, 3:치트키

            /* if (choice == 0)
             {
                 Console.WriteLine("가위입니다.");
             }
             else if (choice == 1)
             {
                 Console.WriteLine("바위입니다.");
             }
             else if(choice==2)
             {
                 Console.WriteLine("보입니다.");
             }
             else
             {
                 Console.WriteLine("치트키입니다.");
             }*/

            // 0:가위 1:바위 2:보

            Random rand = new Random();
            int aiChoice = rand.Next(0, 3);     // 0~2사이의 랜덤 값

            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다.");
                    break;
            }

            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다.");
                    break;
            }

            // 가위바위보 결과 내기
            if(choice==0)
            {
                if (aiChoice == 0)
                    Console.WriteLine("무승부입니다.");
                else if (aiChoice == 1)
                    Console.WriteLine("패배입니다.");
                else if(aiChoice == 2)
                    Console.WriteLine("승리입니다.");
            }
            else if(choice==1)
            {
                if (aiChoice == 0)
                    Console.WriteLine("승리입니다.");
                else if (aiChoice == 1)
                    Console.WriteLine("무승부입니다.");
                else if(aiChoice == 2)
                    Console.WriteLine("패배입니다.");
            }
            else
            {
                if (aiChoice == 0)
                    Console.WriteLine("패배입니다.");
                else if (aiChoice == 1)
                    Console.WriteLine("승리입니다.");
                else if(aiChoice == 2)
                    Console.WriteLine("무승부입니다.");
            }

            // 복사=짝퉁, 참조=진통(ref 사용) 

            // 연습문제-구구단
            for(int num1=2;num1<=9;num1++)
            {
                for(int num2=1;num2<=9;num2++)
                {
                    Console.WriteLine($"{num1}*{num2} = {num1*num2}");
                }
            }

        }
    }
}
