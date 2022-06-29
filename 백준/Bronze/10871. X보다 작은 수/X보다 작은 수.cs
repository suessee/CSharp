using System;
using System.Text;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder answer = new StringBuilder();
            String[] input = Console.ReadLine().Split();
            int N = int.Parse(input[0]), X = int.Parse(input[1]);
            int count = 0;
            String[] getN = Console.ReadLine().Split();
            while(N > count)
            {
                int A = int.Parse(getN[count]);
                if (X > A)
                {
                    answer.Append(A + " ");
                }
                ++count;
            }
            
            Console.WriteLine(answer);
        }
    }
}