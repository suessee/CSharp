using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int D = int.Parse(num[0]), H = int.Parse(num[1]), M = int.Parse(num[2]);
            
            DateTime aa = new DateTime(2011, 11, D, 0, 0, 0);
            DateTime sT = new DateTime(2011, 11, 11, 0, 0, 0);
            int result = DateTime.Compare(aa, sT);
            int DtoM = (D - 11) * 24 * 60;

            TimeSpan a = new TimeSpan(H, M, 0);
            TimeSpan start = new TimeSpan(11, 11, 0);
            TimeSpan Res = a.Subtract(start);
            int result2 = TimeSpan.Compare(a, start);
            
            if (result > 0)
            {
                if (result2 > 0 || result2 == 0)
                {
                    WriteLine(DtoM + Res.Hours * 60 + Res.Minutes);
                }
                else if (result2 < 0)
                {
                    TimeSpan get = new TimeSpan(24, 0, 0);
                    TimeSpan GetR = (get.Subtract(start).Add(a));
                    DtoM -= 24 * 60;
                    WriteLine(DtoM + GetR.Hours * 60 + GetR.Minutes);
                }
            }
            else if (result == 0)
            {
                if (result2 > 0)
                {
                    WriteLine(DtoM + Res.Hours * 60 + Res.Minutes);
                }
                else if (result2 == 0)
                {
                    WriteLine(DtoM + Res.Hours * 60 + Res.Minutes);
                }
                else if (result2 < 0)
                {
                    WriteLine(-1);
                }
            }
            else if (result < 0)
            {
                WriteLine(-1);
            }
        
        }
    }
}