Algorithms algorithms = new Algorithms();
int[] array = new int[] { 3, 2, 5, 10, 6 };
algorithms.BubbleSort(array); // kết quả array sẽ được sắp xếp lại: 2, 3, 5, 6, 10

Console.WriteLine(string.Join(", ", array));

public class Algorithms
{
    /// <summary>
    /// Hàm này sẽ sắp xếp lại dữ liệu được truyền vào
    /// </summary>
    /// <param name="data"></param>
    public void BubbleSort(int[] data)
    {
        for (int i = 0; i < data.Length; i++)
        {
            for (int j = i + 1; j < data.Length; j++)
            {
                if (data[i] > data[j])
                {
                    int tmp = data[i];
                    data[i] = data[j];
                    data[j] = tmp;
                }
            }
        }
    }
}