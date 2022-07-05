using System;
using static System.Console;



namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Write(DateTime.Now.Date.ToString("yyyy\nMM\ndd"));
        }
    }
}