static char ToUpper(char a)
{
    char newa = a;
    if (a > 96 && a < 123)
    {
        newa = (char)(a - 32);
    }
    else if (a > 64 && a <91)
    {
        newa = (char)(a + 32);
    }
    return newa;
}

string num = Console.ReadLine();
char[] Num = num.ToCharArray();
int cnt = 0;

foreach (var item in Num)
{
    Num[cnt] = ToUpper(item);
    cnt++;
}

foreach (var item in Num)
{
    Console.Write(item);
}

