using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[2]), C = int.Parse(num[4]);
            int result = 0;
            switch (num[1])
            {
                case "+":
                    result = A + B;
                    break;
                case "-":
                    result = A - B;
                    break;
                case "*":
                    result = A * B;
                    break;
                case "/":
                    result = A / B;
                    break;
                case "%":
                    result = A % B;
                    break;
            }
            if (result == C)
            {
                WriteLine("YES");
            }
            else
            {
                WriteLine("NO");
            }
        }
    }
}