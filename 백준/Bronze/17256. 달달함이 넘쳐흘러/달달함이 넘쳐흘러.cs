using System;
using static System.Console;



namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] num1 = ReadLine().Split();
            int Ax = int.Parse(num1[0]), Ay = int.Parse(num1[1]), Az = int.Parse(num1[2]);
            string[] num2 = ReadLine().Split();
            int Cx = int.Parse(num2[0]), Cy = int.Parse(num2[1]), Cz = int.Parse(num2[2]);

            WriteLine("{0} {1} {2}", Cx-Az,Cy/Ay, Cz-Ax);
        }
    }
}
