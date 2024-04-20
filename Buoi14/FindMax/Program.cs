Z z = new Z();
Console.WriteLine(z.FindMax(new int[] { 5, 2, 8, 3, 9 })); // Output: 9
Console.WriteLine(z.FindMax(new int[] { 10, 20, 30, 40 })); // Output: 40
Console.WriteLine(z.FindMax(new int[] { 1, 2, 3, 4, 5 })); // Output: 5

class Z
{
    public int FindMax(int[] arr)
    {
        if (arr is null || arr.Length == 1)
            throw new ArgumentException();
        else
            return RecursiveFindMax(arr, 0);
    }

    private int RecursiveFindMax(int[] arr, int index)
    {
        if (index == arr.Length - 1)
        {
            return arr[index];
        }
        int maxAfterIndex = RecursiveFindMax(arr, index + 1);

        return Math.Max(arr[index], maxAfterIndex);
    }
}