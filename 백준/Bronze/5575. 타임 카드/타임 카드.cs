using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                string[] num = ReadLine().Split();
                int h1 = int.Parse(num[0]), m1 = int.Parse(num[1]), s1 = int.Parse(num[2]), h2 = int.Parse(num[3]), m2 = int.Parse(num[4]), s2 = int.Parse(num[5]);
                TimeSpan go = new TimeSpan(h1, m1, s1);
                TimeSpan home = new TimeSpan(h2, m2, s2);
                TimeSpan result = home.Subtract(go);
                WriteLine(result.Hours + " " + result.Minutes + " " + result.Seconds);
            }
            
            

        }
    }
}