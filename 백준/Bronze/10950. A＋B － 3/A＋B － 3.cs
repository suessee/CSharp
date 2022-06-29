using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for (int i = T;  i> 0; i--) 
            {
                String[] Test = Console.ReadLine().Split();
                int a = int.Parse(Test[0]), b = int.Parse(Test[1]);
                Console.WriteLine(a+b);
            }
        }   
    }
}