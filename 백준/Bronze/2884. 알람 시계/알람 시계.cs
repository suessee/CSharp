using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String aa = Console.ReadLine();
            String[] bb = aa.Split();
            int a = int.Parse(bb[0]), b = int.Parse(bb[1]);
            if (a > 0)
            {
                if (b < 45)
                {
                    a -= 1;
                    b = 15 + b;
                    Console.WriteLine("{0} {1}", a, b);
                }
                else 
                {
                    b -= 45;
                    Console.WriteLine("{0} {1}", a, b);
                }
            }
            else if (a == 0)
            {
                if (b < 45)
                {
                    a = 23;
                    b = 15 + b;
                    Console.WriteLine("{0} {1}", a, b);
                }
                else
                {
                    b -= 45;
                    Console.WriteLine("{0} {1}", a, b);
                }
               
            }
        }   
    }
}
