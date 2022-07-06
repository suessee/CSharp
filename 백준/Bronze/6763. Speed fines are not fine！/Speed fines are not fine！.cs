using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int L = int.Parse(ReadLine());
            int M = int.Parse(ReadLine());
            if (M - L > 0 && M - L <= 20)
            {
                WriteLine("You are speeding and your fine is $100.");
            }
            else if (M - L > 20 && M - L <= 30)
            {
                WriteLine("You are speeding and your fine is $270.");
            }
            else if (M - L > 30)
            {
                WriteLine("You are speeding and your fine is $500.");
            }
            else
            {
                WriteLine("Congratulations, you are within the speed limit!");
            }

        }
    }
}