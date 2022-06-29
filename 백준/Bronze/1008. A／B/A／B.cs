using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            String aa = Console.ReadLine();
            String[] bb = aa.Split();
            double a = double.Parse(bb[0]), b = double.Parse(bb[1]); 
            Console.WriteLine(a/b);
        }
    }
}
