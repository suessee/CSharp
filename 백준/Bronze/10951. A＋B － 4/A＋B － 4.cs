using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string input = Console.ReadLine();
                if (input == null) break;
                string[] inputNum = input.Split();
                int numA = int.Parse(inputNum[0]), numB = int.Parse(inputNum[1]);
                int sum = numA + numB;

                Console.WriteLine(sum);
            }
        }
    }
}