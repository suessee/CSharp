using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int l = int.Parse(num[0]), r = int.Parse(num[1]);
            string result = "";
            if (l == r && l == 0)
            {
                result = "Not a moose";
            }
            else if (l == r && l != 0)
            {
                result = "Even " + (l * 2).ToString();
            }
            else
            {
                if (l > r)
                {
                    result = "Odd " + (l * 2).ToString();
                }
                else
                {
                    result = "Odd " + (r * 2).ToString();
                }
            }
            WriteLine(result);
        }
    }
}