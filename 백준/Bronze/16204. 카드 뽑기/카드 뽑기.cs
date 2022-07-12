using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int N = int.Parse(num[0]), M = int.Parse(num[1]), K = int.Parse(num[2]);
            int FO = M;
            int FX = N - M;
            int BO = K;
            int BX = N - K;
            int result = Math.Min(FO, BO) + Math.Min(FX,BX);
            WriteLine(result);
        }
    }

}