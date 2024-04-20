int[] dataArray = { 1, 3, 5, 7, 9 }; // Tạo một mảng số nguyên để kiểm tra

Algorithms alg = new Algorithms(); // Khởi tạo đối tượng của lớp Algorithms

// Gọi hàm LinearSearch và in kết quả
bool r1 = alg.LinearSearch(dataArray, 5); // Kết quả: True
Console.WriteLine(r1);
bool r2 = alg.LinearSearch(dataArray, 8); // Kết quả: False
Console.WriteLine(r2);

public class Algorithms
{
    public bool LinearSearch(int[] data, int target)
    {
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] == target) return true;
        }
        return false;
    }
}