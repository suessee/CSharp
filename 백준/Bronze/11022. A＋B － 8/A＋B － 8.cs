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

            int[] a = new int[c];
            int[] b = new int[c];

            for (int i = 0; i < c; i++)
            {
                String[] aAndB = Console.ReadLine().Split();
                a[i] = int.Parse(aAndB[0]);
                b[i] = int.Parse(aAndB[1]);
            }
            for (int i = 0; i < c; i++)
            {
                answer.Append("Case #" + (i+1) + ": " + a[i] + " + " + b[i] + " = ").Append(a[i] + b[i]).AppendLine("");
            }

            Console.WriteLine(answer.ToString());
        }
    }
}