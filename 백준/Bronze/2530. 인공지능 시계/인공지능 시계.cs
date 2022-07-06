using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]);

            int D = int.Parse(ReadLine());
            TimeSpan total = new TimeSpan(A, B, C);
            TimeSpan dd = new TimeSpan(0, 0, D);
            TimeSpan answer = total.Add(dd);
            WriteLine(answer.Hours + " "+ answer.Minutes + " " +answer.Seconds);
            
        }
    }
}