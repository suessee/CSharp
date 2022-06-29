using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        { 
            int[] nums = new int[9];
            int max = nums[0];
            int count = 0;
            for (int i = 0; i < 9; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
                if (max < nums[i])
                {
                    max = nums[i];
                    count = i + 1;
                }
            }
            Console.WriteLine(max+"\n"+count);  
        }
    }
}