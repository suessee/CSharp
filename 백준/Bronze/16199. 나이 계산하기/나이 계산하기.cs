using System;
using static System.Console;

namespace BaekJoon

{

    public static class Program

    {

        public static void Main()

        {
            string[] num = ReadLine().Split();
            int A = int.Parse(num[0]), B = int.Parse(num[1]), C = int.Parse(num[2]);
            string[] num1 = ReadLine().Split();
            int A1 = int.Parse(num1[0]), B1 = int.Parse(num1[1]), C1 = int.Parse(num1[2]);
            int year = A1 - A;
            int age1 = 0;
            int age2 = 0;
            int age3 = 0;
            if (year <= 0)
            {
                age1 = year;
                age2 = 1;
                age3 = year;
            }
            else
            {
                if (A1 == A)
                {
                    if (B1 > B)
                    {
                        age1 = year ;
                        age2 = age1 + 1;
                        age3 = year;
                    }
                    else if (B1 == B)
                    {
                        if (C1 >= C)
                        {
                            age1 = year;
                            age2 = age1 + 1;
                            age3 = year;
                        }
                        else
                        {
                            age1 = year-1;
                            age2 = year+1;
                            age3 = year;
                        }
                    }
                    else
                    {
                        age1 = year - 1;
                        age2 = year + 1;
                        age3 = age1;
                    }
                }
                else if (A1 > A)
                {
                    if (B1 > B)
                    {
                        age1 = year;
                        age2 = age1 + 1;
                        age3 = year;
                    }
                    else if (B1 == B)
                    {
                        if (C1 >= C)
                        {
                            age1 = year;
                            age2 = age1 + 1;
                            age3 = year;
                        }
                        else
                        {
                            age1 = year - 1;
                            age2 = year + 1;
                            age3 = year;
                        }
                    }
                    else
                    {
                        age1 = year - 1;
                        age2 = year + 1;
                        age3 = year;
                    }
                }
            }
            WriteLine(age1 + "\n" + age2 + "\n" + age3);
        }
    }

}