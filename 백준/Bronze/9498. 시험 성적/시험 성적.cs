using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            if (a >= 90)
            {
                Console.WriteLine("A");
            }
            else if (a >= 80 && a < 90)
            {
                Console.WriteLine("B");
            }
            else if (a >=70 && a < 80)
            {
                Console.WriteLine("C");
            }
            else if (a >= 60 && a < 70)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
/*String aa = Console.ReadLine();
String[] bb = aa.Split();
int a = int.Parse(bb[0]), b = int.Parse(bb[1]);*/