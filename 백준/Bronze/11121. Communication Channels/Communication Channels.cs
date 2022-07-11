using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            int T = int.Parse(ReadLine());

            for (int i = 0; i < T; i++)
            {
                string[] num = ReadLine().Split();
                string W = num[0], K = num[1];
                if (W == K)
                {
                    WriteLine("OK");
                }
                else
                {
                    WriteLine("ERROR");
                }
            }

        }

    }

}