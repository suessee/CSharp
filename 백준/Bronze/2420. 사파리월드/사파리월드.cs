using System.Numerics;
string[] num = Console.ReadLine().Split();
BigInteger A = BigInteger.Parse(num[0]), B = BigInteger.Parse(num[1]);
Console.WriteLine(BigInteger.Abs(A - B));