using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int h = int.Parse(ReadLine());
            
            if (h/2 > 0)
            {

                int a = h / 2;
                int b = h % 2;
                string[] result = new string[a + b];
                for (int i = 0; i < b; i++)
                {
                    result[i] = "4";
                }
                for (int i = 0; i < a; i++)
                {
                    result[i+b] = "8";
                }
                for (int i = 0; i < result.Length; i++)
                {
                    Write(result[i]);
                }
            }
            else if (h == 0)
            {
                WriteLine(1);
            }
            else if (h == 1)
            {
                WriteLine(0);
            }
            

        }
    }
}