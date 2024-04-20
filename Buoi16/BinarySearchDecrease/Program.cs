// Tạo một mảng số nguyên giảm dần từ 10 đến 1
int[] sortedArray = new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
Algorithms alg = new Algorithms();

bool r1 = alg.BinarySearch(sortedArray, 5); // true
Console.WriteLine(r1);
bool r2 = alg.BinarySearch(sortedArray, 11); // false
Console.WriteLine(r2);

public class Algorithms
{
    // Mảng đầu vào data là mảng giảm dần
    public bool BinarySearch(int[] data, int target)
    {
        return BinarySearchRecursive(data, target, 0, data.Length - 1);
    }

    public bool BinarySearchRecursive(int[] data, int target, int left, int right)
    {
        if (left > right)
        {
            return false;
        }

        int mid = (left + right) / 2;
        if (data[mid] == target) return true;
        if (data[mid] < target) return BinarySearchRecursive(data, target, left, mid - 1); //Search on the left
        return BinarySearchRecursive(data, target, mid + 1, right); //Search on the right
    }
}