using System;
using System.Text;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = ReadLine();

            for (int i = 97; i < 123; i++)
            {
                if (s.Contains(Convert.ToChar(i)))
                {
                    Write(s.IndexOf(Convert.ToChar(i))+" ");
                }
                else
                {
                    Write("-1 ");
                }
            }

        }
    }
}
