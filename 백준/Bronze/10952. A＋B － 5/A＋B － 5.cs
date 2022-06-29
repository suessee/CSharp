using System;
using System.Text;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            int count = 0;
            while (count == 0)
            {
                String[] input = Console.ReadLine().Split();
                int A = int.Parse(input[0]), B = int.Parse(input[1]);
                if (A == 0 && B == 0)
                {
                    count += 1;   
                }
                else
                {
                    answer.AppendLine((A+B).ToString());  
                }
            }
            Console.WriteLine(answer);
        }
    }
}