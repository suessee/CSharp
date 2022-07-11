using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            int N = int.Parse(ReadLine());
            if (N == 1)
            {
                WriteLine("Leading the Way to the Future");
            }
            else if (N == 0)
            {
                WriteLine("YONSEI");
            }
            
        }

    }

}