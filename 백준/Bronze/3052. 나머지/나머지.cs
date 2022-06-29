using System;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num1 = new int[10];
            int[] num2 = new int[42];
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num1[i] += a%42;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 42; j++)
                {
                    if (num1[i] == j)
                    {
                        num2[j] += 1;
                    }
                }
                
            }
            int count = 0;
            for (int i = 0; i < 42; i++)
            {
                if (num2[i] > 0)
                {
                    count += 1;
                }
            }
            Console.WriteLine(count);

        }
    }
}