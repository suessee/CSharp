using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            int result = N * (N - 1);
            WriteLine(result);
        }

    }

}