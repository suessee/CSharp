using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(DateTime.Now.Date.ToString("yyyy-MM-dd"));
        }
    }
}