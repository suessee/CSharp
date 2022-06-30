using System;
using System.Text;
using static System.Console;

namespace FirstProgram
{
    class Program
    {
        static int SelfNum(int n)
        {
            int num;
            if (n < 10)
            {
                num = n + n;
            }
            else if (n >= 10 && n < 100)
            {
                num = n + (n / 10) + (n % 10);
            }
            else if (n >= 100 && n <1000)
            {
                num = n + (n / 100) + ((n % 100) / 10) + ((n % 100) % 10);
            }
            else if (n >= 1000 && n <10000)
            {
                num = n + (n / 1000) + ((n%1000)/100) + (((n % 1000) % 100)/10) + (((n % 1000) % 100) % 10);
            }
            else
            {
                num = n + 1;
            }
            return num;
        }

        static void Main(string[] args)
        {
            int[] value = new int[10000];

            for (int i = 0; i < 10000; i++)
            {
                value[i] = SelfNum(i);
            }

            StringBuilder SelfN = new StringBuilder();

            bool Check = true;

            for (int i = 0; i < 10001; i++)
            {
                for (int j = 0; j < value.Length; j++)
                {
                    if (value[j] == i)
                    {
                        Check = false;
                        break;
                    }
                    else
                    {
                        Check = true;
                    }
                }
                if (Check)
                {
                    SelfN.AppendLine(i.ToString());
                }
            }
            WriteLine(SelfN);
        }
    }
}