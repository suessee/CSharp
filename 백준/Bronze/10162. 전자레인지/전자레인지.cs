using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            int T = int.Parse(ReadLine());

            int A = 300, B = 60, C = 10;
            int[] result = new int[3];

            if (T >= A)
            {
                result[0] = T / A;
                if (T%A >= B)
                {
                    result[1] = (T % A) / B;
                    result[2] = (T % A) % B / C;
                    if (((T % A) % B) % C == 0)
                    {
                        WriteLine(result[0] + " " + result[1] + " " + result[2]);
                    }
                    else
                    {
                        WriteLine(-1);
                    }
                }
                else
                {
                    result[1] = 0;
                    result[2] = (T % A) / C;
                    if (((T % A) % B) % C == 0)
                    {
                        WriteLine(result[0] + " " + result[1] + " " + result[2]);
                    }
                    else
                    {
                        WriteLine(-1);
                    }
                }
            }
            else if (T < A)
            {
                result[0] = 0;

                if (T >= B)
                {
                    result[1] = T / B;
                    result[2] = (T  % B) / C;
                    if ((T % B) % C == 0)
                    {
                        WriteLine(result[0] + " " + result[1] + " " + result[2]);
                    }
                    else
                    {
                        WriteLine(-1);
                    }
                }
                else
                {
                    result[1] = 0;
                    result[2] = T / C;
                    if (T % C == 0)
                    {
                        WriteLine(result[0] + " " + result[1] + " " + result[2]);
                    }
                    else
                    {
                        WriteLine(-1);
                    }
                }
            }
        }
    }
}