Z z = new Z();
Console.WriteLine(z.IsPalindrome("radar"));
Console.WriteLine(z.IsPalindrome("level"));
Console.WriteLine(z.IsPalindrome("deified"));
Console.WriteLine(z.IsPalindrome("palindrome"));


class Z
{
    public bool IsPalindrome(string str)
    {
        if (str.Length < 2)
        {
            return true;
        }
        else
        {
            if (str[0] != str[str.Length - 1])
            {
                return false;
            }
            else
            {
                return IsPalindrome(str.Substring(1, str.Length - 2));
            }
        }

    }
}