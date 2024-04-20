Algorithms algorithms = new Algorithms();
int[] array = new int[] { 3, 2, 5, 10, 6 };
algorithms.BubbleSort(array); // kết quả array sẽ được sắp xếp lại: 10, 6, 5, 3, 2

Console.WriteLine(string.Join(", ", array));

public class Algorithms
{
    public void BubbleSort(int[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = i + 1; j < data.Length; j++)
            {
                if (data[i] < data[j])
                {
                    int tmp = data[i];
                    data[i] = data[j];
                    data[j] = tmp;
                }
            }
        }
    }
}