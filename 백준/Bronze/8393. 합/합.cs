using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int Sum = 0;
            for (int i = T;  i > 0; i--) 
            {
                Sum += i;
            }
            Console.WriteLine(Sum);
        }   
    }
}