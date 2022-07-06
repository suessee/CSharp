using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());
            
            if (A > 2 && B < 5)
            {
                WriteLine("TroyMartian");
                if (A < 7 && B > 1)
                {
                    WriteLine("VladSaturnian");
                }
                else if(A < 3 && B < 4)
                {
                    WriteLine("GraemeMercurian");
                } 
            }
            else if (A<7 && B > 1)
            {
                WriteLine("VladSaturnian");
                if (A < 3 && B < 4)
                {
                    WriteLine("GraemeMercurian");
                }
            }
            else if (A<3 && B < 4)
            {
                WriteLine("GraemeMercurian");
            }
            
        }
    }
}