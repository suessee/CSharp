String[] Num = Console.ReadLine().Split();
int[] NumOfC = {1, 1, 2, 2, 2, 8 };
for (int i = 0; i < Num.Length; i++)
{
    NumOfC[i] = NumOfC[i] - int.Parse(Num[i]);
}
for (int i = 0; i < NumOfC.Length; i++)
{
    Console.Write(NumOfC[i] + " ");
}