using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int m = int.Parse(num[0]), n = int.Parse(num[1]);
            for (int i = 0; i < m; i++)
            {
                string[] num1 = ReadLine().Split();
                int A = int.Parse(num1[0]), B = int.Parse(num1[1]), C = int.Parse(num1[2]);
            }
            if (m >= 8)
            {
                WriteLine("satisfactory");
            }
            else
            {
                WriteLine("unsatisfactory");
            }
        }
    }

}