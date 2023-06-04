﻿Console.WriteLine(ProductInRange(9, 10));
Console.Read();


// Factorial using recursion
static System.Numerics.BigInteger Factorial(int n)
{
    return (Math.Abs(n) == 1 || n == 0 ? Math.Sign(n)*1 : n * Factorial(Math.Sign(n) * (Math.Abs(n)-1)));
}

static System.Numerics.BigInteger ProductInRange(int m, int n)
{
    return (n > m? n * ProductInRange(m, n-1) : m);
}