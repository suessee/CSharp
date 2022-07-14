using System;
using static System.Console;


namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            double x1 = double.Parse(num[0]), y1 = double.Parse(num[1]), z1 = double.Parse(num[2]);
            string[] num1 = ReadLine().Split();
            double x2 = double.Parse(num1[0]), y2 = double.Parse(num1[1]), z2 = double.Parse(num1[2]);
            string result = "E";
            if (z1 == z2 )
            {
                if (y2 >= y1 / 2 && y2 < y1)
                {
                    result = "D";
                }
                else if (y1 == y2)
                {
                    if (x2 >= x1 / 2 && x2 < x1)
                    {
                        result = "B";
                    }
                    else if (x1 == x2)
                    {
                        result = "A";
                    }
                    else
                    {
                        result = "C";
                    }
                }
                else
                {
                    result = "E";
                }
            }
            else
            {
                result = "E";
            }
            
            WriteLine(result);
        }
    }
}