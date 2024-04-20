// See https://aka.ms/new-console-template for more information
Console.Write("String to reverse: ");
string s = Console.ReadLine();
A computer = new A();
Console.WriteLine("String reversed: " + computer.Reverse(s));

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
}