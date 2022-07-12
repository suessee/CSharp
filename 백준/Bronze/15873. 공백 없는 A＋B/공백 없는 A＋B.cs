using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            int result = 0;
            if (100 > N)
            {
                result = N / 10 + N % 10;
            }
            else if (N%10 == 0)
            {
                result = N / 100 + 10;
            }
            else
            {
                result = N % 100 + 10;
            }
            
            WriteLine(result);
        }
    }

}