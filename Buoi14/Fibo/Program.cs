Z z = new Z();
Console.WriteLine(z.Fibo(4)); // Output: 3
Console.WriteLine(z.Fibo(6)); // Output: 8
Console.WriteLine(z.Fibo(7)); // Output: 13

class Z
{
    public int Fibo(int n)
    {
        if (n <= 1) return n;
        return Fibo(n - 1) + Fibo(n - 2);
    }
}