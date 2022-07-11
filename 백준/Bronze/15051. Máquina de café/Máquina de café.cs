using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            int A1 = int.Parse(ReadLine());

            int A2 = int.Parse(ReadLine());

            int A3 = int.Parse(ReadLine());

            int f1 = A2 * 2 + A3 * 4;
            int f2 = A1 * 2 + A3 * 2;
            int f3 = A1 * 4 + A2 * 2;
            int result = Math.Min(f1,f2);
            int answer = Math.Min(result, f3);

            

            WriteLine(answer);

        }

    }

}