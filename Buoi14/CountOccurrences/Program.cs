Z z = new Z();
Console.WriteLine(z.CountOccurrences("hello", 'l')); // Output: 2
Console.WriteLine(z.CountOccurrences("radar", 'r')); // Output: 2
Console.WriteLine(z.CountOccurrences("banana", 'a')); // Output: 3

class Z
{
    public int CountOccurrences(string str, char target)
    {
        return RecursiveCountOccurrences(str, target, 0, str.Length - 1);
    }

    public int RecursiveCountOccurrences(string str, char target, int left, int right)
    {
        if (left > right) return 0;
        int mid = (left + right) / 2;
        int res = 0;
        if (str[mid] == target) res = 1;
        int _left = RecursiveCountOccurrences(str, target, left, mid - 1);
        int _right = RecursiveCountOccurrences(str, target, mid + 1, right);
        return res + _left + _right;
    }
}