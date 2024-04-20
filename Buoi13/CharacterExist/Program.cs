// See https://aka.ms/new-console-template for more information
A computer = new A();

Console.Write("String : ");
string s = Console.ReadLine();
Console.Write("Character to count: ");
char character = char.Parse(Console.ReadLine());
Console.Write("Number of occurrences: " + computer.CountOccurrences(s, character));

class A
{
    public int CountOccurrences(string input, char character)
    {
        int count = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (character == input[i])
            {
                count++;
            }
        }
        return count;
    }
}