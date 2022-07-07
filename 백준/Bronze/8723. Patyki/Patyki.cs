using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            double a = double.Parse(num[0]), b = double.Parse(num[1]), c = double.Parse(num[2]);
            double[] nums = { a, b, c };
            Array.Sort(nums);
            if (a == b && b == c)
            {
                WriteLine(2);
            }
            else if (Math.Pow(nums[0], 2) + Math.Pow(nums[1], 2) == Math.Pow(nums[2], 2))
            {
                WriteLine(1);
            }
            else
            {
                WriteLine(0);
            }
            
        }
    }
}