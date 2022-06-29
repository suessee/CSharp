using System;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            string[] input = Console.ReadLine().Split();
            float[] nums = Array.ConvertAll(input, float.Parse);

            float max = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            float sum = 0;
            for (int i = 0; i < num; i++)
            {
                nums[i] = nums[i] / max * 100;
                sum += nums[i];
            }
            Console.WriteLine("{0:0.00####}", sum / num);
        }
    }
}