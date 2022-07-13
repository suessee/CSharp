using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int a = int.Parse(ReadLine());
            int x = int.Parse(ReadLine());
            int b = int.Parse(ReadLine());
            int y = int.Parse(ReadLine());
            int T = int.Parse(ReadLine());
            int resultA = 0;
            int resultB = 0;
            if (T < 45)
            {
                if (T > 30)
                {
                    resultA = a + (T - 30) * x * 21;
                    resultB = b;
                }
                else
                {
                    resultA = a;
                    resultB = b;
                }
                
            }
            else
            {
                resultA = a + (T - 30) * x * 21;
                resultB = b + (T - 45) * y * 21;
            }
            WriteLine("{0} {1}", resultA, resultB);
        }
    }
}