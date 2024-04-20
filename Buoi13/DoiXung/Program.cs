// See https://aka.ms/new-console-template for more information
A computer = new A();

Console.Write("String to check palindrome: ");
string s = Console.ReadLine();
if (computer.IsPalindrome(s))
{
    Console.WriteLine("String is palindrome");
}
else
{
    Console.WriteLine("String is not palindrome");
}

class A
{
    public string Reverse(string s)
    {
        string res = "";
        for (int i = s.Length - 1; i >= 0; --i)
        {
            res += s[i];
        }
        return res;
    }
    public bool IsPalindrome(string s)
    {
        string res = Reverse(s);
        return res.Equals(s);
    }

}