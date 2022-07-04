using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                string input = ReadLine();
                string[] num = input.Split();
                int a = int.Parse(num[0]), b = int.Parse(num[1]);
                if (a == 0&& a == b)
                {
                    break;
                }
                else
                {
                    if (a > b)
                    {
                        WriteLine("Yes");
                    }
                    else
                    {
                        WriteLine("No");
                    }
                    
                }
                
            }
            
        }
    }
}