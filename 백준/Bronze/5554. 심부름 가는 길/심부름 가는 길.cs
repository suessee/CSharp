using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            int D = int.Parse(ReadLine());

            int Min = (A + B + C + D) / 60;
            int Sec = (A + B + C + D) % 60;
            WriteLine(Min+"\n"+Sec);

        }
    }
}