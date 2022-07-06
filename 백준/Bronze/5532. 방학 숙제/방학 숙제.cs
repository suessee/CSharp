using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int L = int.Parse(ReadLine());
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            int C = int.Parse(ReadLine());
            int D = int.Parse(ReadLine());
            int Math = B / D;
            if (B % D != 0) Math += 1;
            int Korean = A / C;
            if (A % C != 0) Korean += 1;
            if (Korean >= Math) WriteLine(L - Korean);
            else if (Math >= Korean) WriteLine(L - Math);
        }
    }
}