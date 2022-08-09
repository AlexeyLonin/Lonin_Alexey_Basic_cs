// 043. С клавиатуры вводится число N.
// Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значения элементов (через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Кол-во элементов > 0: {count}");
