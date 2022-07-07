using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string[] result = new string[N];
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                string[] input = ReadLine().Split();
                int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
                if (a > b)
                {
                    if (b > c)
                    {
                        result[cnt] = "Ordered";
                        cnt++; 
                    }
                    else
                    {
                        result[cnt] = "Unordered";
                        cnt++;
                    }
                }
                else if (a < b)
                {
                    if (b < c)
                    {
                        result[cnt] = "Ordered";
                        cnt++;
                    }
                    else
                    {
                        result[cnt] = "Unordered";
                        cnt++;
                    }
                }
            }
            WriteLine("Gnomes:");
            for (int i = 0; i < result.Length; i++)
            {
                WriteLine( result[i]);
            }
        }
    }
}