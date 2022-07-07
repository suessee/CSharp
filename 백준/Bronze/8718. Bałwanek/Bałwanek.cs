using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            double x = double.Parse(num[0]) * 1000, k = double.Parse(num[1]) * 1000;
            double[] result = { k + (k * 2) + (k * 4), (k / 2) + k + (k * 2), k + (k / 2) + (k / 4) };
            double answer = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] <= x )
                {
                    if (result[i] > answer)
                    {
                        answer = result[i];
                    }
                }
            }
            WriteLine(answer);      
        }
    }
}