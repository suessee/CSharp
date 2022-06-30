using System;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int a = 100;
            int count = 0;
            while (true)
            {
                if (N <= 99)
                {
                    Console.WriteLine(N);
                    break;
                }

                else if (N > 99 && N <= 1000)
                {
                    int a0 = a / 100;
                    int a1 = (a % 100) / 10;
                    int a2 = (a % 100) % 10;

                    if((a0 < a1 && a1 < a2) || (a0 == a1 && a1 == a2))
                    {
                        if (Math.Abs(a0 - a1) == Math.Abs(a1 - a2) || (a0 == a1 && a1 == a2))
                        {
                            count++;
                        }
                    }
                    if ((a0 > a1) && (a1 > a2))
                    {
                        if (Math.Abs(a0 - a1) == Math.Abs(a1 - a2))
                        {
                            count++;
                        }
                    }
                    if (a == N)
                    {
                        Console.WriteLine(count + 99);
                        break;
                    }
                    a++;
                }
                
                
            }


        }
    }
}