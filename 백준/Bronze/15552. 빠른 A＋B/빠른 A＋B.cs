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
                string[] s = Console.ReadLine().Split();
                int a = int.Parse(s[0]), b = int.Parse(s[1]);

                answer.AppendLine((a + b).ToString());
            }
            Console.WriteLine(answer.ToString());
        }   
    }
}