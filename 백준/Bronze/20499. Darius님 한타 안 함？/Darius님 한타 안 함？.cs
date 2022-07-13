using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split("/");
            int K= int.Parse(num[0]), D = int.Parse(num[1]), A = int.Parse(num[2]);
            int result = K + A;
            if (result < D || D == 0)
            {
                WriteLine("hasu");
            }
            else
            {
                WriteLine("gosu");
            }
        }
    }
}