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
                string[] input = ReadLine().Split();
                int age = int.Parse(input[1]), kg = int.Parse(input[2]);
                if (string.Equals(input[0],"#") && string.Equals(input[1],"0") && string.Equals(input[1], input[2]))
                {
                    break;
                }
                else
                {
                    if (age > 17 || kg > 79)
                    {
                        WriteLine(input[0] + " " + "Senior");
                    }
                    else
                    {
                        WriteLine(input[0] + " " + "Junior");
                    }
                }
            }
        }
    }
}