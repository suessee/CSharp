using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String aa = Console.ReadLine();
            String[] bb = aa.Split();
            int a = int.Parse(bb[0]), b = int.Parse(bb[1]), c = int.Parse(bb[2]);
            int money = 0;
            if (a == b && b == c)
            {
                money = 10000 + (a * 1000);
                Console.WriteLine(money);
            }
            else if ((a == b && a != c) || (a == c && a != b) || (b == c && b != a))
            {
                if ((a == b && a != c) || (a == c && a != b)) 
                {
                    money = 1000 + (a * 100);
                    Console.WriteLine(money);
                }
                else if (b == c && b != a)
                {
                    money = 1000 + (b * 100);
                    Console.WriteLine(money);
                }
            }
            else 
            {
                if (a > b && a > c) 
                {
                    money = a * 100;
                    Console.WriteLine(money);
                }
                else if (b > a && b > c)
                {
                    money = b * 100;
                    Console.WriteLine(money);
                }
                else if (c > b && c > a)
                {
                    money = c * 100;
                    Console.WriteLine(money);
                }
            }
        }
    }
}
