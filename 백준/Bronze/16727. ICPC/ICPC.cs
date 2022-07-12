using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int p1 = int.Parse(num[0]), s1 = int.Parse(num[1]);
            string[] num1 = ReadLine().Split();
            int s2 = int.Parse(num1[0]), p2 = int.Parse(num1[1]);
            int pAway = s1;
            int sAway = p2;
            int pResult = p1 + p2;
            int sResult = s1 + s2;
            if (pResult == sResult)
            {
                if (pAway == sAway)
                {
                    WriteLine("Penalty");
                }
                else if (pAway > sAway)
                {
                    WriteLine("Esteghlal");
                }
                else if (pAway < sAway)
                {
                    WriteLine("Persepolis");
                }
            }
            else
            {
                if (pResult > sResult)
                {
                    WriteLine("Persepolis");
                }
                else if (pResult < sResult)
                {
                    WriteLine("Esteghlal");
                }
            }
        }
    }

}