using System;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = 1;
            
            for (int i = 0; i < 3; i++)
            {
                int a = int.Parse(Console.ReadLine());
                num *= a;
            }

            char[] numToC = num.ToString().ToCharArray();

            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                
                for (int j = 0; j < numToC.Length; j++)
                {
                    if (numToC[j].ToString() == i.ToString())
                    {
                        count += 1;
                    }
                }
                Console.WriteLine(count);
                count = 0;
            }
        }
    }
}