using System.Text;
using System.Numerics;
string n = Console.ReadLine();
string[] Num = n.Split();
BigInteger a = BigInteger.Parse(Num[0]), b = BigInteger.Parse(Num[1]);
Console.WriteLine(a / b);
Console.WriteLine(a % b);