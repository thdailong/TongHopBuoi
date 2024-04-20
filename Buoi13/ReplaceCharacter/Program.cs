I i = new I();
string result = i.ReplaceCharacters("hello", 'l', 'x');
Console.WriteLine(result); // hexxo

class I
{
    public string ReplaceCharacters(string input, char oldChar, char newChar)
    {
        return input.Replace(oldChar, newChar);
    }
}