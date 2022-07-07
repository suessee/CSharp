using System;
using static System.Console;

namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string s = ReadLine();
            int cnt = 0;
            for (int i = 97; i < 123; i++)
            {
                if (s.Contains(Convert.ToChar(i)))
                {
                    cnt = 0;
                    for (int j = 0; j < s.Length; j++)
                    {
                        if (Convert.ToChar(i) == s[j])
                        {
                            cnt += 1;
                        }
                    }
                    Write(cnt + " ");
                }
                else
                {
                    Write(0 + " ");
                }
            }
        }
    }
}