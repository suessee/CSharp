using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string input = ReadLine();
            int cnt = 1;
            int resultA = 0;
            int resultB = 0;
            while (cnt <= input.Length)
            {
                if (char.Equals(input[cnt-1].ToString(),"A"))
                { 
                    resultA += (int)char.GetNumericValue(input[cnt]);
                }
                else if(char.Equals(input[cnt - 1].ToString(), "B"))
                {
                    resultB += (int)char.GetNumericValue(input[cnt]);
                }
                cnt += 2;
            }
            if (resultA > resultB)
            {
                WriteLine("A");
            }
            else if (resultA < resultB)
            {
                WriteLine("B");
            }
        }
    }

}