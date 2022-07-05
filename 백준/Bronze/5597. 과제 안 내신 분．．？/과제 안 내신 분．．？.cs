using System;
using static System.Console;


namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stNum = new int[30];
            int[] St = new int[28];
            int count = 0;
            for (int i = 1; i < 31; i++)
            {
                stNum[count] = i;
                count++;
            }
            count = 0;

            for (int i = 0; i < 28; i++)
            {    
                int a = int.Parse(ReadLine());
                St[i] = a;                
            }

            for (int i = 0; i < St.Length; i++)
            {
                for (int j = 0; j < stNum.Length; j++)
                {
                    if (St[i] == stNum[j])
                    {
                        stNum[j] = 0;
                    }
                }
            }

            for (int i = 0; i < stNum.Length; i++)
            {
                if (stNum[i] != 0 && count != 0)
                {
                    if (count > stNum[i])
                    {
                        WriteLine(stNum[i]);
                        WriteLine(count);
                        break;
                    }
                    else
                    {
                        WriteLine(count);
                        WriteLine(stNum[i]);
                        break;
                    }
                }
                else if (stNum[i] != 0 && count == 0)
                {
                    count += stNum[i];
                }
                
            }   
        }
    }
}