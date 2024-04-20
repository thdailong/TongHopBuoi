// See https://aka.ms/new-console-template for more information
A computer = new A();

Console.Write("String: ");
string s = Console.ReadLine();
Console.WriteLine("Longest unique substring: " + computer.LongestUniqueSubstring(s));

class A
{
    public string LongestUniqueSubstring(string input)
    {
        string res = "";
        Dictionary<char, int> dict = new Dictionary<char, int>();
        for (int i = 0; i < input.Length; i++)
        {
            dict.Clear();
            string tmp = "";
            for (int j = i; j < input.Length; j++)
            {
                if (dict.ContainsKey(input[j]))
                {
                    break;
                }
                dict.Add(input[j], j);
                tmp += input[j];
            }
            if (res.Length < tmp.Length) res = tmp;
        }
        return res;
    }

}