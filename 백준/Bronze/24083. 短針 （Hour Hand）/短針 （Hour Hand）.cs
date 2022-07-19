using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int result = 0;
            if (B >= 12)
            {
                B = B % 12;
                if (A + B > 12)
                {
                    result = A + B - 12;
                }
                else
                {
                    result = A + B;
                }
            }
            else
            {
                if (A + B > 12)
                {
                    result = A + B - 12;
                }
                else
                {
                    result = A + B;
                }
                
            }
            WriteLine(result);
        }
    }
}