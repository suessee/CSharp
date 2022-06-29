using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String aa = Console.ReadLine();
            String[] bb = aa.Split();
            int a = int.Parse(bb[0]), b = int.Parse(bb[1]); 
            Console.WriteLine(a+b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
        }
    }
}
