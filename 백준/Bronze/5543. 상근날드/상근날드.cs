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
            int Coke = int.Parse(ReadLine());
            int Soda = int.Parse(ReadLine());

            int Acoke = A + Coke - 50;
            int Asoda = A + Soda - 50;
            int Bcoke = B + Coke - 50;
            int Bsoda = B + Soda - 50;
            int Ccoke = C + Coke - 50;
            int Csoda = C + Soda - 50;
            int[] result = {Acoke, Asoda, Bcoke, Bsoda, Ccoke, Csoda};
            Array.Sort(result);

            WriteLine(result[0]);

        }
    }
}