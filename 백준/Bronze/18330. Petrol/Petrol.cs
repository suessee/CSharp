using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int n = int.Parse(ReadLine());
            int k = int.Parse(ReadLine());
            int sale = 60 + k - n;
            int result = 0;
            if (sale >= 0)
            {
                result = n * 1500;
            }
            else
            {
                result = Math.Abs(sale) * 3000 + (60 + k) * 1500;
            }
            WriteLine(result);
        }
    }

}