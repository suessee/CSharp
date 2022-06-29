using System;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string inputs = Console.ReadLine();
            string[] input = inputs.Split();
            int[] nums = Array.ConvertAll(input, int.Parse);

            int max = nums[0];
            int min = nums[0];

            for (int i = 0; i < num; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            Console.WriteLine(min+" "+max);
            
        }
    }
}