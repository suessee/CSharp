using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            while (true)
            {
                int result = 0;
                string N = ReadLine();
                if (N == "0")
                {
                    break;
                }
                for (int i = 0; i < N.Length; i++)
                {
                    if (char.GetNumericValue(N[i]) == 1)
                    {
                        result += 2;
                    }
                    else if (char.GetNumericValue(N[i]) == 0)
                    {
                        result += 4;
                    }
                    else
                    {
                        result += 3;
                    }
                }
                WriteLine(result + N.Length + 1);
            }   
        }
    }
}