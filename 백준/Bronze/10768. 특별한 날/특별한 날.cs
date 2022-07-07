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
            
            if (A > 2)
            {
                WriteLine("After");
            }
            else if (A == 2)
            {
                if (B == 18)
                {
                    WriteLine("Special");
                }
                else if (B > 18)
                {
                    WriteLine("After");
                }
                else
                {
                    WriteLine("Before");
                }
            }
            else if (A < 2)
            {
                WriteLine("Before");
            }     
        }
    }
}