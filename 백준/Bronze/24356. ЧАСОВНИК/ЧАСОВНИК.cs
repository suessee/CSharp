using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int t1 = int.Parse(num[0]), m1 = int.Parse(num[1]), t2 = int.Parse(num[2]), m2 = int.Parse(num[3]);
            int result = 0;
            if (m1 > m2)
            {
                t2 -= 1;
                m2 += 60;
                if (t2 < t1)
                {
                    result = (t2 - t1 + 24) * 60 + (m2 - m1);
                }
                else
                {
                    result = (t2 - t1) * 60 + (m2 - m1);
                }
            }
            else
            {
                if (t2 < t1)
                {
                    result = (t2 - t1 + 24) * 60 + (m2 - m1);
                }
                else
                {
                    result = (t2 - t1) * 60 + (m2 - m1);
                }
            }
            
            WriteLine(result + " " + result/30);
        }
    }
}