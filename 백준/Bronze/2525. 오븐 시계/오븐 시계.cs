using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String aa = Console.ReadLine();
            String[] bb = aa.Split();
            int a = int.Parse(bb[0]), b = int.Parse(bb[1]); int c = int.Parse(Console.ReadLine());
            if (b + c >= 60)
            {
                a += (b+c)/60;
                b = (b+c)%60;
                if (a >= 24)
                {
                    a -= 24;
                    Console.WriteLine("{0} {1}", a, b);
                }
                else 
                {
                    Console.WriteLine("{0} {1}", a, b);
                }
            }
            else 
            {
                b += c;
                Console.WriteLine("{0} {1}", a, b);
            }
        }
    }
}
