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
            int hp;

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
        }
    }
}
