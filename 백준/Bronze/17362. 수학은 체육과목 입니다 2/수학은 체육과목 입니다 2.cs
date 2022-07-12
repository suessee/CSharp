using System;
using static System.Console;
using System.Numerics;
namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            BigInteger n = BigInteger.Parse(ReadLine());
            int result = 0;
            if (n % 8 == 1)
            {
                result = 1;
            }
            else if (n % 8 == 5)
            {
                result = 5;
            }
            else if (n % 8 == 2 || n % 8 == 0)
            {
                result = 2;
            }
            else if (n % 8 == 3 || n % 8 == 7)
            {
                result = 3;
            }
            else if (n % 8 == 4 || n % 8 == 6 )
            {
                result = 4;
            }
            WriteLine(result);
        }
    }

}