using System;
using System.Text;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();

            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c-i-1; j++)
                {
                    answer.Append(" ");
                }
                for (int k = c; k > c - i - 1; k--)
                {
                    answer.Append("*");
                }
            answer.AppendLine();
            }
            Console.WriteLine(answer.ToString());
        }
    }
}