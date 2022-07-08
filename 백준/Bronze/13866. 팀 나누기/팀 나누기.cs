using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]), D = int.Parse(num[3]);
            int[] result = {A,B,C,D};
            Array.Sort(result);
            int answer = 0;
            if ((result[3] + result[0]) > (result[2] + result[1]))
            {
                answer = (result[3] + result[0]) - (result[2] + result[1]);
            }
            else if ((result[3] + result[0]) < (result[2] + result[1]))
            {
                answer = (result[2] + result[1]) - (result[3] + result[0]) ;
            }
            else
            {
                answer = 0;
            }
            WriteLine(answer);
        }
    }
}