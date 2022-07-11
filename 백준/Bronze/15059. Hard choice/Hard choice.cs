using System;
using static System.Console;



namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {


            string[] num = ReadLine().Split();
            int Ca = int.Parse(num[0]), Ba = int.Parse(num[1]), Pa = int.Parse(num[2]);

            string[] num1 = ReadLine().Split();
            int Cr = int.Parse(num1[0]), Br = int.Parse(num1[1]), Pr = int.Parse(num1[2]);

            int result = 0;
            if (Cr > Ca)
            {
                result += Cr - Ca;
            }
            if (Br > Ba)
            {
                result += Br - Ba;
            }
            if (Pr > Pa)
            {
                result += Pr - Pa;
            }
            WriteLine(result);
        }

    }

}