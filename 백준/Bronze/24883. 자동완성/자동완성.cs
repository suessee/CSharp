using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string N = ReadLine();
            if (N.ToUpper() == "N" || N.ToLower() == "n")
            {
                WriteLine("Naver D2");
            }
            else
            {
                WriteLine("Naver Whale");
            }
        }
    }
}