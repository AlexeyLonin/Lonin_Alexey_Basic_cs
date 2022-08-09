// 048. Написать программу копирования массива
public class Example
{
    public static void Main()
    {
        int[] arr = { 1, 4, 8, 9, 3 };
 
        int[] copy = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++) {
            copy[i] = arr[i];
        }
 
        Console.WriteLine(String.Join(", ", copy));        // 4, 7, 2
    }
}