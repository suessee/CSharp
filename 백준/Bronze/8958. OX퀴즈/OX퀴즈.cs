using System;
namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            string[] input = new string[num];

            for (int i = 0; i < num; i++)
            {
                input[i] = Console.ReadLine();
                char[] Check = input[i].ToCharArray();
                int Sum = 0;
                int score = 0;
                int count = 0;

                while (true)
                {
                    if (Check[count].ToString() == "O")
                    {
                        score++;
                        Sum += score;
                    }
                    else
                    {
                        score = 0;
                    }

                    count++;

                    if (count == Check.Length) break;
                }

                Console.WriteLine(Sum);
            }
        }
    }
}
