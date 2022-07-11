using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            int Z = int.Parse(ReadLine());

            for (int i = 0; i < Z; i++)
            {
                string[] num = ReadLine().Split();
                int W = int.Parse(num[0]), K = int.Parse(num[1]);
                int result = (W * K) / 2;
                WriteLine(result);
            }

        }

    }

}