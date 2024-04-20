// See https://aka.ms/new-console-template for more information
A computer = new A();

Console.Write("String to remove duplicate: ");
string s = Console.ReadLine();
Console.WriteLine("String without duplicate: " + computer.RemoveDuplicates(s));

class A
{
    public string RemoveDuplicates(string s)
    {
        string res = "";
        for (int i = 0; i < s.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < res.Length; j++)
            {
                if (s[i] == res[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                res += s[i];
            }
        }
        return res;
    }
}