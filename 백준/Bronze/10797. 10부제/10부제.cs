using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int K = int.Parse(ReadLine());
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]), D = int.Parse(num[3]), E = int.Parse(num[4]);
            int[] nums = { A, B, C, D, E };
            int result = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == K)
                {
                    result += 1;
                }
            }
            WriteLine(result);
        }
    }
}