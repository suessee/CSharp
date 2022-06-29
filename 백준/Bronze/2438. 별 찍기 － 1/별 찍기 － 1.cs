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

            for (int i = 1; i < c+1; i++)
            {
                for (int j = 1; j < c + 1; j++)
                {
                    if (j <= i)
                    {
                        answer.Append("*");
                    } 
                }
             answer.AppendLine();
            }
            Console.WriteLine(answer.ToString());
        }
    }
}