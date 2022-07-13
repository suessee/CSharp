using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int p = int.Parse(ReadLine());
            int q = int.Parse(ReadLine());

            if (p <= 50 && q <= 10)
            {
                WriteLine("White");                
            }
            else if (q > 30)
            {
                WriteLine("Red");
            }
            else
            {
                WriteLine("Yellow");
            }
        }
    }
}