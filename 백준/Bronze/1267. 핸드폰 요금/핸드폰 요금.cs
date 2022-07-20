using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            string[] num = ReadLine().Split();
            int result1 = 0;
            int result2 = 0;
            for (int i = 0; i < N; i++)
            {
                if (int.Parse(num[i]) % 30 >= 0)
                {
                    result1 += (int.Parse(num[i]) / 30) * 10 + 10; 
                }
                else
                {
                    result1 += (int.Parse(num[i]) / 30) * 10;
                }
                if (int.Parse(num[i]) % 60 >= 0)
                {
                    result2 += (int.Parse(num[i]) / 60) * 15 + 15;
                }
                else
                {
                    result2 += (int.Parse(num[i]) / 60) * 15;
                }
            }

            if (result1 == result2)
            {
                WriteLine("Y M " + result1);
            }
            else if (result1 < result2)
            {
                WriteLine("Y " + result1);
            }
            else if (result2 < result1)
            {
                WriteLine("M " + result2);
            }
        }
    }
}