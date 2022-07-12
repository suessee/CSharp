using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]);
            int cnt1 = 0;
            int cnt2 = 0;
            int[] All = { A, B, C };

            for (int i = 0; i < All.Length; i++)
            {
                if (All[i] == 1)
                {
                    cnt1++;
                }
                else
                {
                    cnt2++;
                }
            }
            if (cnt1 > cnt2)
            {
                WriteLine(1);
            }
            else if (cnt1 < cnt2)
            {
                WriteLine(2);
            }
        }
    }
}