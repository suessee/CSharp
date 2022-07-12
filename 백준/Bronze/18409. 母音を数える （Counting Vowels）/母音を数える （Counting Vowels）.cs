using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            int N = int.Parse(ReadLine());
            string S = ReadLine();
            int cnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (char.Equals(S[i].ToString(),"a") || char.Equals(S[i].ToString(), "i") || char.Equals(S[i].ToString(), "u") || char.Equals(S[i].ToString(), "e") || char.Equals(S[i].ToString(), "o"))
                {
                    cnt++;
                }
            }
            WriteLine(cnt);
        }
    }
}