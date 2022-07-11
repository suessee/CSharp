using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {

            string[] num = ReadLine().Split();
            int N = int.Parse(num[0]), A = int.Parse(num[1]), B = int.Parse(num[2]), C = int.Parse(num[3]), D = int.Parse(num[4]);
            int Ar = (N/A) * B;
            if (N%A != 0)
            {
                Ar = ((N-(N%A)+A) / A) * B;
            }
            int Br = (N/C) * D;
            if (N%C != 0)
            {
                Br = ((N -(N % C) + C) / C) * D;
            }
            int result = Math.Min(Ar, Br);
            WriteLine(result);
        }

    }

}