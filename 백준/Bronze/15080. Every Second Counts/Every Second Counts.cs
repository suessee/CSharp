using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {


            string[] num = ReadLine().Split(" : ");
            int h = int.Parse(num[0]), m = int.Parse(num[1]), s = int.Parse(num[2]);

            string[] num1 = ReadLine().Split(" : ");
            int h1 = int.Parse(num1[0]), m1 = int.Parse(num1[1]), s1 = int.Parse(num1[2]);

            TimeSpan T1 = new TimeSpan(h, m, s);
            TimeSpan T2 = new TimeSpan(h1, m1, s1);
            int T1Sum = (T1.Hours * 3600) + (T1.Minutes * 60) + T1.Seconds;
            int T2Sum = (T2.Hours * 3600) + (T2.Minutes * 60) + T2.Seconds;
            int answer = 0;
            if (T2Sum < T1Sum)
            {
                answer = Math.Abs(T1Sum - T2Sum - (24 * 3600));
            }
            else
            {
                answer = Math.Abs(T2Sum - T1Sum);
            }
            WriteLine(answer);
        }

    }

}