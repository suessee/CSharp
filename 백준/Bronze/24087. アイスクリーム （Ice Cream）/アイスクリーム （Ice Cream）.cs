using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int S = int.Parse(ReadLine());
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int result = 0;
            if (S <= A)
            {
                result = 250;
            }
            else
            {
                if ((S-A) % B != 0)
                {
                    result = 250 + ((S - A)/B + 1) * 100;
                }
                else
                {
                    result = 250 + ((S - A) / B ) * 100;
                }
            }
            WriteLine(result);
        }
    }
}