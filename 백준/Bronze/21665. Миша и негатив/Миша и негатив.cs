using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int n = int.Parse(num[0]), m = int.Parse(num[1]);
            string[] input = new string[n];
            int cnt = 0;

            for (int i = 0; i < n; i++)
            {
                string num1 = ReadLine();
                input[i] = num1;
            }
            string no = ReadLine();

            for (int i = 0; i < n; i++)
            {
                string num2 = ReadLine();
                for (int j = 0; j < num2.Length; j++)
                {
                    if (num2[j] == input[i][j])
                    {
                        cnt++;
                    }
                }
            }
            WriteLine(cnt);
        }
    }
}