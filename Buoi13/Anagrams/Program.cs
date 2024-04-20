O o = new O();
bool result1 = o.AreAnagrams("listen", "silent");
bool result2 = o.AreAnagrams("hello", "world");
Console.WriteLine(result1); // true
Console.WriteLine(result2); // false

class O
{
    public bool AreAnagrams(string s1, string s2)
    {
        if (s1.Length != s2.Length)
        {
            return false;
        }

        int[] charCounts = new int[256];

        foreach (char c in s1)
        {
            charCounts[c]++;
        }

        foreach (char c in s2)
        {
            charCounts[c]--;
        }

        for (int i = 0; i < 256; i++)
        {
            if (charCounts[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}