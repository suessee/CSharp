using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            int D = int.Parse(ReadLine());
            int E = int.Parse(ReadLine());
            int[] nums = { A, B, C, D, E };
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 40)
                {
                    nums[i] = 40;
                }
                result += nums[i];
            }
            WriteLine(result / 5);
        }
    }
}