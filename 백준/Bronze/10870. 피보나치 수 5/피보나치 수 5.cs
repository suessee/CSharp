using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            int[] Nums = new int[n+1];

            for (int i = 0; i < Nums.Length ; i++)
            {
                if (i == 0 || i == 1)
                {
                    Nums[i] = i;
                }
                else
                {                    
                    Nums[i] = Nums[i - 1] + Nums[i - 2];
                } 
            }
            WriteLine(Nums[n]);
        }
    }
}