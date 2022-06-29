using System;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());
            int numA = input / 10;
            int numB =  input % 10;
            int sum = numA + numB;
            int a = sum % 10;
            int b = numB;
            int count = 1;
            int newSum = 0;
            while (true)
            {
                
                newSum = a + b;
                b = a;
                a = newSum % 10;
                count += 1;
                int newSum1 = int.Parse(b.ToString() + a.ToString());
                if (newSum1 == input)
                {
                    if (newSum1 == 0)
                    {
                        count -= 1;
                        break;
                    }
                    break;
                } 

            }
            Console.WriteLine(count);
        }
    }
}